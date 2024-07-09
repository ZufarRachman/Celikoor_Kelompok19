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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi con = new Koneksi();

                Pegawai p = Pegawai.CekLogin(txtUsername.Text, txtPassword.Text);
                Konsumen k = Konsumen.CekLogin(txtUsername.Text, txtPassword.Text);
                
                if(!(p is null) || !(k is null))
                {
                    if(p is null)
                    {
                        FormMain frm = (FormMain)this.Owner;
                        frm.konsumen = k;

                        MessageBox.Show("Koneksi berhasil. Selamat datang " + k.Nama, "Informasi");
                    }
                    else if(k is null)
                    {
                        FormMain frm = (FormMain)this.Owner;
                        frm.pegawai = p;

                        MessageBox.Show("Koneksi berhasil. Selamat datang " + p.Nama, "Informasi");

                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan Kesalahan: " + ex.Message);
            }
        }

        private void lblRegis_Click(object sender, EventArgs e)
        {
            //new FormRegister().Show();
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            frm.Show();

            this.Enabled = false;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void lblRegis_MouseHover(object sender, EventArgs e)
        {
            lblRegis.ForeColor = Color.DodgerBlue;
        }

        private void lblRegis_MouseLeave(object sender, EventArgs e)
        {
            lblRegis.ForeColor = Color.LightSlateGray;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
