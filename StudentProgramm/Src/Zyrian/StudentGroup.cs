using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentProgramm.Src.Zyrian
{
    /// <summary>
    /// Группа студентов
    /// </summary>
    internal class StudentGroup : IEnumerable<Student>
    {
        private readonly List<Student> _students = new List<Student>();
        
        public string GroupCode { get; set; }
        public StudentGroup() { }
        public StudentGroup(string groupCode) => GroupCode = groupCode;

        /// <summary>
        /// Подсчёт студентов в группе
        /// </summary>
        public int Count => _students.Count;

        /// <summary>
        /// Метод добавления студентов в группу
        /// </summary>
        /// <param name="name"> Имя студента студента</param>
        /// <param name="surname"> Фамилия студента</param>
        /// <param name="patronymic"> Отчество студента </param>
        /// <param name="personalCode"> Персональный код студента </param>
        /// <param name="dateOfBirthday"> День рождения студента</param>
        public void AddStudent(string name, string surname, string patronymic, string personalCode, string dateOfBirthday) =>
            _students.Add(new Student(name, surname, patronymic, personalCode, dateOfBirthday));

        /// <summary>
        /// Метод удаления студента по индексу
        /// </summary>
        /// <param name="index"> Индекс студента в группе </param>
        public void RemoveStudentByIndex(int index) => _students.RemoveAt(index);

        /// <summary>
        /// Метод удаления студента по персональному коду
        /// </summary>
        /// <param name="personalCode"> Персональный код студента </param>
        public void RemoveStudentByPersonalCode(string personalCode)
        {
            foreach (var student in _students)
            {
                if (student.PersonalCode.Equals(personalCode))
                {
                    int index = _students.IndexOf(student);
                    _students.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Метод поиска студента в группе по индексу
        /// </summary>
        /// <param name="index"> Индекс студента в группе </param>
        public void FindStudentByIndex(int index) { }


        /// <summary>
        /// Метод сортировки студента
        /// </summary>
        /// <param name="comparer"> Вид компаратора </param>
        public void Sort(IComparer<Student> comparer) => _students.Sort(comparer);

        public Student this[int index] => _students[index];

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}