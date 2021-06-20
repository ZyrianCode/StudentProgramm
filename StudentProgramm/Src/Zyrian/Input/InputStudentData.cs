using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.Input
{
    public class InputStudentData
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _personalCode;
        private string _dateOfBirthday;

        public void InputStudentSpecifications()
        {
            Console.WriteLine("Введите имя: ");
            _name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            _surname = Console.ReadLine();

            Console.WriteLine("Введите отчество: ");
            _patronymic = Console.ReadLine();

            Console.WriteLine("Введите код студента: ");
            _personalCode = Console.ReadLine();

            Console.WriteLine("Введите дату рождения: ");
            _dateOfBirthday = Console.ReadLine();
        }

        public string GetName() => _name;
        public string GetSurname() => _surname;
        public string GetPatronymic() => _patronymic;
        public string GetPersonalCode() => _personalCode;
        public string GetDateOfBirthday() => _dateOfBirthday;

        public void ClearAll()
        {
            _name = null;
            _surname = null;
            _patronymic = null;
            _personalCode = null;
            _dateOfBirthday = null;
        }
    }
}
