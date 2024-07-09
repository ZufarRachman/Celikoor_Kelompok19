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
    public partial class FormDaftarAktors : Form
    {
        public List<Aktor> listAktor = new List<Aktor>();

        public FormDaftarAktors()
        {
            InitializeComponent();
        }

        public void FormDaftarAktors_Load(object sender, EventArgs e)
        {
            listAktor = Aktor.BacaData("", "");

            if (listAktor.Count > 0)
            {
                dataGridViewDaftarAktor.DataSource = listAktor;
                if (dataGridViewDaftarAktor.ColumnCount == 5)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Ubah";
                    bCol.Name = "btnUbahGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarAktor.Columns.Add(bCol);

                    DataGridViewButtonColumn bCol2 = new DataGridViewButtonColumn();
                    bCol2.HeaderText = "Aksi";
                    bCol2.Text = "Hapus";
                    bCol2.Name = "btnHapusGrid";
                    bCol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarAktor.Columns.Add(bCol2);
                }
            }
            else
            {
                dataGridViewDaftarAktor.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listAktor = Aktor.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listAktor = Aktor.BacaData("nama", txtNilaiKriteria.Text);
                    break;
                case "Tanggal Lahir":
                    listAktor = Aktor.BacaData("tgl_lahir", txtNilaiKriteria.Text);
                    break;
                case "Gender":
                    listAktor = Aktor.BacaData("gender", txtNilaiKriteria.Text);
                    break;
                case "Negara Asal":
                    listAktor = Aktor.BacaData("negara_asal", txtNilaiKriteria.Text);
                    break;
            }

            if (listAktor.Count > 0)
            {
                dataGridViewDaftarAktor.DataSource = listAktor;
            }
            else
            {
                dataGridViewDaftarAktor.DataSource = null;
            }
        }

        private void btnKeluarDaftarAktor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Tanggal Lahir");
            cmbKriteria.Items.Add("Gender");
            cmbKriteria.Items.Add("Negara Asal");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnTambahAktor_Click(object sender, EventArgs e)
        {
            FormTambahAktors frm = new FormTambahAktors();
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridViewDaftarAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarAktor.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarAktor.CurrentRow.Cells["ID"].Value.ToString();

                Aktor a = Aktor.AmbilData("id", pID);
                if (a != null)
                {
                    FormUpdateAktor frm = new FormUpdateAktor();
                    frm.Owner = this;
                    frm.textBoxID.Text = a.Id.ToString();
                    frm.textBoxNama.Text = a.Nama.ToString();
                    frm.dateTimePickerTglLahir.Value = DateTime.Parse(a.TglLahir.ToString());
                    frm.comboBoxGender.Text = a.Gender.ToString();
                    frm.textBoxNegaraAsal.Text = a.NegaraAsal.ToString();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarAktor.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarAktor.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarAktor.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Aktor c = new Aktor(idHapus, namaHapus);
                    Boolean hapus = Aktor.HapusData(c);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarAktors_Load(btnKeluarDaftarAktor, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }
    }
}
