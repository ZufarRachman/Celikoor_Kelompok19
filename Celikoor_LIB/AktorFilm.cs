using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class AktorFilm
    {
        Film filmID;
        Aktor aktorID;
        string peran;

        #region Properties
        public Film FilmID { get => filmID; set => filmID = value; }
        public Aktor AktorID { get => aktorID; set => aktorID = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion

        #region Constructors
        public AktorFilm(Film filmID, Aktor aktorID, string peran)
        {
            FilmID = filmID;
            AktorID = aktorID;
            Peran = peran;
        }
        #endregion

        #region Methods
        public static List<AktorFilm> BacaData(string id)
        {
            string sql = "select * from aktor_film where films_id=" + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<AktorFilm> listAktorFilm = new List<AktorFilm>();
            while(hasil.Read() == true)
            {
                Aktor a = Aktor.AmbilData("id", hasil.GetValue(0).ToString());
                Film f = Film.AmbilDataByID("f.id", hasil.GetValue(1).ToString());
                AktorFilm af = new AktorFilm(f, a, hasil.GetValue(2).ToString());
                listAktorFilm.Add(af);
            }
            return listAktorFilm;
        }
        #endregion
    }
}
