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
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = Pegawai.GenerateID();
                textBoxID.Enabled = false;

                textBoxNama.Focus();
                if (comboBoxRole.Items.Count <= 0)
                    PopulateComboBox();
                else
                    comboBoxRole.SelectedIndex = 0;
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
                if(textBoxPassword.Text != textBoxUlangiPassword.Text)
                {
                    MessageBox.Show("Password tidak sama! Silahkan diulangi.");
                }
                else
                {
                    Pegawai p = new Pegawai(textBoxID.Text, textBoxNama.Text, textBoxEmail.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text);

                    Pegawai.TambahData(p);

                    MessageBox.Show("Data berhasil ditambahkan.", "Info");
                    buttonKosongi_Click(this, e);
                    FormTambahPegawai_Load(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangiPassword.Text = "";
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai frm = (FormDaftarPegawai)this.Owner;
            frm.FormDaftarPegawai_Load(buttonKeluar, e);

            this.Close();
        }

        private void PopulateComboBox()
        {
            comboBoxRole.Items.Add("ADMIN");
            comboBoxRole.Items.Add("KASIR");
            comboBoxRole.Items.Add("OPERATOR");
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
