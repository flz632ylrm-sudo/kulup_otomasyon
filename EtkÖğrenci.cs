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



namespace Club_Otomasyon
{
    public partial class EtkÖğrenci : Form
    {
        public EtkÖğrenci()
        {
            InitializeComponent();
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
                    ÖğrenciAdı = se.Student.student_name,
                    ÖğrenciSoyadı = se.Student.student_surname,
                    EtkinlikAdı = se.Event.event_name,
                    EtkinlikTarihi = se.Event.event_date,
                    kulup = se.Event.kulup.club_name
                })
                .ToList();

                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["stuEvent_ıd"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");    
            }
        }
    }
}
