using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor
    {
        string id;
        string nama;
        DateTime tglLahir;
        string gender;
        string negaraAsal;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }
        #endregion

        #region Constructors
        public Aktor(string id, string nama, DateTime tglLahir, string gender, string negaraAsal)
        {
            Id = id;
            Nama = nama;
            TglLahir = tglLahir;
            Gender = gender;
            NegaraAsal = negaraAsal;
        }

        public Aktor(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Methods
        public static List<Aktor> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from aktors";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Aktor> listAktor = new List<Aktor>();
            while (hasil.Read() == true)
            {
                Aktor a = new Aktor(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), DateTime.Parse(hasil.GetValue(2).ToString()), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                listAktor.Add(a);
            }
            return listAktor;
        }

        public static void TambahData(Aktor a)
        {
            string sql = "insert into aktors(id, nama, tgl_lahir, gender, negara_asal) values(" + a.Id + " ,'" + a.Nama.Replace("'", "\\'") + "','" + a.TglLahir.ToString("yyyy-MM-dd") + "','" + a.Gender + "','" + a.NegaraAsal + "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahData(Aktor a)
        {
            string sql = "update aktors set nama='" + a.Nama.Replace("'", "\\'") + "', tgl_lahir='" + a.TglLahir.ToString("yyyy-MM-dd") + "', gender='" + a.Gender + "', negara_asal='" + a.NegaraAsal + "' where id=" + a.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Aktor a)
        {
            string sql = "delete from aktors where id=" + a.Id;
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
            string sql = "select max(id) from aktors";

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

        public static Aktor AmbilData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from aktors where " + kriteria + " like '%" + nilaiKriteria + "%'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if(hasil.Read() == true)
            {
                Aktor a = new Aktor(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), DateTime.Parse(hasil.GetValue(2).ToString()), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                return a;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
