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

    public partial class FormTambahInvoice : Form
    {
        public List<Konsumen> listKonsumen = new List<Konsumen>();
        public List<Pegawai> listKasir = new List<Pegawai>();
        public FormTambahInvoice()
        {
            InitializeComponent();
        }

        private void FormTambahInvoice_Load(object sender, EventArgs e)
        {
            listKonsumen = Konsumen.BacaData("", "");
            listKasir = Pegawai.BacaData("roles", "KASIR");

            comboBoxKonsumen.DataSource = listKonsumen;
            comboBoxKonsumen.DisplayMember = "Nama";

            comboBoxKasir.DataSource = listKasir;
            comboBoxKasir.DisplayMember = "Nama";

            try
            {
                textBoxID.Text = Invoice.GenerateID();
                textBoxID.Enabled = false;

                if (comboBoxStatus.Items.Count <= 0)
                {
                    PopulateComboBox();
                }
                else
                {
                    comboBoxStatus.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate ID. Pesan Kesalahan : " + ex.Message);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                double diskonNominal = double.Parse(textBoxDiskonNominal.Text) / 100;

                Konsumen namaKonsumen = (Konsumen)comboBoxKonsumen.SelectedItem;
                Pegawai namaKasir = (Pegawai)comboBoxKasir.SelectedItem;

                Invoice i = new Invoice(textBoxID.Text, dateTimePickerTgl.Value, double.Parse(textBoxGrandTotal.Text), diskonNominal, namaKonsumen, namaKasir, comboBoxStatus.Text);

                Invoice.TambahData(i);
                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahInvoice_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            dateTimePickerTgl.Text = "2024/01/01";
            textBoxGrandTotal.Text = "";
            comboBoxStatus.SelectedIndex = 0;
            comboBoxKasir.SelectedIndex = 0;
            comboBoxKonsumen.SelectedIndex = 0;
            textBoxDiskonNominal.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarInvoice frm = (FormDaftarInvoice)this.Owner;
            frm.FormDaftarInvoice_Load(buttonKeluar, e);

            this.Close();
        }

        private void PopulateComboBox()
        {
            comboBoxStatus.Items.Add("PENDING");
            comboBoxStatus.Items.Add("VALIDASI");
            comboBoxStatus.Items.Add("TERBAYAR");
        }
    }
}
