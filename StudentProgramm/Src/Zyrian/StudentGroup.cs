using System.Collections;
using System.Collections.Generic;

namespace StudentProgramm.Zyrian
{
    internal class StudentGroup : IEnumerable<Student>
    {
        private readonly List<Student> _students = new List<Student>();

        public int Count => _students.Count;

        public void AddStudent(string name, string surname, string personalCode, string dateOfBirthday) =>
            _students.Add(new Student(name, surname, personalCode, dateOfBirthday));

        public void RemoveStudent(int index) => _students.RemoveAt(index);

        public void Sort(IComparer<Student> comparer) => _students.Sort(comparer);

        public Student this[int index] => _students[index];

        public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}