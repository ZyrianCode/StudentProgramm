using System;
using System.Collections.Generic;

namespace StudentProgramm.Src.Zyrian.SchoolSimulator.StudentComparators
{
    internal class StudentNameComparator : IComparer<Student>
    {
        public int Compare(Student first, Student second)
        {
            return String.Compare(first.Name, second.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}