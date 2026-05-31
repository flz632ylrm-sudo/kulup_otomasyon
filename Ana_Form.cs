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
    public partial class Ana_Form : Form
    {
        public Ana_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ogrenciFormu = new Form1();        
            this.Hide();  
            ogrenciFormu.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EtkÖğrenci ogrenciFormu = new EtkÖğrenci();
            this.Hide();
            ogrenciFormu.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Etkinlik ogrenciFormu = new Etkinlik();
            this.Hide();
            ogrenciFormu.ShowDialog();
            this.Show();
        }

        private void Ana_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
