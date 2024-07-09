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
    public partial class FormDaftarFilm : Form
    {
        public List<Film> listFilm = new List<Film>();
        public FormDaftarFilm()
        {
            InitializeComponent();
        }

        public void FormDaftarFilm_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listFilm = Film.BacaData("", "");

            TampilDataGrid();
            if (listFilm.Count > 0)
            {
                if (dataGridViewDaftarFilm.ColumnCount == 10)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Ubah";
                    bCol.Name = "btnUbahGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarFilm.Columns.Add(bCol);

                    DataGridViewButtonColumn bCol2 = new DataGridViewButtonColumn();
                    bCol2.HeaderText = "Aksi";
                    bCol2.Text = "Hapus";
                    bCol2.Name = "btnHapusGrid";
                    bCol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarFilm.Columns.Add(bCol2);
                }
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void btnTambahFilm_Click(object sender, EventArgs e)
        {
            FormTambahFilm frm = new FormTambahFilm();
            frm.Owner = this;
            frm.Show();
        }

        private void btnKeluarDaftarFilm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listFilm = Film.BacaData("f.id", txtNilaiKriteria.Text);
                    break;
                case "Judul":
                    listFilm = Film.BacaData("f.judul", txtNilaiKriteria.Text);
                    break;
                case "Sinopsis":
                    listFilm = Film.BacaData("f.sinopsis", txtNilaiKriteria.Text);
                    break;
                case "Tahun Film":
                    listFilm = Film.BacaData("f.tahun", txtNilaiKriteria.Text);
                    break;
                case "Durasi Film":
                    listFilm = Film.BacaData("f.durasi", txtNilaiKriteria.Text);
                    break;
                case "Kelompok":
                    listFilm = Film.BacaData("k.nama", txtNilaiKriteria.Text);
                    break;
                case "Bahasa":
                    listFilm = Film.BacaData("f.bahasa", txtNilaiKriteria.Text);
                    break;
                case "IsSubIndo":
                    listFilm = Film.BacaData("f.is_sub_indo", txtNilaiKriteria.Text);
                    break;
                case "CoverImage":
                    listFilm = Film.BacaData("f.cover_image", txtNilaiKriteria.Text);
                    break;
                case "Diskon":
                    listFilm = Film.BacaData("f.diskon_nominal", txtNilaiKriteria.Text);
                    break;
            }

            TampilDataGrid();
        }

        private void dataGridViewDaftarFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarFilm.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarFilm.CurrentRow.Cells["ID"].Value.ToString();

                Film s = Film.AmbilDataByID("f.id",pID);
                if (s != null)
                {
                    FormUpdateFilm frm = new FormUpdateFilm();
                    frm.Owner = this;

                    frm.textBoxID.Text = s.Id.ToString();
                    frm.textBoxJudul.Text = s.Judul.ToString();
                    frm.textBoxSinopsis.Text = s.Sinopsis.ToString();
                    frm.textBoxTahun.Text = s.Tahun.ToString();
                    frm.textBoxDurasi.Text = s.Durasi.ToString();
                    frm.comboBoxBahasa.Text = s.Bahasa.ToString();
                    if (s.IsSubIndo == 1)
                        frm.comboBoxIsSubIndo.Text = "Iya";
                    else if (s.IsSubIndo == 0)
                        frm.comboBoxIsSubIndo.Text = "Tidak";
                    frm.textBoxCoverImage.Text = s.CoverImage.ToString();
                    frm.textBoxDiskonNominal.Text = (s.Diskon * 100).ToString();
                    frm.kelompok = s.Kelompok;

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarFilm.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarFilm.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarFilm.CurrentRow.Cells["Judul"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Film k = new Film(idHapus, namaHapus);
                    Boolean hapus = Film.HapusData(k);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarFilm_Load(btnKeluarDaftarFilm, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Judul");
            cmbKriteria.Items.Add("Sinopsis");
            cmbKriteria.Items.Add("Tahun Film");
            cmbKriteria.Items.Add("Durasi Film");
            cmbKriteria.Items.Add("Kelompok");
            cmbKriteria.Items.Add("Bahasa");
            cmbKriteria.Items.Add("IsSubIndo");
            cmbKriteria.Items.Add("CoverImage");
            cmbKriteria.Items.Add("Diskon");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarFilm.Columns.Clear();

            dataGridViewDaftarFilm.Columns.Add("Id", "ID");
            dataGridViewDaftarFilm.Columns.Add("Judul", "Judul");
            dataGridViewDaftarFilm.Columns.Add("Sinopsis", "Sinopsis");
            dataGridViewDaftarFilm.Columns.Add("Tahun", "Tahun Film");
            dataGridViewDaftarFilm.Columns.Add("Durasi", "Durasi Film");
            dataGridViewDaftarFilm.Columns.Add("Kelompok", "Kelompok");
            dataGridViewDaftarFilm.Columns.Add("Bahasa", "Bahasa");
            dataGridViewDaftarFilm.Columns.Add("IsSubIndo", "Sub Indonesia");
            dataGridViewDaftarFilm.Columns.Add("CoverImage", "Cover Image");
            dataGridViewDaftarFilm.Columns.Add("Diskon", "Diskon");

            dataGridViewDaftarFilm.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Judul"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Sinopsis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Tahun"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Durasi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Kelompok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Bahasa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["IsSubIndo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["CoverImage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarFilm.Columns["Diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarFilm.Columns["Diskon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDaftarFilm.AllowUserToAddRows = false;
            dataGridViewDaftarFilm.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarFilm.Rows.Clear();

            if (listFilm.Count > 0)
            {
                foreach (Film f in listFilm)
                {
                    dataGridViewDaftarFilm.Rows.Add(f.Id, f.Judul, f.Sinopsis, f.Tahun, f.Durasi, f.Kelompok.Nama, f.Bahasa, f.IsSubIndo, f.CoverImage, f.Diskon);
                }
            }
            else
            {
                dataGridViewDaftarFilm.DataSource = null;
            }
        }
    }
}
