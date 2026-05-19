using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Entity;
using System.Reflection;



namespace Club_Otomasyon
{
    public partial class EtkÖğrenci : Form
    {
        public EtkÖğrenci()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        studentsDbContext db = new studentsDbContext();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.studentEvents
                .Include(se => se.Student)
                .Include(se => se.Event.kulup)
                .Select(se => new
                {
                    se.stuEvent_ıd,
                    ÖğrenciId = se.student_ıd,
                    ÖğrenciAdı = se.Student.student_name,
                    ÖğrenciSoyadı = se.Student.student_surname,
                    EtkinlikId = se.event_ıd,
                    EtkinlikAdı = se.Event.event_name,
                    EtkinlikTarihi = se.Event.event_date,
                    kulup = se.Event.kulup.club_name
                })
                .ToList();

                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["stuEvent_ıd"].Visible = false;
                dataGridView1.Columns["öğrenciId"].Visible = false;   
                dataGridView1.Columns["EtkinlikId"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");    
            }
        }

        private void EtkÖğrenci_Load(object sender, EventArgs e)
        {
            try
            {
                combo_ogrenci.DataSource = db.students
                .OrderBy(s => s.student_name)
                .Select(s => new
                {
                    s.student_ıd,
                    FullName = s.student_name + " " + s.student_surname
                })
                .ToList();
                combo_ogrenci.DisplayMember = "FullName";
                combo_ogrenci.ValueMember = "student_ıd";

                combo_etkinlik.DataSource = db.events
                .Include(E => E.kulup)
                .OrderBy(E => E.event_name)
                .Select(E => new

                {
                    E.event_ıd,
                    EventInfo = E.event_name 
                })
                .ToList();
                combo_etkinlik.DisplayMember = "EventInfo";
                combo_etkinlik.ValueMember = "event_ıd";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) 
                {
                    
                    int selectedStudentId = (int)dataGridView1.Rows[e.RowIndex].Cells["ÖğrenciId"].Value;
                    int selectedEventId = (int)dataGridView1.Rows[e.RowIndex].Cells["EtkinlikId"].Value;

                    combo_ogrenci.SelectedValue = selectedStudentId;
                    combo_etkinlik.SelectedValue = selectedEventId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedStudentId = (int)combo_ogrenci.SelectedValue;
                int selectedEventId = (int)combo_etkinlik.SelectedValue;

                var newRecord = new StudentEvent
                {
                    student_ıd = selectedStudentId,
                    event_ıd= selectedEventId,


                };
                db.studentEvents.Add(newRecord);
                db.SaveChanges();

                MessageBox.Show("kayıt başarıyla eklendi");

                btn_listele.PerformClick();

            }

            catch( Exception ex )
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                    "silmek istediğinize emin misiniz?",
                    "silme onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["stuEvent_ıd"].Value);

                        var recordToDelete = db.studentEvents.Find(selectedId);
                        if (recordToDelete != null)
                        {
                            db.studentEvents.Remove(recordToDelete);
                            db.SaveChanges();

                            MessageBox.Show("Kayıt başarıyla silindi");
                            btn_listele.PerformClick();

                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı!!");
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    var result = db.studentEvents
                    .GroupBy(se => new
                     {
                      se.Student.student_ıd,
                        se.Student.student_name,
                        se.Student.student_surname,

                    })
                   .Select(g => new
                    {
                       FullName = g.Key.student_name + " " + g.Key.student_surname,
                       TotalCount = g.Count()
                    })

                  .OrderByDescending(x => x.TotalCount)
                  .FirstOrDefault();

                    if (result != null)
                    {
                        label3.Text = $"{result.FullName} {result.TotalCount} etkinliğe katılmış";
                    }
                    else
                    {
                        label3.Text = "kayıt bulunamadı";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata ={ex.Message}");
            }
        }
    }
}
