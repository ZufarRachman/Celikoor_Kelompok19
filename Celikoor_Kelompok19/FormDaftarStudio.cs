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
    
    public partial class FormDaftarStudio : Form
    {
        public List<Studio> listStudio = new List<Studio>();
        public FormDaftarStudio()
        {
            InitializeComponent();
        }

        public void FormDaftarStudio_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listStudio = Studio.BacaData("", "");

            TampilDataGrid();
            if (listStudio.Count > 0)
            {
                if (dataGridViewDaftarStudio.ColumnCount == 7)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Ubah";
                    bCol.Name = "btnUbahGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarStudio.Columns.Add(bCol);

                    DataGridViewButtonColumn bCol2 = new DataGridViewButtonColumn();
                    bCol2.HeaderText = "Aksi";
                    bCol2.Text = "Hapus";
                    bCol2.Name = "btnHapusGrid";
                    bCol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarStudio.Columns.Add(bCol2);
                }
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void dataGridViewDaftarStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarStudio.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarStudio.CurrentRow.Cells["ID"].Value.ToString();

                Studio s = Studio.AmbilDataByID("s.id", pID);
                if (s != null)
                {
                    FormUpdateStudio frm = new FormUpdateStudio();
                    frm.Owner = this;

                    frm.textBoxID.Text = s.Id.ToString();
                    frm.textBoxNama.Text = s.Nama.ToString();
                    frm.textBoxKapasitas.Text = s.Kapasitas.ToString();
                    frm.textBoxHargaWeekday.Text = s.Harga_weekday.ToString();
                    frm.textBoxHargaWeekend.Text = s.Harga_weekend.ToString();
                    frm.cinemaName = s.Cinema;
                    frm.jenisStudioName = s.JenisStudio;

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarStudio.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarStudio.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarStudio.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Studio k = new Studio(idHapus, namaHapus);
                    Boolean hapus = Studio.HapusData(k);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarStudio_Load(btnKeluarDaftarStudio, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listStudio = Studio.BacaData("s.id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listStudio = Studio.BacaData("s.nama", txtNilaiKriteria.Text);
                    break;
                case "Kapasitas":
                    listStudio = Studio.BacaData("s.Kapasitas", txtNilaiKriteria.Text);
                    break;
                case "Harga Weekday":
                    listStudio = Studio.BacaData("s.harga_weekday", txtNilaiKriteria.Text);
                    break;
                case "Harga Weekend":
                    listStudio = Studio.BacaData("s.harga_weekend", txtNilaiKriteria.Text);
                    break;
                case "Jenis Studio":
                    listStudio = Studio.BacaData("js.nama", txtNilaiKriteria.Text);
                    break;
                case "Cinema":
                    listStudio = Studio.BacaData("c.nama_cabang", txtNilaiKriteria.Text);
                    break;
            }

            TampilDataGrid();
        }

        private void btnKeluarDaftarStudio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambahStudio_Click(object sender, EventArgs e)
        {
            FormTambahStudio frm = new FormTambahStudio();
            frm.Owner = this;
            frm.Show();
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Kapasitas");
            cmbKriteria.Items.Add("Harga Weekday");
            cmbKriteria.Items.Add("Harga Weekend");
            cmbKriteria.Items.Add("Jenis Studio");
            cmbKriteria.Items.Add("Cinema");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarStudio.Columns.Clear();

            dataGridViewDaftarStudio.Columns.Add("Id", "ID");
            dataGridViewDaftarStudio.Columns.Add("Nama", "Nama");
            dataGridViewDaftarStudio.Columns.Add("Kapasitas", "Kapasitas");
            dataGridViewDaftarStudio.Columns.Add("JenisStudio", "Jenis Studio");
            dataGridViewDaftarStudio.Columns.Add("Cinema", "Cinema");
            dataGridViewDaftarStudio.Columns.Add("HargaWeekday", "Harga Weekday");
            dataGridViewDaftarStudio.Columns.Add("HargaWeekend", "Harga Weekend");

            dataGridViewDaftarStudio.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["Kapasitas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["HargaWeekday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["HargaWeekend"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["JenisStudio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["Cinema"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarStudio.Columns["HargaWeekday"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDaftarStudio.Columns["HargaWeekend"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDaftarStudio.Columns["HargaWeekday"].DefaultCellStyle.Format = "#,###";
            dataGridViewDaftarStudio.Columns["HargaWeekend"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarStudio.AllowUserToAddRows = false;
            dataGridViewDaftarStudio.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarStudio.Rows.Clear();

            if(listStudio.Count > 0)
            {
                foreach(Studio s in listStudio)
                {
                    dataGridViewDaftarStudio.Rows.Add(s.Id, s.Nama, s.Kapasitas, s.JenisStudio.Nama, s.Cinema.NamaCabang, s.Harga_weekday, s.Harga_weekend);
                }
            }
            else
            {
                dataGridViewDaftarStudio.DataSource = null;
            }
        }
    }
}
