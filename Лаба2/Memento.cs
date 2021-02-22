using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    //Объект сохранения
    public class Memento
    {
        public string Name
        {
            get;
            private set;
        }
        public int Semestr
        {
            get;
            private set;
        }
        public int Year
        {
            get;
            private set;
        }
        public string Speciality
        {
            get;
            private set;
        }
        public int NumberOfLections
        {
            get;
            private set;
        }
        public int NumberOfLaboratories { get; private set; }
        public string TypeOfControl { get; private set; }

        public Lecturer lecturer { get; private set; }
        public Book listOfLiterature { get; private set; }
        public Memento(Discipline dis)
        {
            Name = dis.Name;
            Semestr = dis.Semestr;
            Year = dis.Year;
            Speciality = dis.Speciality;
            NumberOfLections = dis.NumberOfLections;
            NumberOfLaboratories = dis.NumberOfLaboratories;
            TypeOfControl = dis.TypeOfControl;
            lecturer = dis.lecturer;
            listOfLiterature = dis.listOfLiterature;
        }
    }

    //Коллекция сохранений
    public class DisciplineHistory
    {
        public Stack<Memento> History { get; private set; }
        public DisciplineHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
