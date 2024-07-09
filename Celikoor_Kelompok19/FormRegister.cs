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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_Kelompok19
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtUlangPass.Text)
                {
                    MessageBox.Show("Password tidak sama! Silahkan diulangi.");
                }
                else
                {
                    string generateID = Konsumen.GenerateID();
                    string gender = "";
                    if(rbMale.Checked)
                    {
                        gender = "L";
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = "P";
                    }

                    Konsumen k = new Konsumen(generateID, txtNama.Text, txtEmail.Text, txtTelp.Text, gender, dateTimePicker.Value, double.Parse(lblSaldo.Text), txtUsername.Text, txtPassword.Text);
                    Konsumen.TambahData(k);
                    MessageBox.Show("Anda berhasil registrasi.", "Info");

                    btnLogin_Click(this, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Registrasi. Pesan kesalahan: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtEmail.Text = "";
            txtTelp.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUlangPass.Text = "";
            txtNama.Focus();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTampilPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtUlangPass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtUlangPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = (FormLogin)this.Owner;
            frm.Enabled = true;
            this.Close();
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.DodgerBlue;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.LightSlateGray;
        }
    }
}
