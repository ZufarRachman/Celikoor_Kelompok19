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
    public partial class FormDaftarGenre : Form
    {
        public List<Genre> listGenre = new List<Genre>();

        public FormDaftarGenre()
        {
            InitializeComponent();
        }

        public void FormDaftarGenre_Load(object sender, EventArgs e)
        {
            listGenre = Genre.BacaData("", "");

            if (listGenre.Count > 0)
            {
                dataGridViewDaftarGenre.DataSource = listGenre;

                if (dataGridViewDaftarGenre.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Hapus";
                    bCol.Name = "btnHapusGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarGenre.Columns.Add(bCol);
                }
            }
            else
            {
                dataGridViewDaftarGenre.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void btnKeluarDaftarGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listGenre = Genre.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listGenre = Genre.BacaData("nama", txtNilaiKriteria.Text);
                    break;
                case "Deskripsi":
                    listGenre = Genre.BacaData("deskripsi", txtNilaiKriteria.Text);
                    break;
            }

            if (listGenre.Count > 0)
            {
                dataGridViewDaftarGenre.DataSource = listGenre;
            }
            else
            {
                dataGridViewDaftarGenre.DataSource = null;
            }
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Deskripsi");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridViewDaftarGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarGenre.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarGenre.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarGenre.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Genre c = new Genre(idHapus, namaHapus);
                    Boolean hapus = Genre.HapusData(c);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarGenre_Load(btnKeluarDaftarGenre, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnTambahGenre_Click(object sender, EventArgs e)
        {
            FormTambahGenre frm = new FormTambahGenre();
            frm.Owner = this;
            frm.Show();
        }
    }
}
