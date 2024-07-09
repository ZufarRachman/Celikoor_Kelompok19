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
    public partial class FormPemesananTiket : Form
    {
        public List<Film> listFilm = new List<Film>();
        public List<Cinema> listCinema = new List<Cinema>();
        public List<Studio> listStudio = new List<Studio>();
        public List<AktorFilm> listAktorFilm = new List<AktorFilm>();
        public List<GenreFilm> listGenreFilm = new List<GenreFilm>();
        public List<SesiFilm> listSesiFilm = new List<SesiFilm>();
        public List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();
        public List<string> listKursi = new List<string>();
        public List<string> listKursiTerpilih = new List<string>();
        public CheckBox checkBox;
        public Konsumen konsumen;
        public FormPemesananTiket()
        {
            InitializeComponent();
        }

        private void FormPemesananTiket_Load(object sender, EventArgs e)
        {
            listFilm = Film.BacaData("", "");

            if(!(konsumen is null))
                lblSaldo.Text = konsumen.Saldo.ToString();

            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";
            comboBoxJudul.DropDownStyle = ComboBoxStyle.DropDownList;

            //Format tampilan dateTimePicker
            dateTimePickerTanggalPesan.Format = DateTimePickerFormat.Custom;
            dateTimePickerTanggalPesan.CustomFormat = "dddd, dd MMMM yyyy";

            //Buat nampilin gambar
            Film f = (Film)comboBoxJudul.SelectedItem;
            pictureBoxPoster.LoadAsync(f.CoverImage);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            //dari sini sampe baris 94. Buat nampilin jumlah kursi, karena studio dengan kursi terbanyak di database kita 120 makanya jumlah kursi jadi 120
            int jumlahKolom = 3;
            int jumlahKursi = 120;

            FlowLayoutPanel activeLayout = flowLayoutPanelColumnA;
            string kolom = "A";
            int kursiPerKolom = (int)Math.Ceiling((double)(jumlahKursi / jumlahKolom));

            List<int> kursiPerlayout = new List<int>();

            //masukin data ke list kursiPerLayout. Ada 3 kolom jadi bakal ada 3 data
            for (int i = 0; i < jumlahKolom; i++)
            {
                kursiPerlayout.Add(kursiPerKolom);
            }
            
            //Buat checkBox nya ada 120 dibagi ke 3 kolom. Jadi nilai i = 40
            foreach (int i in kursiPerlayout)
            {
                for (int j = 0; j < i; j++)
                {
                    checkBox = new CheckBox();
                    checkBox.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    checkBox.Text = (j + 1).ToString();
                    checkBox.Name = kolom + (j + 1).ToString();
                    checkBox.Width = 40;
                    checkBox.Enabled = false;
                    checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChange);

                    activeLayout.Controls.Add(checkBox);
                }

                if(activeLayout == flowLayoutPanelColumnA)
                {
                    activeLayout = flowLayoutPanelColumnB;
                    kolom = "B";
                }
                else if(activeLayout == flowLayoutPanelColumnB)
                {
                    activeLayout = flowLayoutPanelColumnC;
                    kolom = "C";
                }
            }
        }

        private void checkBox_CheckedChange(object sender, EventArgs e)
        {
            //Method ini bekerja setiap kali checkBox diklik dan akan menjalankan if...else sesuai dengan checked == true atau false

            Film f = (Film)comboBoxJudul.SelectedItem;
            CheckBox checkBox = (CheckBox)sender;
            int jumlahKursiTerpilih = 0;
            //masukan nama checkBox ke dalam listKursi
            if(checkBox.Enabled == true)
            {
                if(checkBox.Checked == true)
                {
                    listKursi.Add(checkBox.Name.ToString());
                }
                else if (checkBox.Checked == false)
                {
                    listKursi.Remove(checkBox.Name.ToString());
                }
            }

            //masukan data ke dalam jumlahKursiTerpilih supaya bisa mendapatkan harga total
            for(int i = 0; i < listKursi.Count; i++)
            {
                jumlahKursiTerpilih++;
            }
            //Label kursi
            lblKursiTerpilih.Text = string.Join(",", listKursi);

            int totalHarga = int.Parse(lblHarga.Text) * jumlahKursiTerpilih;
            int diskonHarga = (int)(totalHarga * f.Diskon);
            int hargaBayar = totalHarga - diskonHarga;

            //label total harga, diskon, dan total akhir
            lblTotalHarga.Text = totalHarga.ToString();
            lblJumlahDiskon.Text = diskonHarga.ToString();
            lblTotalAkhir.Text = hargaBayar.ToString();

        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxJudul berubah
            if (comboBoxJudul.SelectedItem != null)
            {
                Film f = (Film)comboBoxJudul.SelectedItem;

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

                foreach (AktorFilm af in listAktorFilm)
                {
                    namaAktor.Add(af.AktorID.Nama.ToString());
                }
                foreach (GenreFilm gf in listGenreFilm)
                {
                    namaGenre.Add(gf.GenreID.Nama.ToString());
                }
                lblAktorUtama.Text = string.Join(", ", namaAktor);
                lblGenre.Text = string.Join(" ", namaGenre);

                listCinema = SesiFilm.BacaDataCinemas(dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd"), comboBoxJudul.Text);

                comboBoxCinema.DataSource = listCinema;
                comboBoxCinema.DisplayMember = "NamaCabang";
                comboBoxCinema.DropDownStyle = ComboBoxStyle.DropDownList;

                string isiJudul = comboBoxJudul.Text;
                string isiTgl = dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd");
                string isiCinema = comboBoxCinema.Text;
                string isiStudio = comboBoxStudio.Text;
                ProcessSelectedSeats(isiTgl, isiJudul, isiCinema, isiStudio);

            }
            else
            {
                throw new Exception("Error, tidak terdapat data film");
            }
        }
        public void ProcessSelectedSeats(string isiTgl, string isiJudul, string isiCinema, string isiStudio)
        {
            List<string> listKursiTerpilih = Ticket.GetKursi(isiTgl, isiJudul, isiCinema, isiStudio);
            string kursiListAsString = string.Join(",", listKursiTerpilih);
            kursiListAsString = kursiListAsString.Replace(" ", "");

            if (kursiListAsString != "")
            {
                string[] chairsArray = kursiListAsString.Split(',');
                FlowLayoutPanel flowLayoutPanel = null;
                foreach (string chair in chairsArray)
                {
                    string letter = chair.Substring(0, 1);
                    string number = chair.Substring(1);

                    if (letter == "A")
                    {
                        flowLayoutPanel = flowLayoutPanelColumnA;
                    }
                    else if (letter == "B")
                    {
                        flowLayoutPanel = flowLayoutPanelColumnB;
                    }
                    else if (letter == "C")
                    {
                        flowLayoutPanel = flowLayoutPanelColumnC;
                    }
                    else
                    {
                        flowLayoutPanel = flowLayoutPanelColumnC;
                    }

                    FlowLayoutPanel targetPanel = flowLayoutPanel;

                    foreach (Control control in targetPanel.Controls)
                    {
                        if (control is CheckBox && control.Text.Trim() == number)
                        {
                            CheckBox targetCheckbox = (CheckBox)control;
                            targetCheckbox.Enabled = false;
                            targetCheckbox.Checked = true;
                        }
                    }
                }
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxCinema berubah
            //dan karena comboBoxCinema akan berubah ketika kita memilih tanggal maka method ini akan berjalan juga
            //setiap kali kita mengganti tanggal
            Cinema c = Cinema.AmbilData("nama_cabang", comboBoxCinema.Text);

            listStudio = SesiFilm.BacaDataStudios(dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd"), comboBoxJudul.Text, c.NamaCabang);

            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.ValueMember = "Id";
            comboBoxStudio.DisplayMember = "Nama";
            comboBoxStudio.DropDownStyle = ComboBoxStyle.DropDownList;

            string isiJudul = comboBoxJudul.Text;
            string isiTgl = dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd");
            string isiCinema = comboBoxCinema.Text;
            string isiStudio = comboBoxStudio.Text;
            ProcessSelectedSeats(isiTgl, isiJudul, isiCinema, isiStudio);
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method ini berjalan tiap kali nilai yang kita pilih di comboBoxStudio berubah
            //dan karena comboBoxStudio akan berubah ketika kita memilih nilai di comboBoxCinema maka method ini akan berjalan juga
            //setiap kali kita mengganti comboBoxCinema
            if (comboBoxStudio.SelectedItem != null)
            {
                Film f = (Film)comboBoxJudul.SelectedItem;
                Studio s = (Studio)comboBoxStudio.SelectedItem;
                lblStudio.Text = s.JenisStudio.Nama.ToString();
                lblTotalKursi.Text = s.Kapasitas.ToString() + " Kursi";
                DateTime tanggalPesan = dateTimePickerTanggalPesan.Value;

                listJadwalFilm = SesiFilm.BacaDataJadwalFilm(s, f);

                comboBoxJamPemutaran.DataSource = listJadwalFilm;
                comboBoxJamPemutaran.DisplayMember = "JamPemutaran";
                comboBoxJamPemutaran.DropDownStyle = ComboBoxStyle.DropDownList;

                //mengganti label harga sesuai harinya, kalau bukan hari sabtu atau minggu
                //maka label harga berubah menjadi harga_weekday begitu pula sebaliknya
                if (tanggalPesan.DayOfWeek == DayOfWeek.Saturday || tanggalPesan.DayOfWeek == DayOfWeek.Sunday)
                {
                    lblHarga.Text = s.Harga_weekend.ToString();
                }
                else
                {
                    lblHarga.Text = s.Harga_weekday.ToString();
                }

                //mulai dari sini sampai baris 271 akan menampilkan jumlah checkBox yang enabled atau yang bisa diklik
                //dengan mengurangi jumlah kursi dengan kapasitas tiap studio
                int jumlahKursi = 120 - s.Kapasitas;
                int jumlahKolom = 3;
                int sisaKursi = jumlahKursi % jumlahKolom;
                int kursiPerKolom = (int)Math.Ceiling((double)(jumlahKursi / jumlahKolom));

                FlowLayoutPanel activeLayout = flowLayoutPanelColumnA;
                
                List<int> listKursiTidakTersedia = new List<int>();

                //menambahkan data ke listKursiTidakTersedia
                //misal, kursiPerKolom = 80 / 3 = 26,66667
                //berarti, 26 akan ditambahkan 3 kali ke dalam list
                for(int i = 0; i < jumlahKolom; i++)
                {
                    listKursiTidakTersedia.Add(kursiPerKolom);
                }
                //menambahkan sisa kursi dari 80 % 3 = 2
                //list akan ditambahkan 1 kursi per data dalam list dan akan di loop sebanyak 2 kali
                for(int i = 0; i < sisaKursi; i++)
                {
                    listKursiTidakTersedia[i]++;
                }

                //ada 3 data didalam list, berarti for akann di loop sebanyak 3 kali
                foreach (int i in listKursiTidakTersedia)
                {
                    //pertama-tama kita buat semua checkBox enable
                    for (int j = 0; j < 40; j++)
                    {
                        if (activeLayout.Controls.Count > 0)
                        {
                            checkBox = (CheckBox)activeLayout.Controls[j];
                            checkBox.Enabled = true;
                            checkBox.Checked = false;
                        }
                    }

                    //lalu kita disable checkBox sesuai dengan jumlahKursi yang tidak tersedia
                    //berarti ada 27, 27, 26 kursi per kolom yang tidak tersedia
                    for (int j = 0; j < i; j++)
                    {
                        if(activeLayout.Controls.Count > 0)
                        {
                            checkBox = (CheckBox)activeLayout.Controls[j];
                            checkBox.Enabled = false;
                        }
                    }
                    if (activeLayout == flowLayoutPanelColumnA)
                    {
                        activeLayout = flowLayoutPanelColumnB;
                    }
                    else if (activeLayout == flowLayoutPanelColumnB)
                    {
                        activeLayout = flowLayoutPanelColumnC;
                    }
                }
            }
            else
            {
                throw new Exception("Error, tidak terdapat data studio");
            }

            string isiJudul = comboBoxJudul.Text;
            string isiTgl = dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd");
            string isiCinema = comboBoxCinema.Text;
            string isiStudio = comboBoxStudio.Text;
            ProcessSelectedSeats(isiTgl, isiJudul, isiCinema, isiStudio);
        }

        private void dateTimePickerTanggalPesan_ValueChanged(object sender, EventArgs e)
        {
            //method ini berjalan setiap kali kita memilih tanggal
            //dan akan memunculkan cinema yang menampilkan film yang dipilih di tanggal yang dipilih
            listCinema = SesiFilm.BacaDataCinemas(dateTimePickerTanggalPesan.Value.ToString("yyyy-MM-dd"), comboBoxJudul.Text);

            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
            comboBoxCinema.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            string invoicesId = Invoice.GenerateID();
            double totalBayar = double.Parse(lblTotalAkhir.Text);
            double total = double.Parse(lblTotalHarga.Text);

            if (konsumen.Saldo >= totalBayar)
            {
                Film f = (Film)comboBoxJudul.SelectedItem;
                Studio s = (Studio)comboBoxStudio.SelectedItem;
                JadwalFilm jf = (JadwalFilm)comboBoxJamPemutaran.SelectedItem;

                SesiFilm sf = SesiFilm.AmbilData(jf, s, f);

                Invoice i = new Invoice(invoicesId, dateTimePickerTanggalPesan.Value, totalBayar, total, f.Diskon, konsumen, "PENDING", sf);
                string kursi = lblKursiTerpilih.Text;
                string parts = kursi;
                //MessageBox.Show(parts);

                Invoice.Pemesanan(i, parts);
                MessageBox.Show("Pemesanan berhasil. Terima kasih atas pesanan anda.\n Selamat menikmati film anda.");
                buttonKeluar_Click(this, e);
            }
            else
            {
                MessageBox.Show("Saldo tidak mencukupi. Harap isi ulang saldo");
            }
        }
    }
}
