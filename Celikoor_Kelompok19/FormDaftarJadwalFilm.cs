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
    public partial class FormDaftarJadwalFilm : Form
    {
        public List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();
        public FormDaftarJadwalFilm()
        {
            InitializeComponent();
        }

        public void FormDaftarJadwalFilm_Load(object sender, EventArgs e)
        {
            listJadwalFilm = JadwalFilm.BacaData("", "");

            if (listJadwalFilm.Count > 0)
            {
                dataGridViewDaftarJadwalFilm.DataSource = listJadwalFilm;

                if (dataGridViewDaftarJadwalFilm.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bCol = new DataGridViewButtonColumn();
                    bCol.HeaderText = "Aksi";
                    bCol.Text = "Ubah";
                    bCol.Name = "btnUbahGrid";
                    bCol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJadwalFilm.Columns.Add(bCol);

                    DataGridViewButtonColumn bCol2 = new DataGridViewButtonColumn();
                    bCol2.HeaderText = "Aksi";
                    bCol2.Text = "Hapus";
                    bCol2.Name = "btnHapusGrid";
                    bCol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJadwalFilm.Columns.Add(bCol2);
                }
            }
            else
            {
                dataGridViewDaftarJadwalFilm.DataSource = null;
            }

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void dataGridViewDaftarJadwalFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarJadwalFilm.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarJadwalFilm.CurrentRow.Cells["ID"].Value.ToString();

                JadwalFilm jf = JadwalFilm.AmbilDataByID("id",pID);
                if (jf != null)
                {
                    FormUpdateJadwalFilm frm = new FormUpdateJadwalFilm();
                    frm.Owner = this;
                    frm.textBoxID.Text = jf.Id.ToString();
                    frm.dateTimePickerTglPemutaran.Value = DateTime.Parse(jf.TanggalPemutaran.ToString());
                    frm.comboBoxJamPemutaran.Text = jf.JamPemutaran.ToString();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarJadwalFilm.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewDaftarJadwalFilm.CurrentRow.Cells["Id"].Value.ToString();
                DateTime tanggalHapus = DateTime.Parse(dataGridViewDaftarJadwalFilm.CurrentRow.Cells["TanggalPemutaran"].Value.ToString());

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + idHapus + "-" + tanggalHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    JadwalFilm jf = new JadwalFilm(idHapus, tanggalHapus);
                    Boolean hapus = JadwalFilm.HapusDataByID(jf);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarJadwalFilm_Load(btnKeluarDaftarJadwalFilm, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void btnKeluarDaftarJadwalFilm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambahJadwalFilm_Click(object sender, EventArgs e)
        {
            FormTambahJadwalFilm frm = new FormTambahJadwalFilm();
            frm.Owner = this;
            frm.Show();
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            switch (cmbKriteria.Text)
            {
                case "ID":
                    listJadwalFilm = JadwalFilm.BacaData("id", txtNilaiKriteria.Text);
                    break;
                case "Tanggal Pemutaran":
                    listJadwalFilm = JadwalFilm.BacaData("tanggal", txtNilaiKriteria.Text);
                    break;
                case "Jam Pemutaran":
                    listJadwalFilm = JadwalFilm.BacaData("jam_pemutaran", txtNilaiKriteria.Text);
                    break;
            }

            if (listJadwalFilm.Count > 0)
            {
                dataGridViewDaftarJadwalFilm.DataSource = listJadwalFilm;
            }
            else
            {
                dataGridViewDaftarJadwalFilm.DataSource = null;
            }
        }
        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("ID");
            cmbKriteria.Items.Add("Tanggal Pemutaran");
            cmbKriteria.Items.Add("Jam Pemutaran");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
