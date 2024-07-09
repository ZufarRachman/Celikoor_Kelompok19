using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Kelompok19
{
    public partial class FormHalamanProfileKonsumen : Form
    {
        public Konsumen profile;
        public FormHalamanProfileKonsumen()
        {
            InitializeComponent();
        }

        private void FormHalamanProfileKonsumen_Load(object sender, EventArgs e)
        {
            lblID.Text = profile.Id;
            lblNama.Text = profile.Nama;
            lblEmail.Text = profile.Email;
            lblNoHp.Text = profile.NoHp;
            if (profile.Gender == "L")
                lblGender.Text = profile.Gender + " - " + "Laki-laki";
            else
                lblGender.Text = profile.Gender + " - " + "Perempuan";
            lblSaldo.Text = "Rp " + profile.Saldo.ToString();
            lblTglLahir.Text = profile.TglLahir.ToString("dd  MMMM yyyy");
            lblUsername.Text = profile.Username;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
