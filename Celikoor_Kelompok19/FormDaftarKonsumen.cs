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
    public partial class FormDaftarKonsumen : Form
    {
        public List<Konsumen> listKonsumen = new List<Konsumen>();

        public FormDaftarKonsumen()
        {
            InitializeComponent();
        }

        public void FormDaftarKonsumen_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listKonsumen = Konsumen.BacaData("", "");

            TampilDataGrid();

            if (!dataGridViewDaftarKonsumen.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.Name = "btnHapus";
                colHapus.UseColumnTextForButtonValue = true;
                dataGridViewDaftarKonsumen.Columns.Add(colHapus);
            }
            if (!dataGridViewDaftarKonsumen.Columns.Contains("btnUbah"))
            {
                DataGridViewButtonColumn colUbah = new DataGridViewButtonColumn();
                colUbah.HeaderText = "Aksi";
                colUbah.Text = "Ubah";
                colUbah.Name = "btnHapus";
                colUbah.UseColumnTextForButtonValue = true;
                dataGridViewDaftarKonsumen.Columns.Add(colUbah);
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
                    listKonsumen = Konsumen.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Nama":
                    listKonsumen = Konsumen.BacaData("nama", txtNilaiKriteria.Text);
                    break;
                case "Email":
                    listKonsumen = Konsumen.BacaData("email", txtNilaiKriteria.Text);
                    break;
                case "No. HP":
                    listKonsumen = Konsumen.BacaData("no_hp", txtNilaiKriteria.Text);
                    break;
                case "Gender":
                    listKonsumen = Konsumen.BacaData("gender", txtNilaiKriteria.Text);
                    break;
                case "Tanggal Lahir":
                    listKonsumen = Konsumen.BacaData("tgl_lahir", txtNilaiKriteria.Text);
                    break;
                case "Saldo":
                    listKonsumen = Konsumen.BacaData("saldo", txtNilaiKriteria.Text);
                    break;
                case "Username":
                    listKonsumen = Konsumen.BacaData("username", txtNilaiKriteria.Text);
                    break;
            }

            TampilDataGrid();
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Nama");
            cmbKriteria.Items.Add("Email");
            cmbKriteria.Items.Add("No. HP");
            cmbKriteria.Items.Add("Gender");
            cmbKriteria.Items.Add("Tanggal Lahir");
            cmbKriteria.Items.Add("Saldo");
            cmbKriteria.Items.Add("Username");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnKeluarDaftarKonsumen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDaftarKonsumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarKonsumen.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarKonsumen.CurrentRow.Cells["ID"].Value.ToString();

                Konsumen k = Konsumen.AmbilDataByID(pID);
                if (k != null)
                {
                    FormUpdateKonsumen frm = new FormUpdateKonsumen();
                    frm.Owner = this;
                    frm.textBoxID.Text = k.Id.ToString();
                    frm.textBoxNama.Text = k.Nama.ToString();
                    frm.textBoxEmail.Text = k.Email.ToString();
                    frm.textBoxNoHp.Text = k.NoHp.ToString();
                    frm.comboBoxGender.Text = k.Gender.ToString();
                    frm.dateTimePickerTglLahir.Value = DateTime.Parse(k.TglLahir.ToString());
                    frm.textBoxSaldo.Text = k.Saldo.ToString();
                    frm.textBoxUsername.Text = k.Username.ToString();
                    frm.textBoxPassword.Text = k.Password.ToString();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarKonsumen.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Konsumen k = new Konsumen(idHapus, namaHapus);
                    Boolean hapus = Konsumen.HapusData(k);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarKonsumen_Load(btnKeluarDaftarKonsumen, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnTambahKonsumen_Click(object sender, EventArgs e)
        {
            FormTambahKonsumen frm = new FormTambahKonsumen();
            frm.Owner = this;
            frm.Show();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarKonsumen.Columns.Clear();

            dataGridViewDaftarKonsumen.Columns.Add("Id", "ID");
            dataGridViewDaftarKonsumen.Columns.Add("Nama", "Nama");
            dataGridViewDaftarKonsumen.Columns.Add("Email", "Email");
            dataGridViewDaftarKonsumen.Columns.Add("NoHp", "No Hp");
            dataGridViewDaftarKonsumen.Columns.Add("Gender", "Gender");
            dataGridViewDaftarKonsumen.Columns.Add("TglLahir", "Tanggal Lahir");
            dataGridViewDaftarKonsumen.Columns.Add("Saldo", "Saldo");
            dataGridViewDaftarKonsumen.Columns.Add("Username", "Username");

            dataGridViewDaftarKonsumen.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["NoHp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["TglLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["Saldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dataGridViewDaftarKonsumen.AllowUserToAddRows = false;
            dataGridViewDaftarKonsumen.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarKonsumen.Rows.Clear();

            if (listKonsumen.Count > 0)
            {
                foreach (Konsumen k in listKonsumen)
                {
                    dataGridViewDaftarKonsumen.Rows.Add(k.Id, k.Nama, k.Email, k.NoHp, k.Gender, k.TglLahir, k.Saldo, k.Username);
                }
            }
            else
            {
                dataGridViewDaftarKonsumen.DataSource = null;
            }
        }
    }
}
