namespace Celikoor_Kelompok19
{
    partial class FormDaftarTiket
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
            this.btnKeluarDaftarTiket = new System.Windows.Forms.Button();
            this.dataGridViewDaftarTiket = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTiket)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(777, 38);
            this.panel1.TabIndex = 42;
            // 
            // txtNilaiKriteria
            // 
            this.txtNilaiKriteria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiKriteria.Location = new System.Drawing.Point(298, 10);
            this.txtNilaiKriteria.Name = "txtNilaiKriteria";
            this.txtNilaiKriteria.Size = new System.Drawing.Size(418, 22);
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
            this.label1.Size = new System.Drawing.Size(777, 47);
            this.label1.TabIndex = 39;
            this.label1.Text = "Daftar Tiket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarTiket
            // 
            this.btnKeluarDaftarTiket.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarTiket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarTiket.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarTiket.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarTiket.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarTiket.Location = new System.Drawing.Point(682, 438);
            this.btnKeluarDaftarTiket.Name = "btnKeluarDaftarTiket";
            this.btnKeluarDaftarTiket.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarTiket.TabIndex = 41;
            this.btnKeluarDaftarTiket.Text = "KELUAR";
            this.btnKeluarDaftarTiket.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarTiket.Click += new System.EventHandler(this.btnKeluarDaftarTiket_Click);
            // 
            // dataGridViewDaftarTiket
            // 
            this.dataGridViewDaftarTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTiket.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarTiket.Name = "dataGridViewDaftarTiket";
            this.dataGridViewDaftarTiket.Size = new System.Drawing.Size(777, 295);
            this.dataGridViewDaftarTiket.TabIndex = 40;
            this.dataGridViewDaftarTiket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTiket_CellContentClick);
            // 
            // FormDaftarTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarTiket);
            this.Controls.Add(this.dataGridViewDaftarTiket);
            this.Name = "FormDaftarTiket";
            this.Text = "FormDaftarTiket";
            this.Load += new System.EventHandler(this.FormDaftarTiket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTiket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarTiket;
        private System.Windows.Forms.DataGridView dataGridViewDaftarTiket;
    }
}