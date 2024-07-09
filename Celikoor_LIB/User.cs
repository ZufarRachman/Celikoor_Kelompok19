using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class User
    {
        int id;
        string username;
        string email;
        string password;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        #region Properties

        #endregion

        #region Constructors

        public User(int id, string username, string email, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        public User(string username, string email, string password)
        { 
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        #endregion

        #region Methods
        public static List<User> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from aktors";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<User> listAktor = new List<User>();
            while (hasil.Read() == true)
            {
                User a = new User(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                listAktor.Add(a);
            }
            return listAktor;
        }

        public static void TambahData(User a)
        {
            string sql = "insert into tUser(username, email, password) values('" + a.username + "','" + a.email + "','" + a.password + ")";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahData(User a)
        {
            
            string sql = "update tUser set username='" + a.username + "', email='" + a.email + "', password='" + a.password + "' where id=" + a.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }


        public static User AmbilData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from aktors where " + kriteria + " like '%" + nilaiKriteria + "%'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if(hasil.Read() == true)
            {
                User a = new User(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                return a;
            }
            else
            {
                return null;
            }
        }

        public static User AmbilDataById(int id)
        {
            string sql = "select * from tUser where id = " + id + "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                User a = new User(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
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
