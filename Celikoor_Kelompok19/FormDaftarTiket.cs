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
    public partial class FormDaftarTiket : Form
    {
        public Pegawai operatorNama;
        public List<Ticket> listTicket = new List<Ticket>();
        public FormDaftarTiket()
        {
            InitializeComponent();
        }

        public void FormDaftarTiket_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listTicket = Ticket.BacaData("", "");

            TampilDataGrid();

            if (cmbKriteria.Items.Count <= 0)
                PopulateComboBox();
            else
                cmbKriteria.SelectedIndex = 0;
        }

        private void btnKeluarDaftarTiket_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            switch (cmbKriteria.Text)
            {
                case "InvoiceID":
                    listTicket = Ticket.BacaData("t.invoices_id", txtNilaiKriteria.Text);
                    break;
                case "Nomor Kursi":
                    listTicket = Ticket.BacaData("t.nomor_kursi", txtNilaiKriteria.Text);
                    break;                        
                case "Status Hadir":              
                    listTicket = Ticket.BacaData("t.status_hadir", txtNilaiKriteria.Text);
                    break;                        
                case "Operator":                  
                    listTicket = Ticket.BacaData("t.operator_id", txtNilaiKriteria.Text);
                    break;                        
                case "Harga":                     
                    listTicket = Ticket.BacaData("t.harga", txtNilaiKriteria.Text);
                    break;                        
                case "Jadwal Film":               
                    listTicket = Ticket.BacaData("t.jadwal_film_id", txtNilaiKriteria.Text);
                    break;                        
                case "Studio":                    
                    listTicket = Ticket.BacaData("t.studios_id", txtNilaiKriteria.Text);
                    break;                        
                case "Film":                      
                    listTicket = Ticket.BacaData("t.films_id", txtNilaiKriteria.Text);
                    break;
            }

            TampilDataGrid();
        }

        private void dataGridViewDaftarTiket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarTiket.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                string pID = dataGridViewDaftarTiket.CurrentRow.Cells["InvoiceID"].Value.ToString();
                string pNomorKursi = dataGridViewDaftarTiket.CurrentRow.Cells["NomorKursi"].Value.ToString();

                Ticket t = Ticket.AmbilData(pID, pNomorKursi);
                if (t != null)
                {
                    FormUpdateTiket frm = new FormUpdateTiket();
                    frm.Owner = this;

                    frm.textBoxID.Text = t.InvoiceId.Id.ToString();
                    frm.lblNomorKursi.Text = t.NomorKursi.ToString();
                    frm.textBoxHarga.Text = t.Harga.ToString();
                    frm.lblJadwalFilm.Text = t.JadwalFilmId.TanggalPemutaran.ToString() + " - " + t.JadwalFilmId.JamPemutaran.ToString();
                    if (t.StatusHadir == "1")
                        frm.comboBoxStatusHadir.Text = "Hadir";
                    else if (t.StatusHadir == "0")
                        frm.comboBoxStatusHadir.Text = "Belum Hadir";
                    frm.lblStudio.Text = t.StudioId.Nama.ToString();
                    frm.lblFilm.Text = t.FilmId.Judul.ToString();
                    frm.operatorNama = operatorNama;

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan pada data.");
                }
            }
            else if (e.ColumnIndex == dataGridViewDaftarTiket.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string invoiceIDHapus = dataGridViewDaftarTiket.CurrentRow.Cells["InvoiceID"].Value.ToString();
                string nomorKursiHapus = dataGridViewDaftarTiket.CurrentRow.Cells["NomorKursi"].Value.ToString();

                Invoice i = Invoice.AmbilDataByID(invoiceIDHapus);

                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + invoiceIDHapus + "-" + nomorKursiHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Ticket t = new Ticket(i, nomorKursiHapus);
                    Boolean hapus = Ticket.HapusData(t);
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        FormDaftarTiket_Load(btnKeluarDaftarTiket, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }

        private void PopulateComboBox()
        {
            cmbKriteria.Items.Add("InvoiceID");
            cmbKriteria.Items.Add("Nomor Kursi");
            cmbKriteria.Items.Add("Status Hadir");
            cmbKriteria.Items.Add("Operator");
            cmbKriteria.Items.Add("Harga");
            cmbKriteria.Items.Add("Jadwal Film");
            cmbKriteria.Items.Add("Studio");
            cmbKriteria.Items.Add("Film");
            cmbKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarTiket.Columns.Clear();

            dataGridViewDaftarTiket.Columns.Add("InvoiceID", "Invoice ID");
            dataGridViewDaftarTiket.Columns.Add("NomorKursi", "Nomor Kursi");
            dataGridViewDaftarTiket.Columns.Add("StatusHadir", "Status Hadir");
            dataGridViewDaftarTiket.Columns.Add("Operator", "Operator");
            dataGridViewDaftarTiket.Columns.Add("Harga", "Harga");
            dataGridViewDaftarTiket.Columns.Add("JadwalFilm", "Jadwal Film");
            dataGridViewDaftarTiket.Columns.Add("Studio", "Studio");
            dataGridViewDaftarTiket.Columns.Add("Film", "Film");

            dataGridViewDaftarTiket.Columns["InvoiceID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["NomorKursi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["StatusHadir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["Operator"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["JadwalFilm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["Studio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarTiket.Columns["Film"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarTiket.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDaftarTiket.AllowUserToAddRows = false;
            dataGridViewDaftarTiket.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarTiket.Rows.Clear();
            if (listTicket.Count > 0)
            {
                foreach (Ticket t in listTicket)
                {
                    dataGridViewDaftarTiket.Rows.Add(t.InvoiceId.Id, t.NomorKursi, t.StatusHadir, t.OperatorId.Nama, t.Harga,t.JadwalFilmId.TanggalPemutaran.ToString("dd/MM/yyyy") + " - " + t.JadwalFilmId.JamPemutaran, t.StudioId.Nama, t.FilmId.Judul);
                }
                if (!dataGridViewDaftarTiket.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                    colHapus.HeaderText = "Hapus";
                    colHapus.Text = "Hapus";
                    colHapus.Name = "btnHapus";
                    colHapus.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarTiket.Columns.Add(colHapus);
                }
                if (!dataGridViewDaftarTiket.Columns.Contains("btnUbah"))
                {
                    DataGridViewButtonColumn colUbah = new DataGridViewButtonColumn();
                    colUbah.HeaderText = "Ubah";
                    colUbah.Text = "Ubah";
                    colUbah.Name = "btnUbah";
                    colUbah.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarTiket.Columns.Add(colUbah);
                }
            }
            else
            {
                dataGridViewDaftarTiket.DataSource = null;
            }
        }
    }
}
