namespace Celikoor_Kelompok19
{
    partial class FormDaftarJenisStudio
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
            this.btnKeluarDaftarJenisStudio = new System.Windows.Forms.Button();
            this.btnTambahJenisStudio = new System.Windows.Forms.Button();
            this.dataGridViewDaftarJenisStudio = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJenisStudio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.txtNilaiKriteria);
            this.panel1.Controls.Add(this.cmbKriteria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 38);
            this.panel1.TabIndex = 33;
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 47);
            this.label1.TabIndex = 29;
            this.label1.Text = "Daftar Jenis Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarJenisStudio
            // 
            this.btnKeluarDaftarJenisStudio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarJenisStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarJenisStudio.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarJenisStudio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarJenisStudio.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarJenisStudio.Location = new System.Drawing.Point(544, 381);
            this.btnKeluarDaftarJenisStudio.Name = "btnKeluarDaftarJenisStudio";
            this.btnKeluarDaftarJenisStudio.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarJenisStudio.TabIndex = 32;
            this.btnKeluarDaftarJenisStudio.Text = "KELUAR";
            this.btnKeluarDaftarJenisStudio.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarJenisStudio.Click += new System.EventHandler(this.btnKeluarDaftarJenisStudio_Click);
            // 
            // btnTambahJenisStudio
            // 
            this.btnTambahJenisStudio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahJenisStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahJenisStudio.FlatAppearance.BorderSize = 0;
            this.btnTambahJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahJenisStudio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahJenisStudio.ForeColor = System.Drawing.Color.White;
            this.btnTambahJenisStudio.Location = new System.Drawing.Point(12, 381);
            this.btnTambahJenisStudio.Name = "btnTambahJenisStudio";
            this.btnTambahJenisStudio.Size = new System.Drawing.Size(107, 31);
            this.btnTambahJenisStudio.TabIndex = 31;
            this.btnTambahJenisStudio.Text = "TAMBAH";
            this.btnTambahJenisStudio.UseVisualStyleBackColor = false;
            this.btnTambahJenisStudio.Click += new System.EventHandler(this.btnTambahJenisStudio_Click);
            // 
            // dataGridViewDaftarJenisStudio
            // 
            this.dataGridViewDaftarJenisStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarJenisStudio.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarJenisStudio.Name = "dataGridViewDaftarJenisStudio";
            this.dataGridViewDaftarJenisStudio.Size = new System.Drawing.Size(639, 240);
            this.dataGridViewDaftarJenisStudio.TabIndex = 30;
            this.dataGridViewDaftarJenisStudio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarJenisStudio_CellContentClick);
            // 
            // FormDaftarJenisStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarJenisStudio);
            this.Controls.Add(this.btnTambahJenisStudio);
            this.Controls.Add(this.dataGridViewDaftarJenisStudio);
            this.Name = "FormDaftarJenisStudio";
            this.Text = "FormDaftarJenisStudio";
            this.Load += new System.EventHandler(this.FormDaftarJenisStudio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJenisStudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarJenisStudio;
        private System.Windows.Forms.Button btnTambahJenisStudio;
        private System.Windows.Forms.DataGridView dataGridViewDaftarJenisStudio;
    }
}