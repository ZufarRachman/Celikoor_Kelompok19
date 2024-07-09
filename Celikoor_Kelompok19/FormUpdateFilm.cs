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
    public partial class FormUpdateFilm : Form
    {
        public List<Kelompok> listKelompok = new List<Kelompok>();
        public List<AktorFilm> listAktorFilm = new List<AktorFilm>();
        public List<User> listAktor = new List<User>();
        public List<Genre> listGenre = new List<Genre>();
        public Kelompok kelompok;
        public FormUpdateFilm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int isSubIndo = 0;
                double diskonNominal = 0.0;

                if (comboBoxIsSubIndo.Text == "Iya")
                    isSubIndo = 1;
                else if (comboBoxIsSubIndo.Text == "Tidak")
                    isSubIndo = 0;
                diskonNominal = double.Parse(textBoxDiskonNominal.Text) / 100;

                Kelompok kelompokDipilih = (Kelompok)comboBoxKelompok.SelectedItem;

                Film f = new Film(textBoxID.Text, textBoxJudul.Text, textBoxSinopsis.Text, int.Parse(textBoxTahun.Text), int.Parse(textBoxDurasi.Text), comboBoxBahasa.Text, isSubIndo, textBoxCoverImage.Text, diskonNominal, kelompokDipilih);

                listGenre = Genre.BacaData("nama", comboBoxGenre.Text);

                f.TambahDataGenreFilm(f, listGenre[0]);

                for (int i = 0; i < dataGridViewDaftarAktor.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridViewDaftarAktor.Rows[i];
                    string id = row.Cells[0].Value.ToString();
                    string peran = row.Cells[2].Value.ToString();
                    User a = User.AmbilData("id", id);
                    f.TambahDataAktorFilm(f, a, peran);
                }

                Film.UbahData(f);
                MessageBox.Show("Data berhasil diubah.", "Info");
                buttonKeluar_Click(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxJudul.Text = "";
            textBoxSinopsis.Text = "";
            comboBoxBahasa.SelectedIndex = 0;
            comboBoxKelompok.SelectedIndex = 0;
            comboBoxIsSubIndo.SelectedIndex = 0;
            textBoxDurasi.Text = "";
            textBoxTahun.Text = "";
            textBoxCoverImage.Text = "";
            textBoxDiskonNominal.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarFilm frm = (FormDaftarFilm)this.Owner;
            frm.FormDaftarFilm_Load(buttonKeluar, e);

            this.Close();
        }

        private void FormUpdateFilm_Load(object sender, EventArgs e)
        {
            listKelompok = Kelompok.BacaData("", "");
            listGenre = Genre.BacaData("", "");
            listAktor = User.BacaData("", "");

            comboBoxKelompok.DataSource = listKelompok;
            comboBoxKelompok.DisplayMember = "Nama";
            comboBoxKelompok.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "Nama";
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxAktor.DataSource = listAktor.ToList();
            comboBoxAktor.DisplayMember = "Nama";
            comboBoxAktor.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxKelompok.Text = kelompok.Nama.ToString();

            try
            {
                textBoxID.Enabled = false;

                textBoxJudul.Focus();

                if (comboBoxBahasa.Items.Count <= 0 && comboBoxIsSubIndo.Items.Count <= 0)
                {
                    PopulateComboBox();
                }
                else
                {
                    comboBoxBahasa.SelectedIndex = 0;
                    comboBoxIsSubIndo.SelectedIndex = 0;
                }

                FormatDataGrid();

                listAktorFilm = AktorFilm.BacaData(textBoxID.Text);

                if (!dataGridViewDaftarAktor.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                    colHapus.HeaderText = "Aksi";
                    colHapus.Text = "Hapus";
                    colHapus.Name = "btnHapus";
                    colHapus.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarAktor.Columns.Add(colHapus);
                }

                TampilDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate ID. Pesan Kesalahan : " + ex.Message);
            }
        }

        private void PopulateComboBox()
        {
            string[] peran = { "UTAMA", "PEMBANTU", "FIGURAN" };
            string[] bahasa = { "EN", "ID", "CHN", "KOR", "JPN", "OTH" };
            comboBoxBahasa.Items.AddRange(bahasa);
            comboBoxBahasa.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxIsSubIndo.Items.Add("Iya");
            comboBoxIsSubIndo.Items.Add("Tidak");
            comboBoxIsSubIndo.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxPeranAktor.Items.AddRange(peran);
            comboBoxPeranAktor.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxBahasa.SelectedIndex = 0;
            comboBoxIsSubIndo.SelectedIndex = 0;
            comboBoxPeranAktor.SelectedIndex = 0;
        }
        private void FormatDataGrid()
        {
            dataGridViewDaftarAktor.Columns.Clear();

            dataGridViewDaftarAktor.Columns.Add("Id", "ID");
            dataGridViewDaftarAktor.Columns.Add("Nama", "Nama");
            dataGridViewDaftarAktor.Columns.Add("Peran", "Peran");

            dataGridViewDaftarAktor.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["Peran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarAktor.AllowUserToAddRows = false;
            dataGridViewDaftarAktor.ReadOnly = true;
        }

        private void dataGridViewDaftarAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarAktor.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus data?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    dataGridViewDaftarAktor.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void TampilDataGrid()
        {
            dataGridViewDaftarAktor.Rows.Clear();

            if (listAktorFilm.Count > 0)
            {
                foreach (AktorFilm af in listAktorFilm)
                {
                    dataGridViewDaftarAktor.Rows.Add(af.AktorID.Id, af.AktorID.Nama, af.Peran);
                }
            }
            else
            {
                dataGridViewDaftarAktor.DataSource = null;
            }
        }

        private void buttonTambahAktor_Click_1(object sender, EventArgs e)
        {
            User a = User.AmbilData("nama", comboBoxAktor.Text);
            dataGridViewDaftarAktor.Rows.Add(a.Id, a.Nama, comboBoxPeranAktor.Text);

            comboBoxAktor.SelectedIndex = 0;
            comboBoxPeranAktor.SelectedIndex = 0;

            if (!dataGridViewDaftarAktor.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.Name = "btnHapus";
                colHapus.UseColumnTextForButtonValue = true;
                dataGridViewDaftarAktor.Columns.Add(colHapus);
            }
        }
    }
}
