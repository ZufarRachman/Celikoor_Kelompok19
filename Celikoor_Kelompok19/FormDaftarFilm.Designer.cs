namespace Celikoor_Kelompok19
{
    partial class FormDaftarFilm
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
            this.btnKeluarDaftarFilm = new System.Windows.Forms.Button();
            this.btnTambahFilm = new System.Windows.Forms.Button();
            this.dataGridViewDaftarFilm = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarFilm)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(914, 38);
            this.panel1.TabIndex = 33;
            // 
            // txtNilaiKriteria
            // 
            this.txtNilaiKriteria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiKriteria.Location = new System.Drawing.Point(298, 10);
            this.txtNilaiKriteria.Name = "txtNilaiKriteria";
            this.txtNilaiKriteria.Size = new System.Drawing.Size(539, 22);
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
            this.label1.Size = new System.Drawing.Size(914, 47);
            this.label1.TabIndex = 29;
            this.label1.Text = "Daftar Film";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarFilm
            // 
            this.btnKeluarDaftarFilm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarFilm.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarFilm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarFilm.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarFilm.Location = new System.Drawing.Point(819, 438);
            this.btnKeluarDaftarFilm.Name = "btnKeluarDaftarFilm";
            this.btnKeluarDaftarFilm.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarFilm.TabIndex = 32;
            this.btnKeluarDaftarFilm.Text = "KELUAR";
            this.btnKeluarDaftarFilm.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarFilm.Click += new System.EventHandler(this.btnKeluarDaftarFilm_Click);
            // 
            // btnTambahFilm
            // 
            this.btnTambahFilm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahFilm.FlatAppearance.BorderSize = 0;
            this.btnTambahFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahFilm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahFilm.ForeColor = System.Drawing.Color.White;
            this.btnTambahFilm.Location = new System.Drawing.Point(12, 438);
            this.btnTambahFilm.Name = "btnTambahFilm";
            this.btnTambahFilm.Size = new System.Drawing.Size(107, 31);
            this.btnTambahFilm.TabIndex = 31;
            this.btnTambahFilm.Text = "TAMBAH";
            this.btnTambahFilm.UseVisualStyleBackColor = false;
            this.btnTambahFilm.Click += new System.EventHandler(this.btnTambahFilm_Click);
            // 
            // dataGridViewDaftarFilm
            // 
            this.dataGridViewDaftarFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarFilm.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarFilm.Name = "dataGridViewDaftarFilm";
            this.dataGridViewDaftarFilm.Size = new System.Drawing.Size(914, 295);
            this.dataGridViewDaftarFilm.TabIndex = 30;
            this.dataGridViewDaftarFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarFilm_CellContentClick);
            // 
            // FormDaftarFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarFilm);
            this.Controls.Add(this.btnTambahFilm);
            this.Controls.Add(this.dataGridViewDaftarFilm);
            this.Name = "FormDaftarFilm";
            this.Text = "FormDaftarFilm";
            this.Load += new System.EventHandler(this.FormDaftarFilm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarFilm;
        private System.Windows.Forms.Button btnTambahFilm;
        private System.Windows.Forms.DataGridView dataGridViewDaftarFilm;
    }
}