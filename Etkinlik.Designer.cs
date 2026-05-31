namespace Club_Otomasyon
{
    partial class Etkinlik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_isim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.combo_kulup = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label_yersaat = new System.Windows.Forms.Label();
            this.txt_yer_saat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isim.Location = new System.Drawing.Point(351, 351);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(98, 22);
            this.label_isim.TabIndex = 1;
            this.label_isim.Text = "Etkinlik Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(351, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etkinlik Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(351, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kulüp Adı";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(501, 351);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(387, 22);
            this.txt_name.TabIndex = 4;
            // 
            // combo_kulup
            // 
            this.combo_kulup.FormattingEnabled = true;
            this.combo_kulup.Items.AddRange(new object[] {
            "Muhasebe ve Finans Topluluğu",
            "Yönetim Bilişim Sistemleri Topluluğu  ",
            "Bucak İşletme ve Kariyer Topluluğu",
            "Genç Akademi Topluluğu",
            "Sahne Sanatları Topluluğu",
            "Sağlık ve Yaşam Bilimleri Topluluğu",
            "Gümrük ve Ticaret Topluluğu"});
            this.combo_kulup.Location = new System.Drawing.Point(501, 515);
            this.combo_kulup.Name = "combo_kulup";
            this.combo_kulup.Size = new System.Drawing.Size(387, 24);
            this.combo_kulup.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(501, 407);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(387, 22);
            this.txt_date.TabIndex = 6;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ekle.Location = new System.Drawing.Point(228, 580);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(106, 50);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sil.Location = new System.Drawing.Point(383, 580);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(105, 49);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_guncelle.Location = new System.Drawing.Point(531, 580);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(99, 49);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listele.Location = new System.Drawing.Point(683, 580);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(107, 49);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // label_yersaat
            // 
            this.label_yersaat.AutoSize = true;
            this.label_yersaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yersaat.Location = new System.Drawing.Point(351, 461);
            this.label_yersaat.Name = "label_yersaat";
            this.label_yersaat.Size = new System.Drawing.Size(104, 22);
            this.label_yersaat.TabIndex = 11;
            this.label_yersaat.Text = "Yer ve Saat";
            // 
            // txt_yer_saat
            // 
            this.txt_yer_saat.Location = new System.Drawing.Point(501, 463);
            this.txt_yer_saat.Name = "txt_yer_saat";
            this.txt_yer_saat.Size = new System.Drawing.Size(387, 22);
            this.txt_yer_saat.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(841, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Club_Otomasyon.Properties.Resources.ChatGPT_Image_31_May_2026_22_48_54;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_yer_saat);
            this.Controls.Add(this.label_yersaat);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.combo_kulup);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Etkinlik";
            this.Text = "Etkinlik";
            this.Load += new System.EventHandler(this.Etkinlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox combo_kulup;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label_yersaat;
        private System.Windows.Forms.TextBox txt_yer_saat;
        private System.Windows.Forms.Button button1;
    }
}