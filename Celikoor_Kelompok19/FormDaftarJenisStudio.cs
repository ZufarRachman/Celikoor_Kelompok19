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
    public partial class FormDaftarJenisStudio : Form
    {
        public List<JenisStudio> listJenisStudio = new List<JenisStudio>();
        public FormDaftarJenisStudio()
        {
            InitializeComponent();
        }

        private void btnTambahJenisStudio_Click(object sender, EventArgs e)
        {
            FormTambahJenisStudio frm = new FormTambahJenisStudio();
            frm.Owner = this;
            frm.Show();
        }

        public void FormDaftarJenisStudio_Load(object sender, EventArgs e)
        {
            listJenisStudio = JenisStudio.BacaData("", "");

            if (listJenisStudio.Count > 0)
            {
                dataGridViewDaftarJenisStudio.DataSource = listJenisStudio;

                if (dataGridViewDaftarJenisStudio.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Hapus";
                    bCol.Name = "btnHapusGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJenisStudio.Columns.Add(bCol);
                }
            }
            else
            {
                dataGridViewDaftarJenisStudio.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void dataGridViewDaftarJenisStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarJenisStudio.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarJenisStudio.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarJenisStudio.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    JenisStudio c = new JenisStudio(idHapus, namaHapus);
                    Boolean hapus = JenisStudio.HapusData(c);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarJenisStudio_Load(btnKeluarDaftarJenisStudio, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listJenisStudio = JenisStudio.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listJenisStudio = JenisStudio.BacaData("nama", txtNilaiKriteria.Text);
                    break;
                case "Deskripsi":
                    listJenisStudio = JenisStudio.BacaData("deskripsi", txtNilaiKriteria.Text);
                    break;
            }

            if (listJenisStudio.Count > 0)
            {
                dataGridViewDaftarJenisStudio.DataSource = listJenisStudio;
            }
            else
            {
                dataGridViewDaftarJenisStudio.DataSource = null;
            }
        }

        private void btnKeluarDaftarJenisStudio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Deskripsi");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
