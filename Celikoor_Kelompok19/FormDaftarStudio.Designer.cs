namespace Celikoor_Kelompok19
{
    partial class FormDaftarStudio
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
            this.dataGridViewDaftarStudio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeluarDaftarStudio = new System.Windows.Forms.Button();
            this.btnTambahStudio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarStudio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.txtNilaiKriteria);
            this.panel1.Controls.Add(this.cmbKriteria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 38);
            this.panel1.TabIndex = 33;
            // 
            // txtNilaiKriteria
            // 
            this.txtNilaiKriteria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiKriteria.Location = new System.Drawing.Point(298, 10);
            this.txtNilaiKriteria.Name = "txtNilaiKriteria";
            this.txtNilaiKriteria.Size = new System.Drawing.Size(505, 22);
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
            // dataGridViewDaftarStudio
            // 
            this.dataGridViewDaftarStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarStudio.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewDaftarStudio.Name = "dataGridViewDaftarStudio";
            this.dataGridViewDaftarStudio.Size = new System.Drawing.Size(819, 320);
            this.dataGridViewDaftarStudio.TabIndex = 30;
            this.dataGridViewDaftarStudio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarStudio_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 47);
            this.label1.TabIndex = 29;
            this.label1.Text = "Daftar Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarStudio
            // 
            this.btnKeluarDaftarStudio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarStudio.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarStudio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarStudio.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarStudio.Location = new System.Drawing.Point(724, 460);
            this.btnKeluarDaftarStudio.Name = "btnKeluarDaftarStudio";
            this.btnKeluarDaftarStudio.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarStudio.TabIndex = 32;
            this.btnKeluarDaftarStudio.Text = "KELUAR";
            this.btnKeluarDaftarStudio.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarStudio.Click += new System.EventHandler(this.btnKeluarDaftarStudio_Click);
            // 
            // btnTambahStudio
            // 
            this.btnTambahStudio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahStudio.FlatAppearance.BorderSize = 0;
            this.btnTambahStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahStudio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahStudio.ForeColor = System.Drawing.Color.White;
            this.btnTambahStudio.Location = new System.Drawing.Point(12, 460);
            this.btnTambahStudio.Name = "btnTambahStudio";
            this.btnTambahStudio.Size = new System.Drawing.Size(107, 31);
            this.btnTambahStudio.TabIndex = 31;
            this.btnTambahStudio.Text = "TAMBAH";
            this.btnTambahStudio.UseVisualStyleBackColor = false;
            this.btnTambahStudio.Click += new System.EventHandler(this.btnTambahStudio_Click);
            // 
            // FormDaftarStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDaftarStudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarStudio);
            this.Controls.Add(this.btnTambahStudio);
            this.Name = "FormDaftarStudio";
            this.Text = "FormDaftarStudio";
            this.Load += new System.EventHandler(this.FormDaftarStudio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarStudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarStudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarStudio;
        private System.Windows.Forms.Button btnTambahStudio;
    }
}