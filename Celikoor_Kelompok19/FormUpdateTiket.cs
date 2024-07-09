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
using System.Windows.Forms.VisualStyles;

namespace Celikoor_Kelompok19
{
    public partial class FormUpdateTiket : Form
    {
        public Pegawai operatorNama;
        public FormUpdateTiket()
        {
            InitializeComponent();
        }

        private void FormUpdateTiket_Load(object sender, EventArgs e)
        {
            lblNamaOperator.Text = operatorNama.Nama.ToString();
            
            try
            {
                textBoxID.Enabled = false;

                if (comboBoxStatusHadir.Items.Count <= 0)
                {
                    PopulateComboBox();
                }
                else
                {
                    comboBoxStatusHadir.SelectedIndex = 0;
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
                double harga = double.Parse(textBoxHarga.Text);
                Invoice i = Invoice.AmbilDataByID(textBoxID.Text);
                string statusHadir = "";
                if(comboBoxStatusHadir.Text == "Hadir")
                {
                    statusHadir = "1";
                }
                else if(comboBoxStatusHadir.Text == "Belum Hadir")
                {
                    statusHadir = "0";
                }
                Comment t = new Comment(statusHadir, operatorNama, double.Parse(textBoxHarga.Text), lblNomorKursi.Text, i);

                Comment.UbahData(t);
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
            textBoxHarga.Text = "";
            comboBoxStatusHadir.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarTiket frm = (FormDaftarTiket)this.Owner;
            frm.FormDaftarTiket_Load(buttonKeluar, e);

            this.Close();
        }

        private void PopulateComboBox()
        {
            comboBoxStatusHadir.Items.Add("Belum Hadir");
            comboBoxStatusHadir.Items.Add("Hadir");
        }
    }
}
