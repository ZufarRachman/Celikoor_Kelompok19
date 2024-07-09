using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Ticket
    {
        Invoice invoiceId;
        string nomorKursi;
        string statusHadir;
        Pegawai operatorId;
        double harga;
        JadwalFilm jadwalFilmId;
        Studio studioId;
        Film filmId;

        #region Properties
        public Invoice InvoiceId { get => invoiceId; set => invoiceId = value; }
        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public string StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai OperatorId { get => operatorId; set => operatorId = value; }
        public double Harga { get => harga; set => harga = value; }
        public JadwalFilm JadwalFilmId { get => jadwalFilmId; set => jadwalFilmId = value; }
        public Studio StudioId { get => studioId; set => studioId = value; }
        public Film FilmId { get => filmId; set => filmId = value; }
        #endregion

        #region Constructors
        public Ticket(Invoice invoiceId, string nomorKursi, string statusHadir, Pegawai operatorId, double harga, JadwalFilm jadwalFilmId, Studio studioId, Film filmId)
        {
            InvoiceId = invoiceId;
            NomorKursi = nomorKursi;
            StatusHadir = statusHadir;
            OperatorId = operatorId;
            Harga = harga;
            JadwalFilmId = jadwalFilmId;
            StudioId = studioId;
            FilmId = filmId;
        }
        public Ticket(Invoice invoiceId, string nomorKursi, string statusHadir, double harga, JadwalFilm jadwalFilmId, Studio studioId, Film filmId)
        {
            InvoiceId = invoiceId;
            NomorKursi = nomorKursi;
            StatusHadir = statusHadir;
            Harga = harga;
            JadwalFilmId = jadwalFilmId;
            StudioId = studioId;
            FilmId = filmId;
        }

        public Ticket(string statusHadir, Pegawai operatorId, double harga, string nomorKursi, Invoice invoice)
        {
            StatusHadir = statusHadir;
            OperatorId = operatorId;
            Harga = harga;
            NomorKursi = nomorKursi;
            InvoiceId = invoice;
        }

        public Ticket(Invoice invoiceId, string nomorKursi)
        {
            InvoiceId = invoiceId;
            NomorKursi = nomorKursi;
        }
        #endregion

        #region Methods
        public static List<string> GetKursi(string date, string filmTitle, string cinemaTitle, string studioName)
        {
            string sql = "SELECT tikets.nomor_kursi FROM tikets INNER JOIN films ON tikets.films_id = films.id INNER JOIN studios ON tikets.studios_id=studios.id INNER JOIN jadwal_films ON tikets.jadwal_film_id = jadwal_films.id INNER JOIN cinemas ON studios.cinemas_id=cinemas.id WHERE films.judul = '" + filmTitle + "' AND jadwal_films.tanggal = '" + date + "' AND cinemas.nama_cabang = '" + cinemaTitle + "' AND studios.nama = '" + studioName + "'";
            Console.WriteLine(sql);

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<string> listKursiTerpilih = new List<string>();
            while (hasil.Read() == true)
            {
                listKursiTerpilih.Add(hasil.GetValue(0).ToString());
            }
            return listKursiTerpilih;
        }

        public static List<Ticket> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT t.*, p.nama FROM tikets t " +
                "left join pegawais p on p.id = t.operator_id " +
                "left join jadwal_films jf on jf.id=jadwal_film_id " +
                "left join studios s on s.id = t.studios_id " +
                "left join films f on f.id = t.films_id";

            if (kriteria != "")
            {
                sql = "SELECT t.*, p.nama FROM tikets t " +
                "left join pegawais p on p.id = t.operator_id " +
                "left join jadwal_films jf on jf.id=jadwal_film_id " +
                "left join studios s on s.id = t.studios_id " +
                "left join films f on f.id = t.films_id " +
                "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Ticket> listTicket = new List<Ticket>();
            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(3).ToString(), hasil.GetValue(8).ToString());
                Invoice i = Invoice.AmbilDataByID(hasil.GetValue(0).ToString());
                JadwalFilm jf = JadwalFilm.AmbilDataByID("id", hasil.GetValue(5).ToString());
                Studio s = Studio.AmbilDataByID("s.id", hasil.GetValue(6).ToString());
                Film f = Film.AmbilDataByID("f.id", hasil.GetValue(7).ToString());

                Ticket t = new Ticket(i, hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(),p, double.Parse(hasil.GetValue(4).ToString()), jf, s, f);
                listTicket.Add(t);
            }
            return listTicket;
        }

        public static void UbahData(Ticket t)
        {
            string sql = "update tikets set status_hadir = " + t.StatusHadir + ", operator_id=" + t.OperatorId.Id + ", harga=" + t.Harga + " where invoices_id =" + t.InvoiceId.Id + " and nomor_kursi ='" + t.NomorKursi + "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Ticket t)
        {
            string sql = "delete from tikets where invoices_id =" + t.InvoiceId.Id + " and nomor_kursi ='" + t.NomorKursi + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Ticket AmbilData(string invoicesId, string nomorKursi)
        {
            string sql = "SELECT t.*, p.nama FROM tikets t " +
                "left join pegawais p on p.id = t.operator_id " +
                "left join jadwal_films jf on jf.id=jadwal_film_id " +
                "left join studios s on s.id = t.studios_id " +
                "left join films f on f.id = t.films_id " +
                "where invoices_id = " + invoicesId + " and nomor_kursi='" + nomorKursi + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(3).ToString(), hasil.GetValue(8).ToString());
                Invoice i = Invoice.AmbilDataByID(hasil.GetValue(0).ToString());
                JadwalFilm jf = JadwalFilm.AmbilDataByID("id", hasil.GetValue(5).ToString());
                Studio s = Studio.AmbilDataByID("s.id", hasil.GetValue(6).ToString());
                Film f = Film.AmbilDataByID("f.id", hasil.GetValue(7).ToString());

                Ticket t = new Ticket(i, hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), p, double.Parse(hasil.GetValue(4).ToString()), jf, s, f);

                return t;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
