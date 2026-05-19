using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Club_Otomasyon
{
    public partial class Etkinlik : Form
    {
        studentsDbContext db = new studentsDbContext();
        public Etkinlik()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime eventDate;
                if (!DateTime.TryParse(txt_date.Text, out eventDate))
                {
                    MessageBox.Show("Lütfen geçerli bir tarih giriniz! (Örnek: 25.12.2024)");
                    return;
                }

                if (combo_kulup.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir kulüp seçiniz!");
                    return;
                }


                int selectedClubId = (int)combo_kulup.SelectedValue;
                Event newevent = new Event()
                {
                    event_name = txt_name.Text,
                    event_date = eventDate,
                    event_yer_saat = txt_yer_saat.Text,
                    club_ıd = selectedClubId


                };

                db.events.Add(newevent);
                db.SaveChanges();


                MessageBox.Show("Yeni Etkinlik Eklendi !");
                btn_listele.PerformClick();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var Etkinlik = db.events

                     .Select(E => new
                     {
                         E.event_ıd,
                         E.event_name,
                         E.event_date,
                         E.event_yer_saat,
                         club_id = E.club_ıd,
                         KulupAdi = E.kulup.club_name
                     })
                     .ToList();
                dataGridView1.DataSource = Etkinlik;

                dataGridView1.Columns["event_ıd"].HeaderText = "event Id";
                dataGridView1.Columns["event_name"].HeaderText = "Etkinlik Adı";
                dataGridView1.Columns["event_date"].HeaderText = "Etkinlik Tarihi";

                dataGridView1.Columns["event_yer_saat"].HeaderText = "Etkinlik Yer ve Saat";


                dataGridView1.Columns["event_ıd"].Visible = false;
                

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void Etkinlik_Load(object sender, EventArgs e)
        {
            try
            {

                var kulüpler = db.clubs.Select(k => new
                {
                    k.club_ıd,
                    k.club_name
                }).ToList();


                combo_kulup.DataSource = kulüpler;
                combo_kulup.DisplayMember = "club_name";
                combo_kulup.ValueMember = "club_ıd";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kulüpler yüklenirken hata: {ex.Message}");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                            "Silmek istediğinize emin misiniz?",
                            "Silme Onayı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["event_ıd"].Value);
                        Event etkinlik = db.events.Find(selectedId);
                        if (etkinlik != null)
                        {
                            db.events.Remove(etkinlik);
                            db.SaveChanges();

                            MessageBox.Show("Etkinlik Silindi!");
                            btn_listele.PerformClick();
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["event_ıd"].Value);
                    Event etkinlik = db.events.Find(selectedId);
                    if (etkinlik != null)
                    {
                        etkinlik.event_name = txt_name.Text;
                        etkinlik.event_date = Convert.ToDateTime(txt_date.Text);
                        etkinlik.event_yer_saat = txt_yer_saat.Text;

                        etkinlik.club_ıd= (int)combo_kulup.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Etkinlik  güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
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
                    
                    txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["event_name"].Value.ToString();
                    txt_date.Text = dataGridView1.Rows[e.RowIndex].Cells["event_date"].Value.ToString();
                    txt_yer_saat.Text = dataGridView1.Rows[e.RowIndex].Cells["event_yer_saat"].Value.ToString();

                    int clubId = (int)dataGridView1.Rows[e.RowIndex].Cells["club_id"].Value;
                    combo_kulup.SelectedValue = clubId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
    
}
