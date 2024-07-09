namespace Celikoor_Kelompok19
{
    partial class FormLaporan
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
            this.comboBoxLaporan = new System.Windows.Forms.ComboBox();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewLaporan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLaporan
            // 
            this.comboBoxLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLaporan.FormattingEnabled = true;
            this.comboBoxLaporan.Items.AddRange(new object[] {
            "Jumlah film terlaris per bulannya selama tahun 2023.",
            "Peringkat 3 cabang terbanyak yang mendapatkan pemasukkan dari penjualan tiket.",
            "3 teratas film yang paling banyak jumlah ketidakhadiran penontonnya.",
            "3 studio beserta nama cinemanya, yang memiliki tingkat utilitas terendah pada bul" +
                "an tertentu.",
            "10 konsumen teratas yang paling sering menonton film bergenre comedy. "});
            this.comboBoxLaporan.Location = new System.Drawing.Point(107, 12);
            this.comboBoxLaporan.Name = "comboBoxLaporan";
            this.comboBoxLaporan.Size = new System.Drawing.Size(641, 24);
            this.comboBoxLaporan.TabIndex = 69;
            this.comboBoxLaporan.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaporan_SelectedIndexChanged);
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportToExcel.FlatAppearance.BorderSize = 0;
            this.buttonExportToExcel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportToExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExportToExcel.Location = new System.Drawing.Point(581, 287);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(168, 31);
            this.buttonExportToExcel.TabIndex = 68;
            this.buttonExportToExcel.Text = "Export to Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = false;
            this.buttonExportToExcel.Click += new System.EventHandler(this.buttonExportToExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Laporan : ";
            // 
            // dataGridViewLaporan
            // 
            this.dataGridViewLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLaporan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaporan.Location = new System.Drawing.Point(16, 52);
            this.dataGridViewLaporan.Name = "dataGridViewLaporan";
            this.dataGridViewLaporan.Size = new System.Drawing.Size(733, 227);
            this.dataGridViewLaporan.TabIndex = 71;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 330);
            this.Controls.Add(this.dataGridViewLaporan);
            this.Controls.Add(this.comboBoxLaporan);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.label3);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLaporan;
        private System.Windows.Forms.Button buttonExportToExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewLaporan;
    }
}