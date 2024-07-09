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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema(textBoxID.Text ,textBoxNamaCabang.Text, textBoxAlamat.Text, dateTimePickerDibuka.Value, textBoxKota.Text);

                Cinema.TambahData(c);

                MessageBox.Show("Data berhasil ditambahkan.", "Info");
                buttonKosongi_Click(this, e);
                FormTambahCinema_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaCabang.Text = "";
            textBoxAlamat.Text = "";
            textBoxKota.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarCinema frm = (FormDaftarCinema)this.Owner;
            frm.FormDaftarCinema_Load(buttonKeluar, e);

            this.Close();
        }

        private void FormTambahCinema_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = Cinema.GenerateID();
                textBoxID.Enabled = false;

                textBoxNamaCabang.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan generate ID. Pesan Kesalahan : " + ex.Message);
            }
        }
    }
}
