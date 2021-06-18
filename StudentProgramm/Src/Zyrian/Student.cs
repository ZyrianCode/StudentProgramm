using System;
using System.Globalization;

namespace StudentProgramm.Src.Zyrian
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PersonalCode { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public Student(string name, string surname, string patronymic, string personalCode, string dateOfBirthday)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PersonalCode = personalCode;
            DateOfBirthday = DateTime.ParseExact(dateOfBirthday, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

        public override string ToString() => string.Format("{0}\t{1}\t{2}\t{3}\t{4}", Name, Surname, Patronymic, PersonalCode, DateOfBirthday.ToShortDateString());
    }
}