using System;
using StudentProgramm.Zyrian;

namespace StudentProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGroup = new StudentGroup();
            studentGroup.AddStudent("Ivan", "Ivanov", "AB108", "22.03.2002");
            studentGroup.AddStudent("Alex", "Artemov", "AC094", "05.04.2000");

            foreach (var student in studentGroup){
                Console.WriteLine(student);
            }

            Console.WriteLine("Sorted:");
            var comparator = new StudentNameComparator();
            studentGroup.Sort(comparator);
            
            foreach (var student in studentGroup){
                Console.WriteLine(student);
            }

            Console.WriteLine("Count of Students: " + studentGroup.Count);
        }
    }
}