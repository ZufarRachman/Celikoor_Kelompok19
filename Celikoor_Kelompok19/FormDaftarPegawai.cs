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
    public partial class FormDaftarPegawai : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listPegawai = Pegawai.BacaData("", "");

            TampilDataGrid();

            if (!dataGridViewDaftarPegawai.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.Name = "btnHapus";
                colHapus.UseColumnTextForButtonValue = true;
                dataGridViewDaftarPegawai.Columns.Add(colHapus);
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listPegawai = Pegawai.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listPegawai = Pegawai.BacaData("nama", txtNilaiKriteria.Text);
                    break;
                case "Email":
                    listPegawai = Pegawai.BacaData("email", txtNilaiKriteria.Text);
                    break;
                case "Username":
                    listPegawai = Pegawai.BacaData("username", txtNilaiKriteria.Text);
                    break;
                case "Role":
                    listPegawai = Pegawai.BacaData("roles", txtNilaiKriteria.Text);
                    break;
            }

            TampilDataGrid();
        }

        private void btnKeluarDaftarPegawai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Email");
            cmbKriteria.Items.Add("Username");
            cmbKriteria.Items.Add("Role");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridViewDaftarPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarPegawai.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Pegawai p = new Pegawai(idHapus, namaHapus);
                    Boolean hapus = Pegawai.HapusData(p);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarPegawai_Load(btnKeluarDaftarPegawai, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnTambahPegawai_Click(object sender, EventArgs e)
        {
            FormTambahPegawai frm = new FormTambahPegawai();
            frm.Owner = this;
            frm.Show();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarPegawai.Columns.Clear();

            dataGridViewDaftarPegawai.Columns.Add("Id", "ID");
            dataGridViewDaftarPegawai.Columns.Add("Nama", "Nama");
            dataGridViewDaftarPegawai.Columns.Add("Email", "Email");
            dataGridViewDaftarPegawai.Columns.Add("Username", "Username");
            dataGridViewDaftarPegawai.Columns.Add("Roles", "Roles");

            dataGridViewDaftarPegawai.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["Roles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dataGridViewDaftarPegawai.AllowUserToAddRows = false;
            dataGridViewDaftarPegawai.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarPegawai.Rows.Clear();

            if (listPegawai.Count > 0)
            {
                foreach (Pegawai p in listPegawai)
                {
                    dataGridViewDaftarPegawai.Rows.Add(p.Id, p.Nama, p.Email, p.Username, p.Roles);
                }
            }
            else
            {
                dataGridViewDaftarPegawai.DataSource = null;
            }
        }
    }
}
