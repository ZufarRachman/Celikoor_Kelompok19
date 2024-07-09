using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class JadwalFilm
    {
        string id;
        DateTime tanggalPemutaran;
        string jamPemutaran;

        #region Properties
        public string Id { get => id; set => id = value; }
        public DateTime TanggalPemutaran { get => tanggalPemutaran; set => tanggalPemutaran = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        #endregion

        #region Constructors
        public JadwalFilm(string id, DateTime tanggalPemutaran, string jamPemutaran)
        {
            Id = id;
            TanggalPemutaran = tanggalPemutaran;
            JamPemutaran = jamPemutaran;
        }

        public JadwalFilm(string id, DateTime tanggalPemutaran)
        {
            Id = id;
            TanggalPemutaran = tanggalPemutaran;
        }

        public JadwalFilm(DateTime tanggalPemutaran, string jamPemutaran)
        {
            TanggalPemutaran = tanggalPemutaran;
            JamPemutaran = jamPemutaran;
        }

        #endregion

        #region Methods
        public static List<JadwalFilm> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from jadwal_films";

            if (kriteria != "")
            {
                sql = sql + " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();
            while (hasil.Read() == true)
            {
                JadwalFilm jf = new JadwalFilm(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString());
                listJadwalFilm.Add(jf);
            }
            return listJadwalFilm;
        }

        public static void TambahData(JadwalFilm jf)
        {
            string sql1 = "insert into jadwal_films(id, tanggal, jam_pemutaran) values (" + jf.Id + ",'" + jf.TanggalPemutaran.ToString("yyyy-MM-dd") + "','" + jf.JamPemutaran + "')";
            Koneksi.JalankanPerintahNonQuery(sql1);
        }

        public static void TambahDataFilmStudio(Film f, Studio s)
        {
            string sql2 = "insert into film_studio(studios_id, films_id) values(" + s.Id + "," + f.Id + ")";
            Koneksi.JalankanPerintahNonQuery(sql2);
        }

        public static void TambahDataSesiFilm(Film f, Studio s, JadwalFilm jf)
        {
            string sql3 = "insert into sesi_films(jadwal_film_id, studios_id, films_id) values (" + jf.Id + "," + s.Id + "," + f.Id + ")";
            Koneksi.JalankanPerintahNonQuery(sql3);
        }

        public static void UbahData(JadwalFilm jf)
        {
            string sql = "update jadwal_films set tanggal='" + jf.TanggalPemutaran.ToString("yyyy-MM-dd") + "', jam_pemutaran='" + jf.JamPemutaran + "' where id=" + jf.Id;

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static Boolean HapusData(JadwalFilm jf, Studio s, Film f)
        {
            string sql1 = "SELECT jf.*, sf.* FROM jadwal_films jf inner join sesi_films sf on sf.jadwal_film_id = jf.id inner join studios s on s.id = sf.studios_id inner join films f on f.id = sf.films_id where f.id=" + f.Id + " and s.id =" + s.Id + " and jf.tanggal='" + jf.TanggalPemutaran.ToString("yyyy-MM-dd") + "' and jf.jam_pemutaran='" + jf.JamPemutaran + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql1);
            if (hasil.Read() == true)
            {
                Film filmId = Film.AmbilDataByID("f.id", hasil.GetValue(5).ToString());
                Studio studioID = Studio.AmbilDataByID("s.id", hasil.GetValue(4).ToString());
                JadwalFilm jadwalFilmID = new JadwalFilm(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString());

                Boolean hapusSesiFilm = SesiFilm.HapusData(filmId, studioID, jadwalFilmID);

                if(hapusSesiFilm == true)
                {
                    FilmStudio.HapusData(filmId, studioID);

                    string sql2 = "delete from jadwal_films where id=" + jadwalFilmID.Id;

                    int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(sql2);
                    if (jumlahDataBerubah == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean HapusDataByID(JadwalFilm jf)
        {
            string sql = "delete from jadwal_films where id=" + jf.Id;
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
            string sql = "select max(id) from jadwal_films";

            string hasilID = "";
            int IDTerbaru = 0;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() == "")
                {
                    IDTerbaru = 1;
                }
                else
                {
                    IDTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
                hasilID = IDTerbaru.ToString();
            }
            else
            {
                hasilID = "1";
            }
            return hasilID;
        }
        public static JadwalFilm AmbilDataByID(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from jadwal_films where " + kriteria + " = '" + nilaiKriteria + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                JadwalFilm jf = new JadwalFilm(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString());
                return jf;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
