using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Kelompok19
{
    public partial class FormDaftarInvoice : Form
    {
        public Pegawai kasir;
        public List<Invoice> listInvoice = new List<Invoice>();
        public FormDaftarInvoice()
        {
            InitializeComponent();
        }

        public void FormDaftarInvoice_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listInvoice = Invoice.BacaData("", "");

            TampilDataGrid();
            if (listInvoice.Count > 0)
            {
                if (dataGridViewDaftarInvoice.ColumnCount == 7)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Ubah";
                    bCol.Name = "btnUbahGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarInvoice.Columns.Add(bCol);

                    DataGridViewButtonColumn bCol2 = new DataGridViewButtonColumn();
                    bCol2.HeaderText = "Aksi";
                    bCol2.Text = "Hapus";
                    bCol2.Name = "btnHapusGrid";
                    bCol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarInvoice.Columns.Add(bCol2);
                }
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listInvoice = Invoice.BacaData("i.id", txtNilaiKriteria.Text);
                    break;
                case "Tanggal":
                    listInvoice = Invoice.BacaData("i.tanggal", txtNilaiKriteria.Text);
                    break;
                case "Grand Total":
                    listInvoice = Invoice.BacaData("i.grand_total", txtNilaiKriteria.Text);
                    break;
                case "Diskon":
                    listInvoice = Invoice.BacaData("i.diskon_nominal", txtNilaiKriteria.Text);
                    break;
                case "Status":
                    listInvoice = Invoice.BacaData("i.status", txtNilaiKriteria.Text);
                    break;
                case "Nama Konsumen":
                    listInvoice = Invoice.BacaData("k.nama", txtNilaiKriteria.Text);
                    break;
                case "Nama Kasir":
                    listInvoice = Invoice.BacaData("p.nama", txtNilaiKriteria.Text);
                    break;
            }

            if (listInvoice.Count > 0)
            {
                dataGridViewDaftarInvoice.DataSource = listInvoice;
            }
            else
            {
                dataGridViewDaftarInvoice.DataSource = null;
            }
        }

        private void dataGridViewDaftarInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarInvoice.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarInvoice.CurrentRow.Cells["ID"].Value.ToString();

                Invoice i = Invoice.AmbilDataByID(pID);
                if (i != null)
                {
                    FormUpdateInvoice frm = new FormUpdateInvoice();
                    frm.Owner = this;

                    frm.textBoxID.Text = i.Id.ToString();
                    frm.dateTimePickerTgl.Value = i.Tanggal;
                    frm.textBoxGrandTotal.Text = i.GrandTotal.ToString();
                    frm.textBoxDiskonNominal.Text = (i.DiskonNominal * 100).ToString();
                    frm.comboBoxStatus.Text = i.Status.ToString();
                    frm.konsumen = i.Konsumen;
                    frm.kasir = kasir;

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarInvoice.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarInvoice.CurrentRow.Cells["Id"].Value.ToString();
                DateTime tanggalHapus = DateTime.Parse(dataGridViewDaftarInvoice.CurrentRow.Cells["Tanggal"].Value.ToString());

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + tanggalHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Invoice k = new Invoice(idHapus, tanggalHapus);
                    Boolean hapus = Invoice.HapusData(k);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarInvoice_Load(btnKeluarDaftarInvoice, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnTambahInvoice_Click(object sender, EventArgs e)
        {
            FormTambahInvoice frm = new FormTambahInvoice();
            frm.Owner = this;
            frm.Show();
        }

        private void btnKeluarDaftarInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Tanggal");
            cmbKriteria.Items.Add("Grand Total");
            cmbKriteria.Items.Add("Diskon");
            cmbKriteria.Items.Add("Status");
            cmbKriteria.Items.Add("Nama Konsumen");
            cmbKriteria.Items.Add("Nama Kasir");
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarInvoice.Columns.Clear();

            dataGridViewDaftarInvoice.Columns.Add("Id", "ID");
            dataGridViewDaftarInvoice.Columns.Add("Tanggal", "Judul");
            dataGridViewDaftarInvoice.Columns.Add("GrandTotal", "Grand Total");
            dataGridViewDaftarInvoice.Columns.Add("DiskonNominal", "Diskon Nominal");
            dataGridViewDaftarInvoice.Columns.Add("Konsumen", "Konsumen");
            dataGridViewDaftarInvoice.Columns.Add("Kasir", "Kasir");
            dataGridViewDaftarInvoice.Columns.Add("Status", "Status");

            dataGridViewDaftarInvoice.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["GrandTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["DiskonNominal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["Konsumen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["Kasir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarInvoice.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarInvoice.Columns["DiskonNominal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDaftarInvoice.AllowUserToAddRows = false;
            dataGridViewDaftarInvoice.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarInvoice.Rows.Clear();

            if (listInvoice.Count > 0)
            {
                foreach (Invoice i in listInvoice)
                {
                    dataGridViewDaftarInvoice.Rows.Add(i.Id, i.Tanggal, i.GrandTotal, i.DiskonNominal, i.Konsumen.Nama, i.Kasir.Nama, i.Status);
                }
            }
            else
            {
                dataGridViewDaftarInvoice.DataSource = null;
            }
        }
    }
}
