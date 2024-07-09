using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class GenreFilm
    {
        Film filmID;
        Genre genreID;

        #region Properties
        public Film FilmID { get => filmID; set => filmID = value; }
        public Genre GenreID { get => genreID; set => genreID = value; }
        #endregion

        #region Constructors
        public GenreFilm(Film filmID, Genre genreID)
        {
            FilmID = filmID;
            GenreID = genreID;
        }
        #endregion

        #region Methods
        #endregion
    }
}
