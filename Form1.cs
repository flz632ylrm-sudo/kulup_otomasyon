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
                    var students = db.students.ToList();
                    dataGridView1.DataSource = students;

                    dataGridView1.Columns["student_ıd"].HeaderText = "Öğrenci Id";
                    dataGridView1.Columns["student_name"].HeaderText = "Öğrenci Adı";
                    dataGridView1.Columns["student_surname"].HeaderText = "Öğrenci Soyad";
                    dataGridView1.Columns["student_phone"].HeaderText = "Telefen Numarası";
                    dataGridView1.Columns["student_department"].HeaderText = "Bölüm";
                    dataGridView1.Columns["student_email"].HeaderText = "Öğrenci E-Mail";

                    dataGridView1.Columns["student_ıd"].Visible = false;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
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

                   
                };

                    db.students.Add(newstudent);
                    db.SaveChanges();

                
                    MessageBox.Show("Yeni Öğrenci Eklendi !");
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
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["student_name"].Value.ToString();
                txt_soyisim.Text = dataGridView1.Rows[e.RowIndex].Cells["student_surname"].Value.ToString();
                txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["student_phone"].Value.ToString();
                cmb_bolum.Text = dataGridView1.Rows[e.RowIndex].Cells["student_department"].Value.ToString();
                txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells["student_email"].Value.ToString();

                var selectedStudent = dataGridView1.Rows[e.RowIndex].DataBoundItem as student;
                
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
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["student_ıd"].Value);
                        student Student = db.students.Find(selectedId);
                        if (Student != null)
                        {
                            db.students.Remove(Student);
                            db.SaveChanges();

                            MessageBox.Show("Öğrenci Silindi!");
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
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["student_ıd"].Value);
                    student student = db.students.Find(selectedId);
                    if (student != null)
                    {
                        student.student_name = txt_isim.Text;
                        student.student_surname = txt_soyisim.Text;
                        student.student_phone = txt_telefon.Text;
                        student.student_department = cmb_bolum.Text;
                        student.student_email = txt_email.Text;
                       

                        db.SaveChanges();
                        MessageBox.Show("Öğrenci  güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }

        }
    }
}
