﻿namespace Celikoor_Kelompok19
{
    partial class FormDaftarInvoice
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
            this.btnKeluarDaftarInvoice = new System.Windows.Forms.Button();
            this.btnTambahInvoice = new System.Windows.Forms.Button();
            this.dataGridViewDaftarInvoice = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarInvoice)).BeginInit();
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
            this.panel1.TabIndex = 38;
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
            this.label1.TabIndex = 34;
            this.label1.Text = "Daftar Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKeluarDaftarInvoice
            // 
            this.btnKeluarDaftarInvoice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluarDaftarInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluarDaftarInvoice.FlatAppearance.BorderSize = 0;
            this.btnKeluarDaftarInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarDaftarInvoice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluarDaftarInvoice.ForeColor = System.Drawing.Color.White;
            this.btnKeluarDaftarInvoice.Location = new System.Drawing.Point(682, 438);
            this.btnKeluarDaftarInvoice.Name = "btnKeluarDaftarInvoice";
            this.btnKeluarDaftarInvoice.Size = new System.Drawing.Size(107, 31);
            this.btnKeluarDaftarInvoice.TabIndex = 37;
            this.btnKeluarDaftarInvoice.Text = "KELUAR";
            this.btnKeluarDaftarInvoice.UseVisualStyleBackColor = false;
            this.btnKeluarDaftarInvoice.Click += new System.EventHandler(this.btnKeluarDaftarInvoice_Click);
            // 
            // btnTambahInvoice
            // 
            this.btnTambahInvoice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahInvoice.FlatAppearance.BorderSize = 0;
            this.btnTambahInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahInvoice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahInvoice.ForeColor = System.Drawing.Color.White;
            this.btnTambahInvoice.Location = new System.Drawing.Point(12, 438);
            this.btnTambahInvoice.Name = "btnTambahInvoice";
            this.btnTambahInvoice.Size = new System.Drawing.Size(107, 31);
            this.btnTambahInvoice.TabIndex = 36;
            this.btnTambahInvoice.Text = "TAMBAH";
            this.btnTambahInvoice.UseVisualStyleBackColor = false;
            this.btnTambahInvoice.Visible = false;
            this.btnTambahInvoice.Click += new System.EventHandler(this.btnTambahInvoice_Click);
            // 
            // dataGridViewDaftarInvoice
            // 
            this.dataGridViewDaftarInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarInvoice.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDaftarInvoice.Name = "dataGridViewDaftarInvoice";
            this.dataGridViewDaftarInvoice.Size = new System.Drawing.Size(777, 295);
            this.dataGridViewDaftarInvoice.TabIndex = 35;
            this.dataGridViewDaftarInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarInvoice_CellContentClick);
            // 
            // FormDaftarInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluarDaftarInvoice);
            this.Controls.Add(this.btnTambahInvoice);
            this.Controls.Add(this.dataGridViewDaftarInvoice);
            this.Name = "FormDaftarInvoice";
            this.Text = "FormDaftarInvoice";
            this.Load += new System.EventHandler(this.FormDaftarInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNilaiKriteria;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluarDaftarInvoice;
        private System.Windows.Forms.Button btnTambahInvoice;
        private System.Windows.Forms.DataGridView dataGridViewDaftarInvoice;
    }
}