namespace Celikoor_Kelompok19
{
    partial class FormDaftarCinema
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeluarDaftarCinema = new System.Windows.Forms.Button();
            this.btnTambahCinema = new System.Windows.Forms.Button();
            this.dataGridViewDaftarCinema = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNilaiKriteria = new System.Windows.Forms.TextBox();
            this.cmbKriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarCinema)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Daftar Cinema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarCinema
            // 
            this.btnKeluarDaftarCinema.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarCinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarCinema.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarCinema.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarCinema.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarCinema.Location = new System.Drawing.Point(544, 381);
            this.btnKeluarDaftarCinema.Name = "btnKeluarDaftarCinema";
            this.btnKeluarDaftarCinema.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarCinema.TabIndex = 22;
            this.btnKeluarDaftarCinema.Text = "KELUAR";
            this.btnKeluarDaftarCinema.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarCinema.Click += new System.EventHandler(this.btnKeluarDaftarCinema_Click);
            // 
            // btnTambahCinema
            // 
            this.btnTambahCinema.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahCinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahCinema.FlatAppearance.BorderSize = 0;
            this.btnTambahCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahCinema.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahCinema.ForeColor = System.Drawing.Color.White;
            this.btnTambahCinema.Location = new System.Drawing.Point(12, 381);
            this.btnTambahCinema.Name = "btnTambahCinema";
            this.btnTambahCinema.Size = new System.Drawing.Size(107, 31);
            this.btnTambahCinema.TabIndex = 21;
            this.btnTambahCinema.Text = "TAMBAH";
            this.btnTambahCinema.UseVisualStyleBackColor = false;
            this.btnTambahCinema.Click += new System.EventHandler(this.btnTambahCinema_Click);
            // 
            // dataGridViewDaftarCinema
            // 
            this.dataGridViewDaftarCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarCinema.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarCinema.Name = "dataGridViewDaftarCinema";
            this.dataGridViewDaftarCinema.Size = new System.Drawing.Size(639, 240);
            this.dataGridViewDaftarCinema.TabIndex = 20;
            this.dataGridViewDaftarCinema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarCinema_CellContentClick);
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
            this.panel1.TabIndex = 23;
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
            // FormDaftarCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(667, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarCinema);
            this.Controls.Add(this.btnTambahCinema);
            this.Controls.Add(this.dataGridViewDaftarCinema);
            this.Name = "FormDaftarCinema";
            this.Text = "FormDaftarCinema";
            this.Load += new System.EventHandler(this.FormDaftarCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarCinema)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarCinema;
        private System.Windows.Forms.Button btnTambahCinema;
        private System.Windows.Forms.DataGridView dataGridViewDaftarCinema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
    }
}