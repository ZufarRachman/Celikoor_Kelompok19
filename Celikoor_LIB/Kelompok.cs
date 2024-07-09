using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Kelompok
    {
        string id;
        string nama;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Constructors
        public Kelompok(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Methods
        public static List<Kelompok> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from kelompoks";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Kelompok> listKelompok = new List<Kelompok>();
            while (hasil.Read() == true)
            {
                Kelompok k = new Kelompok(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listKelompok.Add(k);
            }
            return listKelompok;
        }

        public static void TambahData(Kelompok c)
        {
            string sql = "insert into kelompoks(id, nama) values (" + c.Id + ",'" + c.Nama.Replace("'", "\\'") +  "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Kelompok c)
        {
            string sql = "delete from kelompoks where id=" + c.Id;
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
            string sql = "select max(id) from kelompoks";

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
