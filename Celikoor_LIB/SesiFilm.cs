using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class SesiFilm
    {
        Film filmID;
        Studio studioID;
        JadwalFilm jadwalFilmID;

        #region Properties
        public Film FilmID { get => filmID; set => filmID = value; }
        public Studio StudioID { get => studioID; set => studioID = value; }
        public JadwalFilm JadwalFilmID { get => jadwalFilmID; set => jadwalFilmID = value; }
        #endregion

        #region Constructors
        public SesiFilm(Film filmID, Studio studioID, JadwalFilm jadwalFilmID)
        {
            FilmID = filmID;
            StudioID = studioID;
            JadwalFilmID = jadwalFilmID;
        }
        #endregion

        #region Methods
        public static List<SesiFilm> BacaData()
        {
            string sql = "SELECT * FROM sesi_films";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<SesiFilm> listSesiFilm = new List<SesiFilm>();
            while (hasil.Read() == true)
            {
                JadwalFilm jf = JadwalFilm.AmbilDataByID("id", hasil.GetValue(0).ToString());
                Studio s = Studio.AmbilDataByID("s.id", hasil.GetValue(1).ToString());
                Film f = Film.AmbilDataByID("f.id", hasil.GetValue(2).ToString());
                SesiFilm sf = new SesiFilm(f, s, jf);
                listSesiFilm.Add(sf);
            }
            return listSesiFilm;
        }

        public static List<Cinema> BacaDataCinemas(string tanggal, string judul)
        {
            string sql = "SELECT distinct c.* FROM sesi_films sf inner join jadwal_films jf on jf.id = sf.jadwal_film_id inner join studios s on s.id = sf.studios_id inner join cinemas c on c.id = s.cinemas_id inner join films f on f.id = sf.films_id where jf.tanggal = '" + tanggal + "' and f.judul = '" + judul + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cinema> listCinema = new List<Cinema>();
            while(hasil.Read() == true)
            {
                Cinema c = new Cinema(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), DateTime.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString());
                listCinema.Add(c);
            }
            return listCinema;
        }

        public static List<Studio> BacaDataStudios(string tanggal, string judul, string namaCabang)
        {
            string sql = "SELECT distinct s.* FROM sesi_films sf inner join jadwal_films jf on jf.id = sf.jadwal_film_id inner join studios s on s.id = sf.studios_id inner join cinemas c on c.id = s.cinemas_id inner join films f on f.id = sf.films_id where jf.tanggal = '" + tanggal + "' and f.judul = '" + judul + "' and c.nama_cabang='" + namaCabang + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Studio> listStudio = new List<Studio>();
            while (hasil.Read() == true)
            {
                Studio s = Studio.AmbilDataByID("s.id", hasil.GetValue(0).ToString());
                listStudio.Add(s);
            }
            return listStudio;
        }

        public static List<JadwalFilm> BacaDataJadwalFilm(Studio s, Film f)
        {
            string sql = "select jf.* from sesi_films sf " +
                "inner join jadwal_films jf on jf.id = sf.jadwal_film_id " +
                "inner join films f on f.id = sf.films_id " +
                "inner join studios s on s.id = sf.studios_id " +
                "where studios_id = " + s.Id + " and films_id = " + f.Id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();
            while (hasil.Read() == true)
            {
                JadwalFilm jf = new JadwalFilm(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString());
                listJadwalFilm.Add(jf);
            }
            return listJadwalFilm;
        }

        public static Boolean HapusData(Film f, Studio s, JadwalFilm jf)
        {
            string sql1 = "SELECT jf.*, sf.* FROM jadwal_films jf inner join sesi_films sf on sf.jadwal_film_id = jf.id inner join studios s on s.id = sf.studios_id inner join films f on f.id = sf.films_id where f.id=" + f.Id + " and s.id =" + s.Id + " and jf.tanggal='" + jf.TanggalPemutaran.ToString("yyyy-MM-dd") + "' and jf.jam_pemutaran='" + jf.JamPemutaran + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql1);
            if (hasil.Read() == true)
            {
                Film filmId = Film.AmbilDataByID("f.id", hasil.GetValue(5).ToString());
                Studio studioID = Studio.AmbilDataByID("s.id", hasil.GetValue(4).ToString());
                JadwalFilm jadwalFilmID = new JadwalFilm(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString());

                string sql2 = "delete from sesi_films where films_id=" + filmId.Id + " and studios_id=" + studioID.Id + " and jadwal_film_id=" + jadwalFilmID.Id;

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

        public static SesiFilm AmbilData(JadwalFilm jf, Studio s, Film f)
        {
            string sql = "SELECT * FROM sesi_films " +
                "where jadwal_film_id = " + jf.Id + " and studios_id = " + s.Id + " and films_id = " + f.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                SesiFilm sf = new SesiFilm(f, s, jf);
                return sf;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
