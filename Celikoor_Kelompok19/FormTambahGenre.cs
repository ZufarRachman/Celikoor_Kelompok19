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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Genre g = new Genre(textBoxID.Text, textBoxNama.Text, textBoxDeskripsi.Text);

                Genre.TambahData(g);

                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahGenre_Load(this, e);
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
            FormDaftarGenre frm = (FormDaftarGenre)this.Owner;
            frm.FormDaftarGenre_Load(buttonKeluar, e);

            this.Close();
        }

        private void FormTambahGenre_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = Genre.GenerateID();
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
