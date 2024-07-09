using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Laporan
    {
        private string tahun;
        private string bulan;
        private string judul;
        private int total;
        private string nama;
        private string jenisStudio;

        #region Properties
        public string Tahun { get => tahun; set => tahun = value; }
        public string Bulan { get => bulan; set => bulan = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Total { get => total; set => total = value; }
        public string Nama { get => nama; set => nama = value; }
        public string JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        #endregion

        public static List<Laporan> Laporan1()
        {
            string sql = "SELECT year(jf.tanggal) as Tahun, monthname(jf.tanggal) as Bulan, f.judul as Judul, COUNT(t.films_id) as Total FROM tikets t " +
                         "INNER JOIN jadwal_films jf ON t.jadwal_film_id = jf.id " +
                         "INNER JOIN invoices i ON t.invoices_id = i.id " +
                         "INNER JOIN films f ON t.films_id = f.id " +
                         "WHERE i.status = 'TERBAYAR'AND t.status_hadir = 1 AND YEAR(jf.tanggal) = 2023 " +
                         "GROUP BY year(jf.tanggal), Bulan, Judul " +
                         "ORDER BY Total DESC;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Laporan> listLaporan = new List<Laporan>();
            while (hasil.Read())
            {
                string tahun = hasil.GetValue(0).ToString();
                string bulan = hasil.GetValue(1).ToString();
                string judul = hasil.GetValue(2).ToString();
                int total = int.Parse(hasil.GetValue(3).ToString());

                Laporan l = new Laporan();
                l.Tahun = tahun;
                l.Bulan = bulan;
                l.Judul = judul;
                l.Total = total;
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> Laporan2()
        {
            string sql = "select c.nama_cabang, js.nama as jenis_studio, sum(t.harga) as pemasukkan from cinemas c " +
                         "inner join studios s on c.id = s.cinemas_id " +
                         "inner join tikets t on t.studios_id = s.id " +
                         "inner join invoices i on i.id = t.invoices_id " +
                         "inner join jenis_studios js on js.id = s.jenis_studios_id " +
                         "where i.status = 'TERBAYAR' " +
                         "group by c.nama_cabang, js.nama";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Laporan> listLaporan = new List<Laporan>();
            while (hasil.Read())
            {
                string namaCabang = hasil.GetValue(0).ToString();
                string jenisStudio = hasil.GetValue(1).ToString();
                int total = int.Parse(hasil.GetValue(2).ToString());

                Laporan l = new Laporan();
                l.Nama = namaCabang;
                l.JenisStudio = jenisStudio;
                l.Total = total;
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> Laporan3()
        {
            string sql = "select f.judul, count(t.status_hadir) as jumlah_tidak_hadir from tikets t " +
                         "inner join films f on t.films_id = f.id " +
                         "where t.status_hadir = 0 " +
                         "GROUP BY f.id, f.judul " +
                         "ORDER BY f.id DESC;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Laporan> listLaporan = new List<Laporan>();
            while (hasil.Read())
            {
                string judul = hasil.GetValue(0).ToString();
                int jumlah = int.Parse(hasil.GetValue(1).ToString());

                Laporan l = new Laporan();
                l.Judul = judul;
                l.Total = jumlah;
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> Laporan5()
        {
            string sql = "select k.nama, count(t.invoices_id) as jumlah_menonton from konsumens k " +
                         "inner join invoices i on i.konsumens_id = k.id " +
                         "inner join tikets t on i.id = t.invoices_id " +
                         "inner join films f on t.films_id = f.id " +
                         "inner join genre_film gf on f.id = gf.films_id " +
                         "inner join genres g on g.id = gf.genres_id " +
                         "where g.nama = 'Comedy' and t.status_hadir = 1 " +
                         "group by k.nama";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Laporan> listLaporan = new List<Laporan>();
            while (hasil.Read())
            {
                string namaKonsumen = hasil.GetValue(0).ToString();
                int jumlah = int.Parse(hasil.GetValue(1).ToString());

                Laporan l = new Laporan();
                l.Nama = namaKonsumen;
                l.Total = jumlah;
                listLaporan.Add(l);
            }
            return listLaporan;
        }
    }
}
