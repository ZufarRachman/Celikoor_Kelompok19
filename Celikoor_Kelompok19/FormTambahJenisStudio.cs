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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio g = new JenisStudio(textBoxID.Text, textBoxNama.Text, textBoxDeskripsi.Text);

                JenisStudio.TambahData(g);

                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahJenisStudio_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxDeskripsi.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJenisStudio frm = (FormDaftarJenisStudio)this.Owner;
            frm.FormDaftarJenisStudio_Load(buttonKeluar, e);

            this.Close();
        }

        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = JenisStudio.GenerateID();
                textBoxID.Enabled = false;

                textBoxNama.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate ID. Pesan Kesalahan : " + ex.Message);
            }
        }
    }
}
