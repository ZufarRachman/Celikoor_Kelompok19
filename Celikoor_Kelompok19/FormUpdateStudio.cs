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
    public partial class FormUpdateStudio : Form
    {
        public List<JenisStudio> listjenisStudios = new List<JenisStudio>();
        public List<Cinema> listCinema = new List<Cinema>();

        public Cinema cinemaName;
        public JenisStudio jenisStudioName;
        public FormUpdateStudio()
        {
            InitializeComponent();
        }

        private void FormUpdateStudio_Load(object sender, EventArgs e)
        {
            listjenisStudios = JenisStudio.BacaData("", "");
            listCinema = Cinema.BacaData("", "");

            comboBoxJenisStudio.DataSource = listjenisStudios;
            comboBoxJenisStudio.DisplayMember = "Nama";
            comboBoxJenisStudio.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
            comboBoxCinema.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCinema.Text = cinemaName.NamaCabang.ToString();
            comboBoxJenisStudio.Text = jenisStudioName.Nama.ToString();
            try
            {
                textBoxID.Enabled = false;

                textBoxNama.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate ID. Pesan Kesalahan : " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxKapasitas.Text = "";
            comboBoxJenisStudio.SelectedIndex = 0;
            comboBoxCinema.Text = "";
            textBoxHargaWeekday.Text = "";
            textBoxHargaWeekend.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarStudio frm = (FormDaftarStudio)this.Owner;
            frm.FormDaftarStudio_Load(buttonKeluar, e);

            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio jenisStudioDipilih = (JenisStudio)comboBoxJenisStudio.SelectedItem;

                Cinema cinemaDipilih = (Cinema)comboBoxCinema.SelectedItem;

                Studio k = new Studio(textBoxID.Text, textBoxNama.Text, int.Parse(textBoxKapasitas.Text), int.Parse(textBoxHargaWeekday.Text), int.Parse(textBoxHargaWeekend.Text), jenisStudioDipilih, cinemaDipilih);
                Studio.UbahData(k);
                MessageBox.Show("Data berhasil diubah.", "Info");
                buttonKeluar_Click(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message);
            }
        }
    }
}
