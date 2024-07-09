using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Kelompok19
{
    public partial class FormLaporan : Form
    {
        public List<Laporan> listLaporan = new List<Laporan>();
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            FormatDataGridLaporan1();

            TampilDataGrid();
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if(xlApp == null)
            {
                MessageBox.Show("Excel Application not found");
                return;
            }

            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();

            xlWorkbook.Worksheets.Add();
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Worksheets[1];

            xlWorksheet.Cells[1, 1] = "Hello Excel";
            xlWorksheet.Cells[1, 2] = "From Visual Studio 2022";
            xlWorksheet.Cells[1, 3] = "With COM Reference";

            xlWorksheet.Cells.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Range rng = xlWorksheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
            rng.EntireRow.Font.Bold = true;

            xlApp.DisplayAlerts = false;
            xlWorkbook.SaveAs("test.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
            xlWorkbook.Close();

            MessageBox.Show("Data Berhasil diexport ke excel");

            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void FormatDataGridLaporan1()
        {
            dataGridViewLaporan.Columns.Clear();

            dataGridViewLaporan.Columns.Add("Tahun", "Tahun");
            dataGridViewLaporan.Columns.Add("Bulan", "Bulan");
            dataGridViewLaporan.Columns.Add("Judul", "Judul");
            dataGridViewLaporan.Columns.Add("Total", "Total");

            dataGridViewLaporan.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLaporan.AllowUserToAddRows = false;
            dataGridViewLaporan.ReadOnly = true;
        }

        private void FormatDataGridLaporan2()
        {
            dataGridViewLaporan.Columns.Clear();

            dataGridViewLaporan.Columns.Add("Nama Cabang", "Nama Cabang");
            dataGridViewLaporan.Columns.Add("Jenis Studio", "Jenis Studio");
            dataGridViewLaporan.Columns.Add("Total", "Total");

            dataGridViewLaporan.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLaporan.AllowUserToAddRows = false;
            dataGridViewLaporan.ReadOnly = true;
        }

        private void FormatDataGridLaporan3()
        {
            dataGridViewLaporan.Columns.Clear();

            dataGridViewLaporan.Columns.Add("Judul", "Judul");
            dataGridViewLaporan.Columns.Add("Jumlah Tidak Hadir", "Jumlah Tidak Hadir");

            dataGridViewLaporan.Columns["Jumlah Tidak Hadir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLaporan.AllowUserToAddRows = false;
            dataGridViewLaporan.ReadOnly = true;
        }

        private void FormatDataGridLaporan5()
        {
            dataGridViewLaporan.Columns.Clear();

            dataGridViewLaporan.Columns.Add("Nama Konsumen", "Nama Konsumen");
            dataGridViewLaporan.Columns.Add("Paling Banyak Menonton", "Paling Banyak Menonton");

            dataGridViewLaporan.Columns["Paling Banyak Menonton"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLaporan.AllowUserToAddRows = false;
            dataGridViewLaporan.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewLaporan.Rows.Clear();

            listLaporan = Laporan.Laporan1();
            if (listLaporan.Count > 0)
            {
                foreach (Laporan l in listLaporan)
                {
                    dataGridViewLaporan.Rows.Add(l.Tahun, l.Bulan, l.Judul, l.Total);
                }
            }
            else
            {
                dataGridViewLaporan.DataSource = null;
            }
        }

        private void comboBoxLaporan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatDataGridLaporan1();
            if (comboBoxLaporan.SelectedIndex == 0)
            {
                dataGridViewLaporan.Rows.Clear();

                listLaporan = Laporan.Laporan1();
                if (listLaporan.Count > 0)
                {
                    foreach (Laporan l in listLaporan)
                    {
                        dataGridViewLaporan.Rows.Add(l.Tahun, l.Bulan, l.Judul, l.Total);
                    }
                }
            }
            else if (comboBoxLaporan.SelectedIndex == 1)
            {
                FormatDataGridLaporan2();
                dataGridViewLaporan.Rows.Clear();

                listLaporan = Laporan.Laporan2();
                if (listLaporan.Count > 0)
                {
                    foreach (Laporan l in listLaporan)
                    {
                        dataGridViewLaporan.Rows.Add(l.Nama, l.JenisStudio, l.Total);
                    }
                }
            }
            else if (comboBoxLaporan.SelectedIndex == 2)
            {
                FormatDataGridLaporan3();
                dataGridViewLaporan.Rows.Clear();

                listLaporan = Laporan.Laporan3();
                if (listLaporan.Count > 0)
                {
                    foreach (Laporan l in listLaporan)
                    {
                        dataGridViewLaporan.Rows.Add(l.Judul, l.Total);
                    }
                }
            }
            else if (comboBoxLaporan.SelectedIndex == 4)
            {
                FormatDataGridLaporan5();
                dataGridViewLaporan.Rows.Clear();

                listLaporan = Laporan.Laporan5();
                if (listLaporan.Count > 0)
                {
                    foreach (Laporan l in listLaporan)
                    {
                        dataGridViewLaporan.Rows.Add(l.Nama, l.Total);
                    }
                }
            }
        }
    }
}
