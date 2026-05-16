using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        studentsDbContext db = new studentsDbContext();

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new studentsDbContext())
                {
                    var students = db.students.ToList();
                    dataGridView1.DataSource = students;

                    dataGridView1.Columns["Student_ıd"].HeaderText = "Öğrenci Id";
                    dataGridView1.Columns["student_name"].HeaderText = "Öğrenci Adı";
                    dataGridView1.Columns["student_surname"].HeaderText = "Öğrenci Soyad";
                    dataGridView1.Columns["student_phone"].HeaderText = "Telefen Numarası";
                    dataGridView1.Columns["student_department"].HeaderText = "Bölüm";
                    dataGridView1.Columns["student_email"].HeaderText = "Öğrenci E-Mail";

                    dataGridView1.Columns["student_ıd"].Visible = false;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                student newstudent = new student()
                {
                    student_name = txt_isim.Text,
                    student_surname = txt_soyisim.Text,
                    student_phone = txt_telefon.Text,
                    student_department = cmb_bolum.Text,
                    student_email = txt_email.Text,

                    club_ıd = (int)cmb_kulup.SelectedValue
                };

                using (var db = new studentsDbContext())

                {
                    db.students.Add(newstudent);
                    db.SaveChanges();

                }
                MessageBox.Show("Yeni Müşteri Eklendi !");
                btn_listele.PerformClick();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClubsToComboBox();
        }
        private void LoadClubsToComboBox()
        {
            try
            {
                using (var db = new studentsDbContext())
                {

                    var clubs = db.clubs.ToList();

                    cmb_kulup.DisplayMember = "club_name";  // Kullanıcıya gözükecek alan
                    cmb_kulup.ValueMember = "club_ıd";      // Arkada saklanacak değer
                    cmb_kulup.DataSource = clubs;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"kulüpler eklenirken hata :{ex.Message}");
            }
        }
    } 
    }
