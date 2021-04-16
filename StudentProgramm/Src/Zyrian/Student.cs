using System;
using System.Globalization;

namespace StudentProgramm.Zyrian
{
    internal class Student
    {
        public Student(string name, string surname, string personalCode, string dateOfBirthday)
        {
            Name = name;
            Surname = surname;
            PersonalCode = personalCode;
            DateOfBirthday = DateTime.ParseExact(dateOfBirthday, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalCode { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public override string ToString() => string.Format("{0}\t{1}\t{2}\t{3}", Name, Surname, PersonalCode, DateOfBirthday.ToShortDateString());
    }
}