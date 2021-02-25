using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    class Decorator : IAbstractDiscipline
    {
        public DateTime dateOfBirth = new DateTime();
        public string Name
        {
            get;
            set;
        }
        public int Semestr
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public string Speciality
        {
            get;
            set;
        }
        public int NumberOfLections
        {
            get;
            set;
        }
        public int NumberOfLaboratories { get; set; }
        public string TypeOfControl { get; set; }

        public Lecturer lecturer;
        public Book listOfLiterature;
        public void AddLecturer(IAbstractLecturer abstractLecturer)
        {
            lecturer = (Lecturer)abstractLecturer;
        }
        public void AddBook(IAbstractBook abstractBook)
        {
            listOfLiterature = (Book)abstractBook;
        }
        protected Discipline discipline;
        public Decorator(Discipline discipline)
        {
            this.discipline = discipline;
        }

    }
}
