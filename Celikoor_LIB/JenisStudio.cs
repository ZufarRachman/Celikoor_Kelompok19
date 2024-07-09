using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_LIB
{
    public class JenisStudio
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
        public JenisStudio(string id, string nama, string deskripsi)
        {
            Id = id;
            Nama = nama;
            Deskripsi = deskripsi;
        }

        public JenisStudio(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Methods
        public static List<JenisStudio> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from jenis_studios";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JenisStudio> listJenisStudio = new List<JenisStudio>();
            while (hasil.Read() == true)
            {
                JenisStudio g = new JenisStudio(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());
                listJenisStudio.Add(g);
            }
            return listJenisStudio;
        }

        public static void TambahData(JenisStudio g)
        {
            string sql = "insert into jenis_studios(id, nama, deskripsi) values(" + g.Id + ",'" + g.Nama.Replace("'", "\\'") + "','" + g.Deskripsi + "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static Boolean HapusData(JenisStudio g)
        {
            string sql = "delete from jenis_studios where id=" + g.Id;
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
            string sql = "select max(id) from jenis_studios";

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

        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
