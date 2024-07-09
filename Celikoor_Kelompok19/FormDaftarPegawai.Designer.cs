namespace Celikoor_Kelompok19
{
    partial class FormDaftarPegawai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNilaiKriteria = new System.Windows.Forms.TextBox();
            this.cmbKriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeluarDaftarPegawai = new System.Windows.Forms.Button();
            this.btnTambahPegawai = new System.Windows.Forms.Button();
            this.dataGridViewDaftarPegawai = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.txtNilaiKriteria);
            this.panel1.Controls.Add(this.cmbKriteria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 38);
            this.panel1.TabIndex = 28;
            // 
            // txtNilaiKriteria
            // 
            this.txtNilaiKriteria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiKriteria.Location = new System.Drawing.Point(298, 10);
            this.txtNilaiKriteria.Name = "txtNilaiKriteria";
            this.txtNilaiKriteria.Size = new System.Drawing.Size(322, 22);
            this.txtNilaiKriteria.TabIndex = 2;
            this.txtNilaiKriteria.TextChanged += new System.EventHandler(this.txtNilaiKriteria_TextChanged);
            // 
            // cmbKriteria
            // 
            this.cmbKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKriteria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKriteria.FormattingEnabled = true;
            this.cmbKriteria.Location = new System.Drawing.Point(158, 8);
            this.cmbKriteria.Name = "cmbKriteria";
            this.cmbKriteria.Size = new System.Drawing.Size(121, 24);
            this.cmbKriteria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 47);
            this.label1.TabIndex = 24;
            this.label1.Text = "Daftar Pegawai";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarPegawai
            // 
            this.btnKeluarDaftarPegawai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarPegawai.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarPegawai.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarPegawai.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarPegawai.Location = new System.Drawing.Point(544, 383);
            this.btnKeluarDaftarPegawai.Name = "btnKeluarDaftarPegawai";
            this.btnKeluarDaftarPegawai.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarPegawai.TabIndex = 27;
            this.btnKeluarDaftarPegawai.Text = "KELUAR";
            this.btnKeluarDaftarPegawai.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarPegawai.Click += new System.EventHandler(this.btnKeluarDaftarPegawai_Click);
            // 
            // btnTambahPegawai
            // 
            this.btnTambahPegawai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahPegawai.FlatAppearance.BorderSize = 0;
            this.btnTambahPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahPegawai.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPegawai.ForeColor = System.Drawing.Color.White;
            this.btnTambahPegawai.Location = new System.Drawing.Point(12, 383);
            this.btnTambahPegawai.Name = "btnTambahPegawai";
            this.btnTambahPegawai.Size = new System.Drawing.Size(107, 31);
            this.btnTambahPegawai.TabIndex = 26;
            this.btnTambahPegawai.Text = "TAMBAH";
            this.btnTambahPegawai.UseVisualStyleBackColor = false;
            this.btnTambahPegawai.Click += new System.EventHandler(this.btnTambahPegawai_Click);
            // 
            // dataGridViewDaftarPegawai
            // 
            this.dataGridViewDaftarPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPegawai.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewDaftarPegawai.Name = "dataGridViewDaftarPegawai";
            this.dataGridViewDaftarPegawai.Size = new System.Drawing.Size(639, 240);
            this.dataGridViewDaftarPegawai.TabIndex = 25;
            this.dataGridViewDaftarPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarPegawai_CellContentClick);
            // 
            // FormDaftarPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarPegawai);
            this.Controls.Add(this.btnTambahPegawai);
            this.Controls.Add(this.dataGridViewDaftarPegawai);
            this.Name = "FormDaftarPegawai";
            this.Text = "FormDaftarPegawai";
            this.Load += new System.EventHandler(this.FormDaftarPegawai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPegawai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarPegawai;
        private System.Windows.Forms.Button btnTambahPegawai;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPegawai;
    }
}