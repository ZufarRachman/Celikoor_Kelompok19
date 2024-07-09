using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Cinema
    {
        string id;
        string namaCabang;
        string alamat;
        DateTime tgl_buka;
        string kota;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string NamaCabang { get => namaCabang; set => namaCabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tgl_buka { get => tgl_buka; set => tgl_buka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region Constructors
        public Cinema(string id, string namaCabang, string alamat, DateTime tgl_buka, string kota)
        {
            Id = id;
            NamaCabang = namaCabang;
            Alamat = alamat;
            Tgl_buka = tgl_buka;
            Kota = kota;
        }

        public Cinema(string id, string namaCabang)
        {
            Id = id;
            NamaCabang = namaCabang;
        }

        public Cinema(string namaCabang)
        {
            NamaCabang = namaCabang;
        }


        #endregion

        #region Methods
        public static List<Cinema> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from cinemas";

            if(kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cinema> listCinema = new List<Cinema>();
            while(hasil.Read() == true) 
            {
                Cinema c = new Cinema(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), DateTime.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString());
                listCinema.Add(c);
            }
            return listCinema;
        }

        public static void TambahData(Cinema c)
        {
            string sql = "insert into cinemas(id, nama_cabang, alamat, tgl_dibuka, kota) values (" + c.Id + ",'" + c.NamaCabang.Replace("'","\\'") + "','" + c.Alamat + "','" + c.Tgl_buka.ToString("yyyy-MM-dd") + "','" + c.Kota + "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Cinema c)
        {
            string sql = "delete from cinemas where id=" + c.Id;
            int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(sql);
            if(jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GenerateID()
        {
            string sql = "select max(id) from cinemas";

            string hasilID = "";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if(hasil.Read() == true) 
            {
                int IDTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilID = IDTerbaru.ToString();
            }
            else
            {
                hasilID = "1";
            }
            return hasilID;
        }

        public static Cinema AmbilData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from cinemas where " + kriteria + " like '%" + nilaiKriteria + "%'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Cinema c = new Cinema(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), DateTime.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString());
                return c;
            }
            else
            {
                return null;
            }
        }

        public List<Cinema> GetCinemaNames(DateTime date, string filmTitle)
        {
            string sql = "SELECT cinemas.nama_cabang FROM jadwal_films INNER JOIN sesi_films ON jadwal_films.id = sesi_films.jadwal_film_id INNER JOIN films ON sesi_films.films_id=films.id INNER JOIN studios ON sesi_films.studios_id=studios.id INNER JOIN cinemas ON studios.cinemas_id=cinemas.id WHERE jadwal_films.tanggal = " + date + " AND films.judul = " + filmTitle;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cinema> listCinema = new List<Cinema>();
            while (hasil.Read() == true)
            {
                Cinema c = new Cinema(hasil.GetValue(0).ToString());
                listCinema.Add(c);
            }
            return listCinema;
        }

        public override string ToString()
        {
            return NamaCabang;
        }
        #endregion
    }
}
