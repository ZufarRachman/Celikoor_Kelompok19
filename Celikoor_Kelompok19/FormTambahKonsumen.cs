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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }

        private void FormTambahKonsumen_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = Konsumen.GenerateID();
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
                if (textBoxPassword.Text != textBoxUlangiPassword.Text)
                {
                    MessageBox.Show("Password tidak sama! Silahkan diulangi.");
                }
                else
                {
                    Konsumen k = new Konsumen(textBoxID.Text, textBoxNama.Text, textBoxEmail.Text, textBoxNoHp.Text, comboBoxGender.Text, dateTimePickerTglLahir.Value, double.Parse(textBoxSaldo.Text), textBoxUsername.Text, textBoxPassword.Text);
                    Konsumen.TambahData(k);
                    MessageBox.Show("Data berhasil ditambahkan.", "Info");
                    buttonKosongi_Click(this, e);
                    FormTambahKonsumen_Load(this, e);
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
            dateTimePickerTglLahir.Text = "1990/01/01";
            comboBoxGender.SelectedIndex = 0;
            textBoxEmail.Text = "";
            textBoxNoHp.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxSaldo.Text = "";
            textBoxUlangiPassword.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarKonsumen frm = (FormDaftarKonsumen)this.Owner;
            frm.FormDaftarKonsumen_Load(buttonKeluar, e);

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
