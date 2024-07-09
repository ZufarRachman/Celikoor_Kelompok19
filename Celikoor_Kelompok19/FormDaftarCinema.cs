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
    public partial class FormDaftarCinema : Form
    {
        public List<Cinema> listCinema = new List<Cinema>();

        public FormDaftarCinema()
        {
            InitializeComponent();
        }

        public void FormDaftarCinema_Load(object sender, EventArgs e)
        {
            listCinema = Cinema.BacaData("", "");

            if(listCinema.Count > 0)
            {
                dataGridViewDaftarCinema.DataSource = listCinema;

                if (dataGridViewDaftarCinema.ColumnCount == 5)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Hapus";
                    bCol.Name = "btnHapusGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarCinema.Columns.Add(bCol);
                }
            }
            else
            {
                dataGridViewDaftarCinema.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch(cmbKriteria.Text)
            {
                case "ID":
                    listCinema = Cinema.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama Cabang":
                    listCinema = Cinema.BacaData("nama_cabang", txtNilaiKriteria.Text);
                    break;
                case "Alamat":
                    listCinema = Cinema.BacaData("alamat", txtNilaiKriteria.Text);
                    break;
                case "Tanggal Buka":
                    listCinema = Cinema.BacaData("tgl_dibuka", txtNilaiKriteria.Text);
                    break;
                case "Kota":
                    listCinema = Cinema.BacaData("kota", txtNilaiKriteria.Text);
                    break;
            }

            if (listCinema.Count > 0)
            {
                dataGridViewDaftarCinema.DataSource = listCinema;
            }
            else
            {
                dataGridViewDaftarCinema.DataSource = null;
            }
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama Cabang");
            cmbKriteria.Items.Add("Alamat");
            cmbKriteria.Items.Add("Tanggal Buka");
            cmbKriteria.Items.Add("Kota");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnKeluarDaftarCinema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambahCinema_Click(object sender, EventArgs e)
        {
            FormTambahCinema frm = new FormTambahCinema();
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridViewDaftarCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridViewDaftarCinema.Columns["btnHapusGrid"].Index && e.RowIndex>=0)
            {
                string idHapus = dataGridViewDaftarCinema.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarCinema.CurrentRow.Cells["NamaCabang"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(hasil == DialogResult.Yes) 
                {
                    Cinema c = new Cinema(idHapus, namaHapus);
                    Boolean hapus = Cinema.HapusData(c);
                    if(hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarCinema_Load(btnKeluarDaftarCinema, e);
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
