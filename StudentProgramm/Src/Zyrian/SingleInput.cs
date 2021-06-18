using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian
{
    public class SingleInput
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _personalCode;
        private string _dateOfBirthday;
        private int _index;

        public void InputName()
        {
            Console.WriteLine("Введите имя: ");
            _name = Console.ReadLine();
        }

        public void InputSurname()
        {
            Console.WriteLine("Введите имя: ");
            _surname = Console.ReadLine();
        }

        public void InputPatronymic()
        {
            Console.WriteLine("Введите имя: ");
            _patronymic = Console.ReadLine();
        }

        public void InputPersonalCode()
        {
            Console.WriteLine("Введите код студента: ");
            _personalCode = Console.ReadLine();
        }

        public void InputDateOfBirthday()
        {
            Console.WriteLine("Введите дату рождения: ");
            _dateOfBirthday = Console.ReadLine();
        }

        public void InputIndex()
        {
            Console.WriteLine("Введите индекс: ");
            _index = int.Parse(Console.ReadLine());
        }

        public void ClearName() => _name = null;

        public void ClearSurname() => _surname = null;

        public void ClearPatronymic() => _patronymic = null;

        public void ClearPersonalCode() => _personalCode = null;

        public void ClearDateOfBirthday() => _dateOfBirthday = null;
        public void ClearIndex() => _index = 0;

        public string GetName() => _name;
        public string GetSurname() => _surname;
        public string GetPatronymic() => _patronymic;
        public string GetPersonalCode() => _personalCode;
        public string GetDateOfBirthday() => _dateOfBirthday;
        public int GetIndex() => _index;
    }
}
