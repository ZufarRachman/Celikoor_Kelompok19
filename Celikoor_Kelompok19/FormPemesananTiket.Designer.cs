namespace Celikoor_Kelompok19
{
    partial class FormPemesananTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPemesananTiket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.comboBoxJudul = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTanggalPesan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSisaKursi = new System.Windows.Forms.Label();
            this.lblTotalKursi = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelColumnA = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelColumnB = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelColumnC = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblJumlahDiskon = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.lblKursiTerpilih = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotalAkhir = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKelompok = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAktorUtama = new System.Windows.Forms.Label();
            this.lblDurasiFilm = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKonfirmasi = new System.Windows.Forms.Button();
            this.comboBoxJamPemutaran = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.comboBoxJamPemutaran);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.comboBoxStudio);
            this.panel1.Controls.Add(this.comboBoxCinema);
            this.panel1.Controls.Add(this.comboBoxJudul);
            this.panel1.Controls.Add(this.dateTimePickerTanggalPesan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 264);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(97, 107);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(73, 21);
            this.comboBoxStudio.TabIndex = 101;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(97, 75);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(250, 21);
            this.comboBoxCinema.TabIndex = 101;
            this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
            // 
            // comboBoxJudul
            // 
            this.comboBoxJudul.FormattingEnabled = true;
            this.comboBoxJudul.Location = new System.Drawing.Point(97, 12);
            this.comboBoxJudul.Name = "comboBoxJudul";
            this.comboBoxJudul.Size = new System.Drawing.Size(411, 21);
            this.comboBoxJudul.TabIndex = 100;
            this.comboBoxJudul.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudul_SelectedIndexChanged);
            // 
            // dateTimePickerTanggalPesan
            // 
            this.dateTimePickerTanggalPesan.Location = new System.Drawing.Point(97, 43);
            this.dateTimePickerTanggalPesan.Name = "dateTimePickerTanggalPesan";
            this.dateTimePickerTanggalPesan.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerTanggalPesan.TabIndex = 99;
            this.dateTimePickerTanggalPesan.ValueChanged += new System.EventHandler(this.dateTimePickerTanggalPesan_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Studio : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Cinema : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Tanggal : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Judul : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSisaKursi);
            this.panel2.Controls.Add(this.lblTotalKursi);
            this.panel2.Controls.Add(this.lblStudio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblHarga);
            this.panel2.Location = new System.Drawing.Point(19, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 103);
            this.panel2.TabIndex = 102;
            // 
            // lblSisaKursi
            // 
            this.lblSisaKursi.AutoSize = true;
            this.lblSisaKursi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSisaKursi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisaKursi.ForeColor = System.Drawing.Color.Red;
            this.lblSisaKursi.Location = new System.Drawing.Point(296, 16);
            this.lblSisaKursi.Name = "lblSisaKursi";
            this.lblSisaKursi.Size = new System.Drawing.Size(116, 20);
            this.lblSisaKursi.TabIndex = 100;
            this.lblSisaKursi.Text = "( Sisa Kursi ) ";
            // 
            // lblTotalKursi
            // 
            this.lblTotalKursi.AutoSize = true;
            this.lblTotalKursi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalKursi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKursi.ForeColor = System.Drawing.Color.Black;
            this.lblTotalKursi.Location = new System.Drawing.Point(203, 16);
            this.lblTotalKursi.Name = "lblTotalKursi";
            this.lblTotalKursi.Size = new System.Drawing.Size(49, 20);
            this.lblTotalKursi.TabIndex = 99;
            this.lblTotalKursi.Text = "Kursi";
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio.ForeColor = System.Drawing.Color.Black;
            this.lblStudio.Location = new System.Drawing.Point(91, 16);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(81, 20);
            this.lblStudio.TabIndex = 94;
            this.lblStudio.Text = "IMAX 3D";
            this.lblStudio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(104, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Harga :        Rp.";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.Black;
            this.lblHarga.Location = new System.Drawing.Point(248, 59);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(58, 20);
            this.lblHarga.TabIndex = 98;
            this.lblHarga.Text = "Harga";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.flowLayoutPanelColumnA);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.flowLayoutPanelColumnB);
            this.panel3.Controls.Add(this.flowLayoutPanelColumnC);
            this.panel3.Location = new System.Drawing.Point(12, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 429);
            this.panel3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(419, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "C";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(219, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "B";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelColumnA
            // 
            this.flowLayoutPanelColumnA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flowLayoutPanelColumnA.Location = new System.Drawing.Point(19, 93);
            this.flowLayoutPanelColumnA.Name = "flowLayoutPanelColumnA";
            this.flowLayoutPanelColumnA.Size = new System.Drawing.Size(184, 317);
            this.flowLayoutPanelColumnA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Layar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelColumnB
            // 
            this.flowLayoutPanelColumnB.Location = new System.Drawing.Point(219, 93);
            this.flowLayoutPanelColumnB.Name = "flowLayoutPanelColumnB";
            this.flowLayoutPanelColumnB.Size = new System.Drawing.Size(184, 317);
            this.flowLayoutPanelColumnB.TabIndex = 13;
            // 
            // flowLayoutPanelColumnC
            // 
            this.flowLayoutPanelColumnC.Location = new System.Drawing.Point(419, 93);
            this.flowLayoutPanelColumnC.Name = "flowLayoutPanelColumnC";
            this.flowLayoutPanelColumnC.Size = new System.Drawing.Size(184, 317);
            this.flowLayoutPanelColumnC.TabIndex = 13;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(646, 12);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(400, 715);
            this.pictureBoxPoster.TabIndex = 2;
            this.pictureBoxPoster.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Controls.Add(this.lblJumlahDiskon);
            this.panel5.Controls.Add(this.lblTotalHarga);
            this.panel5.Controls.Add(this.lblKursiTerpilih);
            this.panel5.Controls.Add(this.lblSaldo);
            this.panel5.Controls.Add(this.lblTotalAkhir);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(1052, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 315);
            this.panel5.TabIndex = 4;
            // 
            // lblJumlahDiskon
            // 
            this.lblJumlahDiskon.AutoSize = true;
            this.lblJumlahDiskon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblJumlahDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahDiskon.ForeColor = System.Drawing.Color.Black;
            this.lblJumlahDiskon.Location = new System.Drawing.Point(253, 138);
            this.lblJumlahDiskon.Name = "lblJumlahDiskon";
            this.lblJumlahDiskon.Size = new System.Drawing.Size(19, 20);
            this.lblJumlahDiskon.TabIndex = 110;
            this.lblJumlahDiskon.Text = "0";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHarga.ForeColor = System.Drawing.Color.Black;
            this.lblTotalHarga.Location = new System.Drawing.Point(253, 103);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(19, 20);
            this.lblTotalHarga.TabIndex = 109;
            this.lblTotalHarga.Text = "0";
            // 
            // lblKursiTerpilih
            // 
            this.lblKursiTerpilih.AutoEllipsis = true;
            this.lblKursiTerpilih.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKursiTerpilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKursiTerpilih.ForeColor = System.Drawing.Color.Black;
            this.lblKursiTerpilih.Location = new System.Drawing.Point(208, 73);
            this.lblKursiTerpilih.Name = "lblKursiTerpilih";
            this.lblKursiTerpilih.Size = new System.Drawing.Size(253, 20);
            this.lblKursiTerpilih.TabIndex = 108;
            this.lblKursiTerpilih.Text = "Kursi ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaldo.Location = new System.Drawing.Point(253, 205);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(60, 20);
            this.lblSaldo.TabIndex = 107;
            this.lblSaldo.Text = "Saldo ";
            // 
            // lblTotalAkhir
            // 
            this.lblTotalAkhir.AutoSize = true;
            this.lblTotalAkhir.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAkhir.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAkhir.Location = new System.Drawing.Point(253, 169);
            this.lblTotalAkhir.Name = "lblTotalAkhir";
            this.lblTotalAkhir.Size = new System.Drawing.Size(19, 20);
            this.lblTotalAkhir.TabIndex = 106;
            this.lblTotalAkhir.Text = "0";
            // 
            // label19
            // 
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.ForestGreen;
            this.label19.Location = new System.Drawing.Point(137, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 20);
            this.label19.TabIndex = 105;
            this.label19.Text = "Saldo :   Rp.";
            // 
            // label18
            // 
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(97, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 20);
            this.label18.TabIndex = 104;
            this.label18.Text = "Total Akhir :   Rp.";
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(128, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "Diskon :   Rp.";
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(143, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 102;
            this.label11.Text = "Total :   Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(143, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Kursi :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.lblKelompok);
            this.panel4.Controls.Add(this.lblGenre);
            this.panel4.Controls.Add(this.lblAktorUtama);
            this.panel4.Controls.Add(this.lblDurasiFilm);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblSinopsis);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(1052, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 320);
            this.panel4.TabIndex = 38;
            // 
            // lblKelompok
            // 
            this.lblKelompok.AutoSize = true;
            this.lblKelompok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelompok.Location = new System.Drawing.Point(118, 277);
            this.lblKelompok.Name = "lblKelompok";
            this.lblKelompok.Size = new System.Drawing.Size(84, 18);
            this.lblKelompok.TabIndex = 29;
            this.lblKelompok.Text = "Kelompok";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(88, 245);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 18);
            this.lblGenre.TabIndex = 28;
            this.lblGenre.Text = "Genre";
            // 
            // lblAktorUtama
            // 
            this.lblAktorUtama.AutoEllipsis = true;
            this.lblAktorUtama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktorUtama.Location = new System.Drawing.Point(136, 216);
            this.lblAktorUtama.Name = "lblAktorUtama";
            this.lblAktorUtama.Size = new System.Drawing.Size(268, 18);
            this.lblAktorUtama.TabIndex = 27;
            this.lblAktorUtama.Text = "Aktor\r\n";
            // 
            // lblDurasiFilm
            // 
            this.lblDurasiFilm.AutoSize = true;
            this.lblDurasiFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurasiFilm.Location = new System.Drawing.Point(91, 190);
            this.lblDurasiFilm.Name = "lblDurasiFilm";
            this.lblDurasiFilm.Size = new System.Drawing.Size(57, 18);
            this.lblDurasiFilm.TabIndex = 26;
            this.lblDurasiFilm.Text = "Durasi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 18);
            this.label17.TabIndex = 25;
            this.label17.Text = "Kelompok :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 24;
            this.label16.Text = "Genre :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 18);
            this.label15.TabIndex = 23;
            this.label15.Text = "Aktor Utama :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Durasi :";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(18, 49);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(443, 121);
            this.lblSinopsis.TabIndex = 21;
            this.lblSinopsis.Text = resources.GetString("lblSinopsis.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Sinopsis";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(1420, 677);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(107, 31);
            this.buttonKeluar.TabIndex = 39;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKonfirmasi
            // 
            this.buttonKonfirmasi.AutoSize = true;
            this.buttonKonfirmasi.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKonfirmasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKonfirmasi.FlatAppearance.BorderSize = 0;
            this.buttonKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonfirmasi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonfirmasi.ForeColor = System.Drawing.Color.White;
            this.buttonKonfirmasi.Location = new System.Drawing.Point(1143, 677);
            this.buttonKonfirmasi.Name = "buttonKonfirmasi";
            this.buttonKonfirmasi.Size = new System.Drawing.Size(257, 31);
            this.buttonKonfirmasi.TabIndex = 40;
            this.buttonKonfirmasi.Text = "KONFIRMASI PEMBAYARAN";
            this.buttonKonfirmasi.UseVisualStyleBackColor = false;
            this.buttonKonfirmasi.Click += new System.EventHandler(this.buttonKonfirmasi_Click);
            // 
            // comboBoxJamPemutaran
            // 
            this.comboBoxJamPemutaran.FormattingEnabled = true;
            this.comboBoxJamPemutaran.Location = new System.Drawing.Point(330, 107);
            this.comboBoxJamPemutaran.Name = "comboBoxJamPemutaran";
            this.comboBoxJamPemutaran.Size = new System.Drawing.Size(73, 21);
            this.comboBoxJamPemutaran.TabIndex = 104;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(185, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 20);
            this.label20.TabIndex = 103;
            this.label20.Text = "Jam Pemutaran : ";
            // 
            // FormPemesananTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1542, 739);
            this.Controls.Add(this.buttonKonfirmasi);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormPemesananTiket";
            this.Text = "FormPemesananTiket";
            this.Load += new System.EventHandler(this.FormPemesananTiket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStudio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.ComboBox comboBoxJudul;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalPesan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSisaKursi;
        private System.Windows.Forms.Label lblTotalKursi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblKelompok;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAktorUtama;
        private System.Windows.Forms.Label lblDurasiFilm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblJumlahDiskon;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblKursiTerpilih;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalAkhir;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKonfirmasi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumnA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumnB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumnC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxJamPemutaran;
        private System.Windows.Forms.Label label20;
    }
}