using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Studio
    {
        string id;
        string nama;
        int kapasitas;
        int harga_weekday;
        int harga_weekend;
        JenisStudio jenisStudio;
        Cinema cinema;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }
        public JenisStudio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        #endregion

        #region Constructors
        public Studio(string id, string nama, int kapasitas, int harga_weekday, int harga_weekend, JenisStudio jenisStudio, Cinema cinema)
        {
            Id = id;
            Nama = nama;
            Kapasitas = kapasitas;
            Harga_weekday = harga_weekday;
            Harga_weekend = harga_weekend;
            JenisStudio = jenisStudio;
            Cinema = cinema;
        }

        public Studio(string id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Methods
        public static List<Studio> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id order by s.cinemas_id, s.id asc";

            if (kriteria != "")
            {
                sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id where " + kriteria + " like '%" + nilaiKriteria + "%' order by s.cinemas_id, s.id asc";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Studio> listStudio = new List<Studio>();
            while (hasil.Read() == true)
            {
                Cinema c = new Cinema(hasil.GetValue(4).ToString(), hasil.GetValue(8).ToString());
                JenisStudio js = new JenisStudio(hasil.GetValue(3).ToString(), hasil.GetValue(7).ToString());
                Studio s = new Studio(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), js, c);
                listStudio.Add(s);
            }
            return listStudio;
        }
        public static void TambahData(Studio s)
        {
            string sql = "insert into studios(id, nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) values ( " + s.Id + " ,'" + s.Nama + "', " + s.Kapasitas + " ," + s.JenisStudio.Id + " ," + s.Cinema.Id + " ," + s.harga_weekday + " ," + s.harga_weekend + " )";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahData(Studio s)
        {
            string sql = "update studios set nama='" + s.Nama + "', kapasitas=" + s.Kapasitas + ", jenis_studios_id=" + s.JenisStudio.Id + ", cinemas_id=" + s.Cinema.Id + ", harga_weekday=" + s.Harga_weekday + ", harga_weekend=" + s.Harga_weekend + " where id=" + s.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(Studio s)
        {
            string sql = "delete from studios where id=" + s.Id;
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
            string sql = "select max(id) from studios";

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

        public static Studio AmbilDataByID(string kriteria, string nilaiKriteria)
        {
            string sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id where " + kriteria + " = '" + nilaiKriteria + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Cinema c = new Cinema(hasil.GetValue(4).ToString(), hasil.GetValue(8).ToString());
                JenisStudio js = new JenisStudio(hasil.GetValue(3).ToString(), hasil.GetValue(7).ToString());
                Studio s = new Studio(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), js, c);
                return s;
            }
            else
            {
                return null;
            }
        }
        public static Studio AmbilDataForJadwalFilm(string kriteria, string nilaiKriteria, Cinema c)
        {
            string sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id where " + kriteria + "='" + nilaiKriteria + "' and c.nama_cabang ='" + c.NamaCabang + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                 c = new Cinema(hasil.GetValue(4).ToString(), hasil.GetValue(8).ToString());
                JenisStudio js = new JenisStudio(hasil.GetValue(3).ToString(), hasil.GetValue(7).ToString());
                Studio s = new Studio(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), js, c);
                return s;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
