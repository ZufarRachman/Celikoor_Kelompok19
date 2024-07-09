using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class FilmStudio
    {
        Studio studioID;
        Film filmID;

        #region Properties
        public Film FilmID { get => filmID; set => filmID = value; }
        public Studio StudioID { get => studioID; set => studioID = value; }
        #endregion

        #region Constructors
        public FilmStudio(Film filmID, Studio studioID)
        {
            FilmID = filmID;
            StudioID = studioID;
        }
        #endregion

        #region Methods
        public static Boolean HapusData(Film f, Studio s)
        {
            string sql1 = "select * from sesi_films where films_id=" + f.Id + " and studios_id=" + s.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql1);
            if(hasil.Read() != true)
            {
                string sql2 = "delete from film_studio where films_id=" + f.Id + " and studios_id=" + s.Id;
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
        #endregion
    }
}
