using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO;

namespace DataBase
{
    public class DataWork
    {
        ArrayList filmfails = new ArrayList();

        /// <summary>
        /// Вернуть список
        /// </summary>
        public ArrayList Filmfails
        {
            get
            {
                return filmfails;
            }
        }

        /// <summary>
        /// Добавление фильма в список
        /// </summary>
        public void AddFilmfails(FilmFile filmfails)
        {
            this.filmfails.Add(filmfails);
        }

        /// <summary>
        /// Удаление всего списка
        /// </summary>
        public void Deletefilm() => filmfails.Clear();

        /// <summary>
        /// Удаление элемента списка по индексу
        /// </summary>
        public void DeleteFilmFile(int number) => filmfails.RemoveAt(number);

        /// <summary>
        /// Изменить название фильма у заданного элемента
        /// </summary>
        public void ChangefilmtName(string film, int index)
        {
            FilmFile films = (FilmFile)Filmfails[index];
            films.filmname = film;
        }

        /// <summary>
        /// Изменить режиссера у заданного элемента
        /// </summary>
        public void Changeproducer(string produc, int index)
        {
            FilmFile films = (FilmFile)Filmfails[index];
            films.Producer = produc;
        }

        /// <summary>
        /// Изменить год издания фильма у заданного элемента
        /// </summary>
        public void ChangeYearRelease(ushort year, int index)
        {
            FilmFile films = (FilmFile)Filmfails[index];
            if ((year < 1888) || (year > DateTime.Now.Year))
                throw new Exception("Год выпуска не раньше 1888 и не позднее " + DateTime.Now.Year);
            films.YearRelease = year;
        }

        /// <summary>
        /// Изменить жанр фильма у заданного элемента
        /// </summary>
        public void Changegenre(string genr, int index)
        {
            FilmFile films = (FilmFile)Filmfails[index];
            films.Genre = genr;
        }

        /// <summary>
        /// Сохранение списка в файл
        /// </summary>
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (FilmFile s in filmfails)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// <summary>
        /// Восстанавливает список, записанный в файл
        /// </summary>
        public void OpenFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            if (filmfails.Count != 0)
                Deletefilm();
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);
                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string filmName = dataFromFile[1];
                    string producer = dataFromFile[2];
                    ushort year = (ushort)Convert.ToInt32(dataFromFile[3]);
                    string genre = dataFromFile[4];
                    FilmFile musicFile = new FilmFile(id, filmName, producer, year, genre);
                    AddFilmfails(musicFile);
                }
            }
        }

        /// <summary>
        /// Поиск по заданному параметру и возвращение индексов найденных элементов
        /// Вернет -1, если элементы не найдены
        /// </summary>
        public List<int> SearchfilmFail(string query)
        {
            List<int> count = new List<int>();
            ushort num_query;
            if (ushort.TryParse(query, out num_query))
            {
                for (int i = 0; i < filmfails.Count; i++)
                {
                    FilmFile films = (FilmFile)filmfails[i];
                    if (films.ID == num_query)
                    {
                        count.Add(i);
                        break;
                    }
                    else
                    {
                        if (films.YearRelease == num_query)
                            count.Add(i);
                    }
                }
                if (count.Count == 0)
                    count.Add(-1);
                return count;
            }
            query = query.ToLower(); // перевод в нижний регистр
            query = query.Replace(" ", "");
            for (int i = 0; i < filmfails.Count; i++)
            {
                FilmFile films = (FilmFile)filmfails[i];
                if (films.filmname.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
                else
                    if (films.Producer.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
                else
                    if (films.Genre.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
            }
            if (count.Count == 0)
                count.Add(-1);
            return count;
        }

        public void Sort(SortDirection direction)
        {
            filmfails.Sort(new YearComparer(direction));
        }
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public class YearComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public YearComparer() : base() { }

        public YearComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            FilmFile films1 = (FilmFile)x;
            FilmFile films2 = (FilmFile)y;

            return (this.m_direction == SortDirection.Ascending) ?
                films1.YearRelease.CompareTo(films2.YearRelease) :
                films2.YearRelease.CompareTo(films1.YearRelease);
        }
    }
}
