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
    public partial class FormDaftarKelompok : Form
    {
        public List<Kelompok> listKelompok = new List<Kelompok>();

        public FormDaftarKelompok()
        {
            InitializeComponent();
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listKelompok = Kelompok.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listKelompok = Kelompok.BacaData("nama", txtNilaiKriteria.Text);
                    break;
            }

            if (listKelompok.Count > 0)
            {
                dataGridViewDaftarKelompok.DataSource = listKelompok;
            }
            else
            {
                dataGridViewDaftarKelompok.DataSource = null;
            }
        }

        public void FormDaftarKelompok_Load(object sender, EventArgs e)
        {
            listKelompok = Kelompok.BacaData("", "");

            if (listKelompok.Count > 0)
            {
                dataGridViewDaftarKelompok.DataSource = listKelompok;

                if (dataGridViewDaftarKelompok.ColumnCount == 2)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Hapus";
                    bCol.Name = "btnHapusGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarKelompok.Columns.Add(bCol);
                }
            }
            else
            {
                dataGridViewDaftarKelompok.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void btnKeluarDaftarKelompok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridViewDaftarKelompok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarKelompok.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarKelompok.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarKelompok.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Kelompok k = new Kelompok(idHapus, namaHapus);
                    Boolean hapus = Kelompok.HapusData(k);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarKelompok_Load(btnKeluarDaftarKelompok, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnTambahKelompok_Click(object sender, EventArgs e)
        {
            FormTambahKelompok frm = new FormTambahKelompok();
            frm.Owner = this;
            frm.Show();
        }
    }
}
