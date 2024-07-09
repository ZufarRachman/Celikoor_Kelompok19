using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        string id;
        string nama;
        string email;
        string noHp;
        string gender;
        DateTime tglLahir;
        double saldo;
        string username;
        string password;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region Constructors
        public Konsumen(string id, string nama, string email, string noHp, string gender, DateTime tglLahir, double saldo, string username)
        {
            Id = id;
            Nama = nama;
            Email = email;
            NoHp = noHp;
            Gender = gender;
            TglLahir = tglLahir;
            Saldo = saldo;
            Username = username;
        }

        public Konsumen(string id, string nama, string email, string noHp, string gender, DateTime tglLahir, double saldo, string username, string password)
        {
            Id = id;
            Nama = nama;
            Email = email;
            NoHp = noHp;
            Gender = gender;
            TglLahir = tglLahir;
            Saldo = saldo;
            Username = username;
            Password = password;
        }

        public Konsumen(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        #endregion

        #region Methods
        public static List<Konsumen> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, nama, email, no_hp, gender, tgl_lahir, saldo, username from konsumens";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Konsumen> listKonsumen = new List<Konsumen>();
            while (hasil.Read() == true)
            {
                Konsumen k = new Konsumen(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), DateTime.Parse(hasil.GetValue(5).ToString()), double.Parse(hasil.GetValue(6).ToString()), hasil.GetValue(7).ToString());
                listKonsumen.Add(k);
            }
            return listKonsumen;
        }
        public static void TambahData(Konsumen k)
        {
            string sql = "insert into konsumens(id, nama, email, no_hp, gender, tgl_lahir, saldo, username, password) values (" + k.Id + ",'" + k.Nama.Replace("'", "\\'") + "','" + k.Email + "','" + k.NoHp + "','" + k.Gender + "','" + k.TglLahir.ToString("yyyy-MM-dd") + "'," + k.Saldo + ",'" + k.Username + "','" + k.Password + "')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahData(Konsumen k)
        {
            string sql = "update konsumens set nama='" + k.Nama.Replace("'", "\\'") + "', email='" + k.Email + "', no_hp='" + k.NoHp + "', gender='" + k.Gender + "', tgl_lahir='" + k.TglLahir.ToString("yyyy-MM-dd") + "', saldo= " + k.Saldo + ",username='" + k.Username + "', password='" + k.Password + "' where id=" + k.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Konsumen k)
        {
            string sql = "delete from konsumens where id=" + k.Id;
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
            string sql = "select max(id) from konsumens";

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

        public static Konsumen AmbilDataByID(string id)
        {
            string sql = "select * from konsumens where id=" + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Konsumen a = new Konsumen(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), DateTime.Parse(hasil.GetValue(5).ToString()), double.Parse(hasil.GetValue(6).ToString()), hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString());
                return a;
            }
            else
            {
                return null;
            }
        }
        public static Konsumen CekLogin(string username, string password)
        {
            string sql = "select * from konsumens where username='" + username + "' and password='" + password + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Konsumen k = new Konsumen(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), DateTime.Parse(hasil.GetValue(5).ToString()), double.Parse(hasil.GetValue(6).ToString()), hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString());
                return k;
            }
            return null;

        }
        #endregion
    }
}
