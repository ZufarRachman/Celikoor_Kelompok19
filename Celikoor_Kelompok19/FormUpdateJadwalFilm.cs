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
    public partial class FormUpdateJadwalFilm : Form
    {
        public FormUpdateJadwalFilm()
        {
            InitializeComponent();
        }

        private void FormUpdateJadwalFilm_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Enabled = false;

                if (comboBoxJamPemutaran.Items.Count <= 0)
                    PopulateComboBox();
                else
                    comboBoxJamPemutaran.SelectedIndex = 0;
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
                JadwalFilm jf = new JadwalFilm(textBoxID.Text, dateTimePickerTglPemutaran.Value, comboBoxJamPemutaran.Text);
                JadwalFilm.UbahData(jf);
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
            dateTimePickerTglPemutaran.Text = "2024/01/01";
            comboBoxJamPemutaran.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJadwalFilm frm = (FormDaftarJadwalFilm)this.Owner;
            frm.FormDaftarJadwalFilm_Load(buttonKeluar, e);

            this.Close();
        }

        private void PopulateComboBox()
        {
            comboBoxJamPemutaran.Items.Add("I");
            comboBoxJamPemutaran.Items.Add("II");
            comboBoxJamPemutaran.Items.Add("III");
            comboBoxJamPemutaran.Items.Add("IV");
            comboBoxJamPemutaran.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
