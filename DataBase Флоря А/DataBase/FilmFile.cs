using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class FilmFile
    {
        string filmName; // название фильма
        string producer; // режиссер
        ushort yearRelease; // год выпуска фильма
        string genre; // жанр фильма
        ushort id; // id фильма

        public FilmFile(ushort id, string filmname, string producer, ushort yearRelease, string genre)
        {
            if ((filmname == "") || (producer == "") || (genre == ""))
                throw new Exception("Все поля должны быть заполнены!");
            this.filmName = filmname;
            this.producer = producer;
            this.genre = genre;
            if ((yearRelease < 1888) || (yearRelease > DateTime.Now.Year))
                throw new Exception("Год выпуска не раньше 1888 и не позднее " + DateTime.Now.Year);
            this.yearRelease = yearRelease;
            this.id = id;
        }

        public string filmname
        {
            get
            {
                return filmName;
            }

            set
            {
                filmName = value;
            }
        }

        public string Producer
        {
            get
            {
                return producer;
            }

            set
            {
                producer = value;
            }
        }

        public ushort YearRelease
        {
            get
            {
                return yearRelease;
            }

            set
            {
                yearRelease = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public ushort ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public override string ToString()
        {
            return id + "|" + filmName + "|" + producer + "|" +
                yearRelease + "|" + genre;
        }
    }
}
