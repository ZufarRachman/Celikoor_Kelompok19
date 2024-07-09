namespace Celikoor_Kelompok19
{
    partial class FormTambahFilm
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
            this.textBoxTahun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKelompok = new System.Windows.Forms.ComboBox();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBahasa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCoverImage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDiskonNominal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxIsSubIndo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxAktor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxPeranAktor = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaftarAktor = new System.Windows.Forms.DataGridView();
            this.buttonTambahAktor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarAktor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTahun
            // 
            this.textBoxTahun.Location = new System.Drawing.Point(155, 300);
            this.textBoxTahun.Name = "textBoxTahun";
            this.textBoxTahun.Size = new System.Drawing.Size(96, 20);
            this.textBoxTahun.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(79, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Tahun : ";
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.Location = new System.Drawing.Point(156, 120);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.Size = new System.Drawing.Size(284, 174);
            this.textBoxSinopsis.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Sinopsis : ";
            // 
            // comboBoxKelompok
            // 
            this.comboBoxKelompok.FormattingEnabled = true;
            this.comboBoxKelompok.Items.AddRange(new object[] {
            "",
            "Admin",
            "Operator",
            "Kasir"});
            this.comboBoxKelompok.Location = new System.Drawing.Point(155, 374);
            this.comboBoxKelompok.Name = "comboBoxKelompok";
            this.comboBoxKelompok.Size = new System.Drawing.Size(98, 21);
            this.comboBoxKelompok.TabIndex = 81;
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.Location = new System.Drawing.Point(155, 335);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(284, 20);
            this.textBoxDurasi.TabIndex = 80;
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(156, 84);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(284, 20);
            this.textBoxJudul.TabIndex = 79;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(826, 515);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(101, 31);
            this.buttonKeluar.TabIndex = 78;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.White;
            this.buttonKosongi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKosongi.FlatAppearance.BorderSize = 0;
            this.buttonKosongi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKosongi.Location = new System.Drawing.Point(694, 515);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(101, 31);
            this.buttonKosongi.TabIndex = 77;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambah.FlatAppearance.BorderSize = 0;
            this.buttonTambah.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(594, 515);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 31);
            this.buttonTambah.TabIndex = 76;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(51, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Kelompok : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(77, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Durasi : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(915, 30);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "TAMBAH FILM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(86, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Judul : ";
            // 
            // comboBoxBahasa
            // 
            this.comboBoxBahasa.FormattingEnabled = true;
            this.comboBoxBahasa.Location = new System.Drawing.Point(156, 410);
            this.comboBoxBahasa.Name = "comboBoxBahasa";
            this.comboBoxBahasa.Size = new System.Drawing.Size(98, 21);
            this.comboBoxBahasa.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(68, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Bahasa : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(56, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Sub Indo : ";
            // 
            // textBoxCoverImage
            // 
            this.textBoxCoverImage.Location = new System.Drawing.Point(155, 483);
            this.textBoxCoverImage.Name = "textBoxCoverImage";
            this.textBoxCoverImage.Size = new System.Drawing.Size(284, 20);
            this.textBoxCoverImage.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(28, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "Cover Image : ";
            // 
            // textBoxDiskonNominal
            // 
            this.textBoxDiskonNominal.Location = new System.Drawing.Point(155, 520);
            this.textBoxDiskonNominal.Name = "textBoxDiskonNominal";
            this.textBoxDiskonNominal.Size = new System.Drawing.Size(99, 20);
            this.textBoxDiskonNominal.TabIndex = 93;
            this.textBoxDiskonNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(5, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Diskon Nominal : ";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(155, 55);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(284, 20);
            this.textBoxID.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(108, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 94;
            this.label10.Text = "ID :";
            // 
            // comboBoxIsSubIndo
            // 
            this.comboBoxIsSubIndo.FormattingEnabled = true;
            this.comboBoxIsSubIndo.Location = new System.Drawing.Point(155, 448);
            this.comboBoxIsSubIndo.Name = "comboBoxIsSubIndo";
            this.comboBoxIsSubIndo.Size = new System.Drawing.Size(98, 21);
            this.comboBoxIsSubIndo.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(260, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 122;
            this.label11.Text = "%";
            // 
            // comboBoxAktor
            // 
            this.comboBoxAktor.FormattingEnabled = true;
            this.comboBoxAktor.Location = new System.Drawing.Point(568, 90);
            this.comboBoxAktor.Name = "comboBoxAktor";
            this.comboBoxAktor.Size = new System.Drawing.Size(149, 21);
            this.comboBoxAktor.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(495, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 125;
            this.label13.Text = "Aktor : ";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "",
            "Admin",
            "Operator",
            "Kasir"});
            this.comboBoxGenre.Location = new System.Drawing.Point(568, 54);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(132, 21);
            this.comboBoxGenre.TabIndex = 124;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(488, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 123;
            this.label14.Text = "Genre : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(724, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 135;
            this.label18.Text = "Peran : ";
            // 
            // comboBoxPeranAktor
            // 
            this.comboBoxPeranAktor.FormattingEnabled = true;
            this.comboBoxPeranAktor.Location = new System.Drawing.Point(801, 90);
            this.comboBoxPeranAktor.Name = "comboBoxPeranAktor";
            this.comboBoxPeranAktor.Size = new System.Drawing.Size(126, 21);
            this.comboBoxPeranAktor.TabIndex = 140;
            // 
            // dataGridViewDaftarAktor
            // 
            this.dataGridViewDaftarAktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarAktor.Location = new System.Drawing.Point(492, 184);
            this.dataGridViewDaftarAktor.Name = "dataGridViewDaftarAktor";
            this.dataGridViewDaftarAktor.Size = new System.Drawing.Size(435, 211);
            this.dataGridViewDaftarAktor.TabIndex = 141;
            this.dataGridViewDaftarAktor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarAktor_CellContentClick);
            // 
            // buttonTambahAktor
            // 
            this.buttonTambahAktor.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTambahAktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahAktor.FlatAppearance.BorderSize = 0;
            this.buttonTambahAktor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahAktor.ForeColor = System.Drawing.Color.White;
            this.buttonTambahAktor.Location = new System.Drawing.Point(745, 132);
            this.buttonTambahAktor.Name = "buttonTambahAktor";
            this.buttonTambahAktor.Size = new System.Drawing.Size(182, 31);
            this.buttonTambahAktor.TabIndex = 142;
            this.buttonTambahAktor.Text = "TAMBAH AKTOR";
            this.buttonTambahAktor.UseVisualStyleBackColor = false;
            this.buttonTambahAktor.Click += new System.EventHandler(this.buttonTambahAktor_Click);
            // 
            // FormTambahFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 560);
            this.Controls.Add(this.buttonTambahAktor);
            this.Controls.Add(this.dataGridViewDaftarAktor);
            this.Controls.Add(this.comboBoxPeranAktor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxAktor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxIsSubIndo);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDiskonNominal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCoverImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBahasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTahun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSinopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKelompok);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "FormTambahFilm";
            this.Text = "FormTambahFilm";
            this.Load += new System.EventHandler(this.FormTambahFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarAktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTahun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSinopsis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKelompok;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBahasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCoverImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiskonNominal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBoxIsSubIndo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxAktor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxPeranAktor;
        private System.Windows.Forms.DataGridView dataGridViewDaftarAktor;
        private System.Windows.Forms.Button buttonTambahAktor;
    }
}