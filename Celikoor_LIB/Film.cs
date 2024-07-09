using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Celikoor_LIB
{
    public class Film
    {
        string id;
        string judul;
        string sinopsis;
        int tahun;
        int durasi;
        string bahasa;
        int isSubIndo;
        string coverImage;
        double diskon;
        Kelompok kelompok;
        List<GenreFilm> listGenre;
        List<AktorFilm> listAktorFilm;

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public double Diskon { get => diskon; set => diskon = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public List<GenreFilm> ListGenre { get => listGenre; private set => listGenre = value; }
        public List<AktorFilm> ListAktorFilm { get => listAktorFilm; private set => listAktorFilm = value; }
        #endregion

        #region Constructors
        public Film(string id, string judul, string sinopsis, int tahun, int durasi, string bahasa, int isSubIndo, string coverImage, double diskon, Kelompok kelompok)
        {
            Id = id;
            Judul = judul;
            Sinopsis = sinopsis;
            Tahun = tahun;
            Durasi = durasi;
            Bahasa = bahasa;
            IsSubIndo = isSubIndo;
            CoverImage = coverImage;
            Diskon = diskon;
            Kelompok = kelompok;
            ListAktorFilm = new List<AktorFilm>();
            ListGenre = new List<GenreFilm>();
        }

        public Film(string id, string judul)
        {
            Id = id;
            Judul = judul;
        }
        #endregion

        #region Methods
        public static List<Film> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select f.*, k.nama from films f inner join kelompoks k on k.id = f.kelompoks_id order by f.id asc";

            if (kriteria != "")
            {
                sql = "select f.*, k.nama from films f inner join kelompoks k on k.id = f.kelompoks_id where " + kriteria + " like '%" + nilaiKriteria + "%' order by f.id asc";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Film> listFilm = new List<Film>();
            while (hasil.Read() == true)
            {
                Kelompok k = new Kelompok(hasil.GetValue(5).ToString(), hasil.GetValue(10).ToString());
                Film f = new Film(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), hasil.GetValue(6).ToString(), int.Parse(hasil.GetValue(7).ToString()), hasil.GetValue(8).ToString(), double.Parse(hasil.GetValue(9).ToString()), k);
                listFilm.Add(f);
            }
            return listFilm;
        }
        public static void TambahData(Film f)
        {
            using(TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi koneksi = new Koneksi();
                    string sql1 = "insert into films(id, judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) values(" + f.Id + ",'" + f.Judul + "','" + f.Sinopsis + "'," + f.Tahun + "," + f.Durasi + "," + f.Kelompok.Id + ",'" + f.Bahasa + "'," + f.IsSubIndo + ",'" + f.CoverImage + "','" + f.Diskon.ToString().Replace(",", ".") + "')";
                    Koneksi.JalankanPerintahNonQuery(sql1, koneksi);

                    foreach (AktorFilm af in f.ListAktorFilm)
                    {
                        string sql2 = "insert into aktor_film(aktors_id, films_id, peran) values (" + af.AktorID.Id + "," + af.FilmID.Id + ",'" + af.Peran + "')";

                        Koneksi.JalankanPerintahNonQuery(sql2, koneksi);
                    }

                    foreach (GenreFilm gf in f.ListGenre)
                    {
                        string sql3 = "insert into genre_film(films_id, genres_id) values(" + gf.FilmID.Id + "," + gf.GenreID.Id + ")";

                        Koneksi.JalankanPerintahNonQuery(sql3, koneksi);
                    }
                    transcope.Complete();
                }
                catch(Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }

        public void TambahDataAktorFilm(Film filmID, Aktor aktorID, string peran)
        {
            AktorFilm af = new AktorFilm(filmID, aktorID, peran);
            ListAktorFilm.Add(af);
        }
        public void TambahDataGenreFilm(Film filmID, Genre genreID)
        {
            GenreFilm gf = new GenreFilm(filmID, genreID);
            ListGenre.Add(gf);
        }

        public static void UbahData(Film f)
        {
            string sql1 = "update films set judul='" + f.Judul + "', sinopsis='" + f.Sinopsis + "', tahun=" + f.Tahun + ", durasi=" + f.Durasi + ", kelompoks_id=" + f.Kelompok.Id + ", bahasa='" + f.Bahasa + "', is_sub_indo=" + f.IsSubIndo + ", cover_image='" + f.CoverImage + "', diskon_nominal='" + f.Diskon.ToString().Replace(",", ".") + "' where id= " + f.Id;

            Koneksi.JalankanPerintahNonQuery(sql1);

            string sql4 = "delete from aktor_film where films_id = " + f.Id;
            
            Koneksi.JalankanPerintahNonQuery(sql4);

            foreach (AktorFilm af in f.ListAktorFilm)
            {
                string sql2 = "insert into aktor_film(aktors_id, films_id, peran) values (" + af.AktorID.Id + "," + af.FilmID.Id + ",'" + af.Peran + "')";

                Koneksi.JalankanPerintahNonQuery(sql2);
            }

            foreach (GenreFilm gf in f.ListGenre)
            {
                string sql3 = "update genre_film set genres_id=" + gf.GenreID.Id + " where films_id=" + gf.FilmID.Id;

                Koneksi.JalankanPerintahNonQuery(sql3);
            }
        }

        public static Boolean HapusData(Film f)
        {
            string sql1 = "delete from aktor_film where films_id = " + f.Id;
            string sql2 = "delete from genre_film where films_id = " + f.Id;
            string sql3 = "delete from films where id=" + f.Id;
            int jumlahDataBerubah1 = Koneksi.JalankanPerintahNonQuery(sql1);
            int jumlahDataBerubah2 = Koneksi.JalankanPerintahNonQuery(sql2);
            int jumlahDataBerubah3 = Koneksi.JalankanPerintahNonQuery(sql3);
            if (jumlahDataBerubah1 == 0 && jumlahDataBerubah2 == 0 && jumlahDataBerubah3 == 0)
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
            string sql = "select max(id) from films";

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

        public static Film AmbilDataByID(string kriteria, string nilaiKriteria)
        {
            string sql = "select f.*, k.nama from films f inner join kelompoks k on k.id = f.kelompoks_id where " + kriteria + " = '" + nilaiKriteria + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Kelompok k = new Kelompok(hasil.GetValue(5).ToString(), hasil.GetValue(10).ToString());
                
                Film f = new Film(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), hasil.GetValue(6).ToString(), int.Parse(hasil.GetValue(7).ToString()), hasil.GetValue(8).ToString(), double.Parse(hasil.GetValue(9).ToString()), k);

                return f;
            }
            else
            {
                return null;
            }
        }

        public static List<AktorFilm> AmbilDataAktorFromFilm(string id)
        {
            string sql = "select f.*, k.nama, a.id, a.nama, ak.peran from films f  inner join kelompoks k on k.id=f.kelompoks_id  inner join aktor_film ak on ak.films_id=f.id  inner join aktors a on a.id=ak.aktors_id  where f.id = " + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<AktorFilm> listAktorFilm = new List<AktorFilm>();
            while(hasil.Read() == true)
            {
                Film f = new Film(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                Aktor a = new Aktor(hasil.GetValue(11).ToString(), hasil.GetValue(12).ToString());
                AktorFilm af = new AktorFilm(f,a,hasil.GetValue(13).ToString());
                listAktorFilm.Add(af);
            }
            return listAktorFilm;
        }
        public static List<GenreFilm> AmbilDataGenreFromFilm(string id)
        {
            string sql = "select f.*, k.nama, g.id, g.nama from films f inner join kelompoks k on k.id=f.kelompoks_id inner join genre_film gf on gf.films_id=f.id inner join genres g on g.id=gf.genres_id where f.id = " + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<GenreFilm> listGenreFilm = new List<GenreFilm>();
            while (hasil.Read() == true)
            {
                Film f = new Film(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                Genre g = new Genre(hasil.GetValue(11).ToString(), hasil.GetValue(12).ToString());
                GenreFilm gf = new GenreFilm(f, g);
                listGenreFilm.Add(gf);
            }
            return listGenreFilm;
        }

        #endregion
    }
}
