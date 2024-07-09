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
    public partial class FormMain : Form
    {
        public Pegawai pegawai;
        public Konsumen konsumen;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;
            try
            {
                Koneksi con = new Koneksi();

                FormLogin frm = new FormLogin();
                frm.Owner = this;
                

                if(frm.ShowDialog() == DialogResult.OK)
                {
                    if(konsumen == null)
                    {
                        lblKodePengguna.Text = pegawai.Roles;
                        lblNamaPengguna.Text = pegawai.Nama;
                    }
                    else if(pegawai == null)
                    {
                        lblKodePengguna.Text = konsumen.Id;
                        lblNamaPengguna.Text = konsumen.Nama;
                    }
                    SetHakAkses();
                }
                else
                {
                    MessageBox.Show("Gagal login");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan Kesalahan : " + ex.Message);
            }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarCinema"];

            if(form == null)
            {
                FormDaftarCinema formDaftarCinema = new FormDaftarCinema();
                formDaftarCinema.MdiParent = this;
                formDaftarCinema.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKonsumen"];

            if (form == null)
            {
                FormDaftarKonsumen formDaftarKonsumen = new FormDaftarKonsumen();
                formDaftarKonsumen.MdiParent = this;
                formDaftarKonsumen.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPegawai"];

            if (form == null)
            {
                FormDaftarPegawai formDaftarPegawai = new FormDaftarPegawai();
                formDaftarPegawai.MdiParent = this;
                formDaftarPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKelompok"];

            if (form == null)
            {
                FormDaftarKelompok formDaftarKelompok = new FormDaftarKelompok();
                formDaftarKelompok.MdiParent = this;
                formDaftarKelompok.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarAktors"];

            if (form == null)
            {
                FormDaftarAktors formDaftarAktors = new FormDaftarAktors();
                formDaftarAktors.MdiParent = this;
                formDaftarAktors.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarGenre"];

            if (form == null)
            {
                FormDaftarGenre formDaftarGenre = new FormDaftarGenre();
                formDaftarGenre.MdiParent = this;
                formDaftarGenre.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormHalamanProfileKonsumen"];

            if (form == null)
            {
                FormHalamanProfileKonsumen formHalamanProfileKonsumen = new FormHalamanProfileKonsumen();
                formHalamanProfileKonsumen.MdiParent = this;
                formHalamanProfileKonsumen.profile = konsumen;
                formHalamanProfileKonsumen.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
        private void SetHakAkses()
        {
            if(pegawai != null)
            {
                switch (pegawai.Roles)
                {
                    case "ADMIN":
                        masterToolStripMenuItem.Visible = true;
                        cinemaToolStripMenuItem.Visible = true;
                        studioToolStripMenuItem.Visible = true;
                        jenisStudioToolStripMenuItem.Visible = true;
                        genreToolStripMenuItem.Visible = true;
                        kelompokToolStripMenuItem.Visible = true;
                        aktorToolStripMenuItem.Visible = true;
                        pegawaiToolStripMenuItem.Visible = true;
                        konsumenToolStripMenuItem.Visible = true;
                        filmToolStripMenuItem1.Visible = true;
                        jadwalFilmToolStripMenuItem.Visible = true;
                        invoiceToolStripMenuItem.Visible = true;
                        ticketToolStripMenuItem.Visible = true;
                        laporanToolStripMenuItem.Visible = true;
                        penjadwalanFilmToolStripMenuItem.Visible = true;
                        break;
                    case "KASIR":
                        masterToolStripMenuItem.Visible = true;
                        invoiceToolStripMenuItem.Visible = true;
                        break;
                    case "OPERATOR":
                        masterToolStripMenuItem.Visible = true;
                        tiketToolStripMenuItem.Visible = true;
                        break;
                }
            }
            else if(konsumen != null)
            {
                ticketToolStripMenuItem.Visible = true;
                profileToolStripMenuItem.Visible = true;
            }
        }

        private void jenisStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJenisStudio"];

            if (form == null)
            {
                FormDaftarJenisStudio formDaftarJenisStudio = new FormDaftarJenisStudio();
                formDaftarJenisStudio.MdiParent = this;
                formDaftarJenisStudio.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarStudio"];

            if (form == null)
            {
                FormDaftarStudio formDaftarStudio = new FormDaftarStudio();
                formDaftarStudio.MdiParent = this;
                formDaftarStudio.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void filmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarFilm"];

            if (form == null)
            {
                FormDaftarFilm formDaftarFilm = new FormDaftarFilm();
                formDaftarFilm.MdiParent = this;
                formDaftarFilm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void jadwalFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJadwalFilm"];

            if (form == null)
            {
                FormDaftarJadwalFilm formDaftarJadwalFilm = new FormDaftarJadwalFilm();
                formDaftarJadwalFilm.MdiParent = this;
                formDaftarJadwalFilm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarInvoice"];

            if (form == null)
            {
                FormDaftarInvoice formDaftarInvoice = new FormDaftarInvoice();
                formDaftarInvoice.MdiParent = this;
                formDaftarInvoice.kasir = pegawai;
                formDaftarInvoice.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjadwalanFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPenjadwalanFilm"];

            if (form == null)
            {
                FormPenjadwalanFilm formPenjadwalanFilm = new FormPenjadwalanFilm();
                formPenjadwalanFilm.MdiParent = this;
                formPenjadwalanFilm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void buyTicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPemesananTiket"];

            if (form == null)
            {
                FormPemesananTiket formPemesananTiket = new FormPemesananTiket();
                formPemesananTiket.MdiParent = this;
                formPemesananTiket.konsumen = konsumen;
                formPemesananTiket.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarTiket"];

            if (form == null)
            {
                FormDaftarTiket formDaftarTiket = new FormDaftarTiket();
                formDaftarTiket.MdiParent = this;
                formDaftarTiket.operatorNama = pegawai;
                formDaftarTiket.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporan"];

            if (form == null)
            {
                FormLaporan formLaporan = new FormLaporan();
                formLaporan.MdiParent = this;
                formLaporan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
