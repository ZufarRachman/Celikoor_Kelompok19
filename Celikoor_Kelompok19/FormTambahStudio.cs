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
    public partial class FormTambahStudio : Form
    {
        public List<JenisStudio> listjenisStudios = new List<JenisStudio>();
        public List<Cinema> listCinema = new List<Cinema>();
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            { 
                JenisStudio jenisStudioDipilih = (JenisStudio) comboBoxJenisStudio.SelectedItem;

                Cinema cinemaDipilih = (Cinema) comboBoxCinema.SelectedItem;

                Picture k = new Picture(textBoxID.Text, textBoxNama.Text, int.Parse(textBoxKapasitas.Text), int.Parse(textBoxHargaWeekday.Text), int.Parse(textBoxHargaWeekend.Text), jenisStudioDipilih, cinemaDipilih);
                Picture.TambahData(k);
                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahStudio_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            listjenisStudios = JenisStudio.BacaData("", "");
            listCinema = Cinema.BacaData("", "");

            comboBoxJenisStudio.DataSource = listjenisStudios;
            comboBoxJenisStudio.DisplayMember = "Nama";
            comboBoxJenisStudio.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
            comboBoxCinema.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                textBoxID.Text = Picture.GenerateID();
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
    }
}
