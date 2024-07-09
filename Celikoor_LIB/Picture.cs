using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Picture
    {
        int id;
        string filename;
        string inputDate;
        string eventTime;
        int ownerId;
        string status;
        string caption;

        #region Properties
       
        #endregion

        #region Constructors
        public Picture(int id, string filename, string inputDate, string eventTime, int ownerId, string status, string caption)
        {
            this.id = id;
            this.filename = filename;
            this.inputDate = inputDate;
            this.eventTime = eventTime;
            this.ownerId = ownerId;
            this.status = status;
            this.caption = caption;
        }

        public Picture(string filename, string inputDate, string eventTime, int ownerId, string status, string caption)
        {
            this.filename = filename;
            this.inputDate = inputDate;
            this.eventTime = eventTime;
            this.ownerId = ownerId;
            this.status = status;
            this.caption = caption;
        }
        #endregion

        #region Methods
        public static List<Picture> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id order by s.cinemas_id, s.id asc";

            if (kriteria != "")
            {
                sql = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on js.id=s.jenis_studios_id inner join cinemas c on c.id = s.cinemas_id where " + kriteria + " like '%" + nilaiKriteria + "%' order by s.cinemas_id, s.id asc";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Picture> listStudio = new List<Picture>();
            while (hasil.Read() == true)
            {
               
            }
            return listStudio;
        }
        public static void TambahData(Picture s)
        {
            string sql = $"insert into tPicture(filename, inputdate, eventtime, ownerId, status, caption) values ({s.filename},{s.inputDate},{s.eventTime},{s.ownerId},{s.status},{s.caption})";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        #endregion
    }
}
