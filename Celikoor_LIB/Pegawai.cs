using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Pegawai
    {
        string id;
        string nama;
        string email;
        string username;
        string password;
        string roles;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }

        #endregion

        #region Constructors
        public Pegawai(string id, string nama, string email, string username, string roles)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Roles = roles;
        }

        public Pegawai(string id, string nama, string email, string username, string password, string roles)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Roles = roles;
        }

        public Pegawai(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        public Pegawai(string id)
        {
            Id = id;
        }


        #endregion

        #region Methods
        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from pegawais";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pegawai> listPegawai = new List<Pegawai>();
            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(5).ToString());
                listPegawai.Add(p);
            }
            return listPegawai;
        }

        public static void TambahData(Pegawai p)
        {
            string sql = "insert into pegawais(id, nama, email, username, password, roles) values ("+p.Id+",'"+p.Nama.Replace("'","\\'")+"','"+p.Email+"','"+p.Username+"','"+p.Password+"','"+p.Roles+"')";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Pegawai p)
        {
            string sql = "delete from pegawais where id=" + p.Id;
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
            string sql = "select max(id) from pegawais";

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

        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "select * from pegawais where username='"+username+"' and password='"+password+"'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(5).ToString());
                return p;
            }
            return null;

        }
        #endregion
    }
}
