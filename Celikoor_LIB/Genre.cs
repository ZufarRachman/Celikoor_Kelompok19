using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Genre
    {
        string id;
        string nama;
        string deskripsi;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        #endregion

        #region Constructors
        public Genre(string id, string nama, string deskripsi)
        {
            Id = id;
            Nama = nama;
            Deskripsi = deskripsi;
        }

        public Genre(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Methods
        public static List<Genre> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from genres";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Genre> listGenre = new List<Genre>();
            while (hasil.Read() == true)
            {
                Genre g = new Genre(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());
                listGenre.Add(g);
            }
            return listGenre;
        }

        public static void TambahData(Genre g)
        {
            string sql = "insert into genres(id, nama, deskripsi) values(" + g.Id + ",'" + g.Nama.Replace("'", "\\'") + "','" + g.Deskripsi + "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static Boolean HapusData(Genre g)
        {
            string sql = "delete from genres where id=" + g.Id;
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

        public static string GenerateID()
        {
            string sql = "select max(id) from genres";

            string hasilID = "";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
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
        #endregion
    }
}
