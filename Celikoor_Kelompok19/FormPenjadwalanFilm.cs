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
    public partial class FormPenjadwalanFilm : Form
    {
        public List<Film> listFilm = new List<Film>();
        public List<Cinema> listCinema = new List<Cinema>();
        public List<Picture> listStudio = new List<Picture>();
        public List<AktorFilm> listAktorFilm = new List<AktorFilm>();
        public List<GenreFilm> listGenreFilm = new List<GenreFilm>();
        public List<SesiFilm> listSesiFilm = new List<SesiFilm>();
        public FormPenjadwalanFilm()
        {
            InitializeComponent();
        }

        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.BacaData("", "");
            listCinema = Cinema.BacaData("", "");

            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
            comboBoxCinema.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";
            comboBoxJudul.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePickerTglPemutaran.Format = DateTimePickerFormat.Custom;
            dateTimePickerTglPemutaran.CustomFormat = "dddd, dd MMMM yyyy";

            

            FormatDataGrid();

            listSesiFilm = SesiFilm.BacaData();

            if (!dataGridViewDaftarCinemaStudio.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.Name = "btnHapus";
                colHapus.UseColumnTextForButtonValue = true;
                dataGridViewDaftarCinemaStudio.Columns.Add(colHapus);
            }
            TampilDataGrid();
        }

        private void buttonTambahJadwalFilm_Click(object sender, EventArgs e)
        {
            //buat list untuk menampung checkBox mana saja yang dicentang
            List<string> checkedBoxes = new List<string>();
            
            Film f = (Film)comboBoxJudul.SelectedItem;
            Picture s = (Picture)comboBoxStudio.SelectedItem;
            
            //mengecek apakah ada checkBox yang dicentang
            if(checkBoxI.Checked || checkBoxII.Checked || checkBoxIII.Checked || checkBoxIV.Checked)
            {
                //jika ada dicek lagi apakah nama studio, judul film, dan nama cabang sama dengan
                //yang ada di dataGrid, kalau sama TambahDataFilmStudio di skip
                if (!DuplicateDataFilmStudio(s.Nama.ToString(), f.Judul.ToString(), s.Cinema.NamaCabang.ToString()))
                    JadwalFilm.TambahDataFilmStudio(f, s);
            }

            if (checkBoxI.Checked)
            {
                checkedBoxes.Add("I");
            }
            if (checkBoxII.Checked)
            {
                checkedBoxes.Add("II");
            }
            if (checkBoxIII.Checked)
            {
                checkedBoxes.Add("III");
            }
            if (checkBoxIV.Checked)
            {
                checkedBoxes.Add("IV");
            }

            //for loop sesuai jumlah checkBox yang di centang
            foreach (string jamPemutaran in checkedBoxes)
            {
                string jadwalFilmID = JadwalFilm.GenerateID();

                //mengecek apakah nama studio, jam pemutaran, nama cabang, judul film, dan tanggal sama dengan yang ada di data grid
                //kalau sama TambahData dan TambahDataSesiFilm di skip
                if (!DuplicateDataInDataGrid(s.Nama.ToString(), jamPemutaran, s.Cinema.NamaCabang.ToString(), f.Judul.ToString(), dateTimePickerTglPemutaran.Value.ToString("dd MMMM yyyy")))
                {
                    dataGridViewDaftarCinemaStudio.Rows.Add(comboBoxJudul.Text, comboBoxCinema.Text, comboBoxStudio.Text, dateTimePickerTglPemutaran.Value.ToString("dd MMMM yyyy"), jamPemutaran);

                    JadwalFilm jf = new JadwalFilm(jadwalFilmID, dateTimePickerTglPemutaran.Value, jamPemutaran);

                    JadwalFilm.TambahData(jf);

                    JadwalFilm.TambahDataSesiFilm(f, s, jf);
                }
            }

            checkBoxI.Checked = false;
            checkBoxII.Checked = false;
            checkBoxIII.Checked = false;
            checkBoxIV.Checked = false;
            checkedBoxes.Clear();

            if (!dataGridViewDaftarCinemaStudio.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.Name = "btnHapus";
                colHapus.UseColumnTextForButtonValue = true;
                dataGridViewDaftarCinemaStudio.Columns.Add(colHapus);
            }
        }


        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDaftarCinemaStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarCinemaStudio.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string judul = dataGridViewDaftarCinemaStudio.CurrentRow.Cells["JudulFilm"].Value.ToString();
                string cinema = dataGridViewDaftarCinemaStudio.CurrentRow.Cells["Cinema"].Value.ToString();
                string studio = dataGridViewDaftarCinemaStudio.CurrentRow.Cells["Studio"].Value.ToString();
                string tanggal = dataGridViewDaftarCinemaStudio.CurrentRow.Cells["Tanggal"].Value.ToString();
                string jamPemutaran = dataGridViewDaftarCinemaStudio.CurrentRow.Cells["JamPemutaran"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + judul + " - " + cinema + "/" + studio + " - " + DateTime.Parse(tanggal).ToString("dd/MM/yyyy") + " - " + jamPemutaran + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    JadwalFilm jf = new JadwalFilm(DateTime.Parse(tanggal), jamPemutaran);
                    Film f = Film.AmbilDataByID("f.judul", judul);
                    Cinema c = Cinema.AmbilData("nama_cabang", cinema);
                    Picture s = Picture.AmbilDataForJadwalFilm("s.nama", studio, c);
                    Boolean hapusJadwalFilm = JadwalFilm.HapusData(jf, s, f);
                    if (hapusJadwalFilm == true)
                    {
                        MessageBox.Show("Jadwal Film data berhasil");
                        FormPenjadwalanFilm_Load(buttonKeluar, e);
                    }
                }
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarCinemaStudio.Columns.Clear();

            dataGridViewDaftarCinemaStudio.Columns.Add("JudulFilm", "Judul Film");
            dataGridViewDaftarCinemaStudio.Columns.Add("Cinema", "Cinema");
            dataGridViewDaftarCinemaStudio.Columns.Add("Studio", "Studio");
            dataGridViewDaftarCinemaStudio.Columns.Add("Tanggal", "Tanggal");
            dataGridViewDaftarCinemaStudio.Columns.Add("JamPemutaran", "Jam Pemutaran");

            dataGridViewDaftarCinemaStudio.Columns["JudulFilm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinemaStudio.Columns["Cinema"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinemaStudio.Columns["Studio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinemaStudio.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinemaStudio.Columns["JamPemutaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarCinemaStudio.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMMM yyyy"; 

            dataGridViewDaftarCinemaStudio.AllowUserToAddRows = false;
            dataGridViewDaftarCinemaStudio.ReadOnly = true;
        }

        private bool DuplicateDataInDataGrid(string studio, string jamPemutaran, string cinema, string judul, string tanggal)
        {
            //method ini berguna untuk mengecek apakah ada data yang sama di dataGrid
            //supaya tidak terjadi error duplicate entry
            foreach (DataGridViewRow rows in dataGridViewDaftarCinemaStudio.Rows)
            {
                if (rows.Cells["Studio"].Value.ToString() == studio && rows.Cells["JamPemutaran"].Value.ToString() == jamPemutaran && rows.Cells["Cinema"].Value.ToString() == cinema && rows.Cells["JudulFilm"].Value.ToString() == judul && rows.Cells["Tanggal"].Value.ToString() == tanggal)
                {
                    return true;
                }
            }
            return false;
        }

        private bool DuplicateDataFilmStudio(string studio, string judul, string cinema)
        {
            //method ini berguna untuk mengecek apakah ada data film_studio yang sama di dataGrid
            //supaya tidak terjadi error duplicate entry
            foreach (DataGridViewRow rows in dataGridViewDaftarCinemaStudio.Rows)
            {
                if (rows.Cells["Studio"].Value.ToString() == studio && rows.Cells["JudulFilm"].Value.ToString() == judul && rows.Cells["Cinema"].Value.ToString() == cinema)
                {
                    return true;
                }
            }
            return false;
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxCinema berubah
            Cinema c = Cinema.AmbilData("nama_cabang", comboBoxCinema.Text);

            listStudio = Picture.BacaData("s.cinemas_id",c.Id);

            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.ValueMember = "Id";
            comboBoxStudio.DisplayMember = "Nama";
            comboBoxStudio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxStudio berubah
            //dan karena comboBoxStudio akan berubah ketika kita memilih nilai di comboBoxCinema maka method ini akan berjalan juga
            //setiap kali kita mengganti comboBoxCinema
            if (comboBoxStudio.SelectedItem != null)
            {
                Picture s = (Picture)comboBoxStudio.SelectedItem;
                lblJenisStudio.Text = s.JenisStudio.Nama.ToString();
                lblJumlahKursi.Text = s.Kapasitas.ToString() + " Kursi";
                lblHargaWeekday.Text = "Rp " + s.Harga_weekday.ToString();
                lblHargaWeekend.Text = "Rp " + s.Harga_weekend.ToString();
            }
            else
            {
                throw new Exception("Error, tidak terdapat data studio");
            }
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxJudul berubah
            if (comboBoxJudul.SelectedItem != null)
            {
                Film f = (Film)comboBoxJudul.SelectedItem;
                Film.AmbilDataByID("f.id",f.Id);

                //mengganti gambar sesuai judul film
                pictureBoxPoster.LoadAsync(f.CoverImage);
                pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;

                //mengganti detail film sesuai judul film
                lblDurasiFilm.Text = f.Durasi.ToString() + " Menit";
                lblKelompok.Text = f.Kelompok.Nama.ToString();
                lblSinopsis.Text = f.Sinopsis.ToString();
                
                listAktorFilm = Film.AmbilDataAktorFromFilm(f.Id);
                listGenreFilm = Film.AmbilDataGenreFromFilm(f.Id);

                List<string> namaGenre = new List<string>();
                List<string> namaAktor = new List<string>();

                foreach(AktorFilm af in listAktorFilm)
                {
                    namaAktor.Add(af.AktorID.Nama.ToString());
                }
                foreach(GenreFilm gf in listGenreFilm)
                {
                    namaGenre.Add(gf.GenreID.Nama.ToString());
                }
                lblAktorUtama.Text = string.Join(", ", namaAktor);
                lblGenre.Text = string.Join(" ", namaGenre);
            }
            else
            {
                throw new Exception("Error, tidak terdapat data film");
            }
        }
        private void TampilDataGrid()
        {
            dataGridViewDaftarCinemaStudio.Rows.Clear();

            if (listSesiFilm.Count > 0)
            {
                foreach (SesiFilm sf in listSesiFilm)
                {
                    dataGridViewDaftarCinemaStudio.Rows.Add(sf.FilmID.Judul, sf.StudioID.Cinema.NamaCabang, sf.StudioID.Nama, sf.JadwalFilmID.TanggalPemutaran, sf.JadwalFilmID.JamPemutaran);
                }
            }
            else
            {
                dataGridViewDaftarCinemaStudio.DataSource = null;
            }
        }

    }
}
