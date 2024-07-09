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
    public partial class FormUpdateInvoice : Form
    {
        public Konsumen konsumen;
        public Pegawai kasir;
        public FormUpdateInvoice()
        {
            InitializeComponent();
        }

        private void FormUpdateInvoice_Load(object sender, EventArgs e)
        {
            lblNamaKonsumen.Text = konsumen.Nama.ToString();
            lblNamaKasir.Text = kasir.Nama.ToString();

            try
            {
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double diskonNominal = double.Parse(textBoxDiskonNominal.Text) / 100;
                
                Invoice f = new Invoice(textBoxID.Text, dateTimePickerTgl.Value, double.Parse(textBoxGrandTotal.Text), diskonNominal, konsumen, kasir, comboBoxStatus.Text);

                Invoice.UbahData(f);
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
            dateTimePickerTgl.Text = "2024/01/01";
            textBoxGrandTotal.Text = "";
            comboBoxStatus.SelectedIndex = 0;
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
