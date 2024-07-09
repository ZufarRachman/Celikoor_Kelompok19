using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Comment
    {
        int id;
        string comment;
        string commentdate;
        int pictureId;
        int userId;

        #region Properties
       
        #endregion

        #region Constructors

        public Comment(int id, string comment, string commentdate, int pictureId, int userId)
        {
            this.id = id;
            this.comment = comment;
            this.commentdate = commentdate;
            this.pictureId = pictureId;
            this.userId = userId;
        }

        public Comment(string comment, string commentdate, int pictureId, int userId)
        {
            this.comment = comment;
            this.commentdate = commentdate;
            this.pictureId = pictureId;
            this.userId = userId;
        }
        #endregion

        #region Methods
        public static List<Comment> getAllComment(int pictureId)
        {
            string sql = $"SELECT tComment.id,tComment.comment,tComment.commentdate,tComment.tPicture_id,tComment.tUser_id,tPicture.filename,tPicture.inputdate,tPicture.eventtime,tPicture.ownerID,tPicture.status,tPicture.caption,tUser.username,tUser.emailFROMtCommentJOINtPicture ON tComment.tPicture_id = tPicture.idJOINtUser ON tComment.tUser_id = tUser.idWHEREtPicture.id = {pictureId}";
            Console.WriteLine(sql);

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Comment> listOfComment = new List<Comment>();
            while (hasil.Read() == true)
            {
                listOfComment.Add(new Comment(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString())));
            }
            return listOfComment;
        }

        public static void TambahData(Comment a)
        {
            string sql = $"insert into tComment(comment, commentdate, tPicture_id,tUser_id) values({a.comment},{a.commentdate},{a.pictureId},{a.userId}";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        #endregion
    }
}
