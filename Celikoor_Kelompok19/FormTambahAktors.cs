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
    public partial class FormTambahAktors : Form
    {
        public FormTambahAktors()
        {
            InitializeComponent();
        }

        private void FormTambahAktors_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = Aktor.GenerateID();
                textBoxID.Enabled = false;

                textBoxNama.Focus();

                if (comboBoxGender.Items.Count <= 0)
                    PopulateComboBox();
                else
                    comboBoxGender.SelectedIndex = 0;
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
                Aktor a = new Aktor(textBoxID.Text, textBoxNama.Text, dateTimePickerTglLahir.Value, comboBoxGender.Text, textBoxNegaraAsal.Text);
                Aktor.TambahData(a);
                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahAktors_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            dateTimePickerTglLahir.Text = "1990/01/01";
            comboBoxGender.SelectedIndex = 0;
            textBoxNegaraAsal.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarAktors frm = (FormDaftarAktors)this.Owner;
            frm.FormDaftarAktors_Load(buttonKeluar, e);

            this.Close();
        }

        private void PopulateComboBox()
        {
            comboBoxGender.Items.Add("P");
            comboBoxGender.Items.Add("L");
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
