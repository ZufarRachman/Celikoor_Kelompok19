using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Celikoor_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #region Constructors
        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword;
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["Celikoor_Kelompok19.db"] as ClientSettingsSection;

            string dbServer = settingSection.Settings.Get("DBServer").Value.ValueXml.InnerText;
            string dbName = settingSection.Settings.Get("DBName").Value.ValueXml.InnerText;
            string dbUsername = settingSection.Settings.Get("DBUsername").Value.ValueXml.InnerText;
            string dbPassword = settingSection.Settings.Get("DBPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + dbServer + ";database=" + dbName + ";uid=" + dbUsername + ";password=" + dbPassword;

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi con = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, con.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        public static int JalankanPerintahNonQuery(string sql)
        {
            Koneksi con = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, con.KoneksiDB);

            return c.ExecuteNonQuery();
        }

        public static int JalankanPerintahNonQuery(string sql, Koneksi koneksi)
        {
            MySqlCommand c = new MySqlCommand(sql, koneksi.KoneksiDB);
            return c.ExecuteNonQuery();
        }
        #endregion
    }
}
