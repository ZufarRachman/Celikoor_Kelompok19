namespace Celikoor_Kelompok19
{
    partial class FormDaftarKonsumen
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
            this.btnKeluarDaftarKonsumen = new System.Windows.Forms.Button();
            this.btnTambahKonsumen = new System.Windows.Forms.Button();
            this.dataGridViewDaftarKonsumen = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonsumen)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1047, 38);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 47);
            this.label1.TabIndex = 24;
            this.label1.Text = "Daftar Konsumen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarKonsumen
            // 
            this.btnKeluarDaftarKonsumen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarKonsumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarKonsumen.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarKonsumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarKonsumen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarKonsumen.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarKonsumen.Location = new System.Drawing.Point(952, 381);
            this.btnKeluarDaftarKonsumen.Name = "btnKeluarDaftarKonsumen";
            this.btnKeluarDaftarKonsumen.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarKonsumen.TabIndex = 27;
            this.btnKeluarDaftarKonsumen.Text = "KELUAR";
            this.btnKeluarDaftarKonsumen.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarKonsumen.Click += new System.EventHandler(this.btnKeluarDaftarKonsumen_Click);
            // 
            // btnTambahKonsumen
            // 
            this.btnTambahKonsumen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahKonsumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahKonsumen.FlatAppearance.BorderSize = 0;
            this.btnTambahKonsumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKonsumen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKonsumen.ForeColor = System.Drawing.Color.White;
            this.btnTambahKonsumen.Location = new System.Drawing.Point(12, 381);
            this.btnTambahKonsumen.Name = "btnTambahKonsumen";
            this.btnTambahKonsumen.Size = new System.Drawing.Size(107, 31);
            this.btnTambahKonsumen.TabIndex = 26;
            this.btnTambahKonsumen.Text = "TAMBAH";
            this.btnTambahKonsumen.UseVisualStyleBackColor = false;
            this.btnTambahKonsumen.Click += new System.EventHandler(this.btnTambahKonsumen_Click);
            // 
            // dataGridViewDaftarKonsumen
            // 
            this.dataGridViewDaftarKonsumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKonsumen.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarKonsumen.Name = "dataGridViewDaftarKonsumen";
            this.dataGridViewDaftarKonsumen.Size = new System.Drawing.Size(1047, 240);
            this.dataGridViewDaftarKonsumen.TabIndex = 25;
            this.dataGridViewDaftarKonsumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarKonsumen_CellContentClick);
            // 
            // FormDaftarKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1071, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarKonsumen);
            this.Controls.Add(this.btnTambahKonsumen);
            this.Controls.Add(this.dataGridViewDaftarKonsumen);
            this.Name = "FormDaftarKonsumen";
            this.Text = "FormDaftarKonsumen";
            this.Load += new System.EventHandler(this.FormDaftarKonsumen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonsumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarKonsumen;
        private System.Windows.Forms.Button btnTambahKonsumen;
        private System.Windows.Forms.DataGridView dataGridViewDaftarKonsumen;
    }
}