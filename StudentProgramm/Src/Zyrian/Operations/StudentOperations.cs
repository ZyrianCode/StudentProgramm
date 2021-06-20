using StudentProgramm.Src.Zyrian.Input;
using StudentProgramm.Src.Zyrian.SchoolSimulator;
using StudentProgramm.Src.Zyrian.SchoolSimulator.StudentComparators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.Operations
{
    /// <summary>
    /// Класс являющийся набором операций, производимых над студентами в группе
    /// </summary>
    public class StudentOperations
    {
        private static int _removeOptions;
        private static int _sortOptions;

        /// <summary>
        /// Доступные опции удаления.
        /// </summary>
        internal enum StudentRemoveOptions
        {
            RemoveByPersonalCode = 1,
            RemoveByIndex = 2
        }

        /// <summary>
        /// Доступные опции сортировки.
        /// </summary>
        internal enum StudentSortOptions 
        {
            SortByName = 1
        }


        /// <summary>
        /// Операция печати студентов группы.
        /// </summary>
        /// <param name="group"> Группа студентов </param>
        internal static void PrintStudents(StudentGroup group)
        {
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }
        }

        /// <summary>
        /// Операция добавления студентов.
        /// </summary>
        /// <param name="input"> Объект оболочки множественного ввода </param>
        /// <param name="group"> Группа </param>
        internal static void AddStudent(InputStudentData input, StudentGroup group)
        {
            input.InputStudentSpecifications();
            group.AddStudent(input.GetName(), input.GetSurname(), input.GetPatronymic(), input.GetPersonalCode(), input.GetDateOfBirthday());
        }

        /// <summary>
        ///  Операция удаления студентов.
        /// </summary>
        /// <param name="input"> Объект оболочки единственного ввода </param>
        /// <param name="group"> Группа </param>
        internal static void RemoveStudent(SingleInputStudentData input, StudentGroup group)
        {
            Console.WriteLine("Введите removeOptions: По персональному коду - 1, По индексу - 2 ");
            InputStudentRemoveOptions();

            switch ((StudentRemoveOptions)_removeOptions)
            {
                case StudentRemoveOptions.RemoveByPersonalCode:
                    input.InputPersonalCode();
                    group.RemoveStudentByPersonalCode(input.GetPersonalCode());
                    input.ClearPersonalCode();
                    break;
                case StudentRemoveOptions.RemoveByIndex:
                    input.InputIndex();
                    group.RemoveStudentByIndex(input.GetIndex());
                    input.ClearIndex();
                    break;
                default:
                    Console.WriteLine("Ты херню какую-то мне вдалбливаешь");
                    break;
            }
        }

        /// <summary>
        /// Ввод типа удаления.
        /// </summary>
        internal static void InputStudentRemoveOptions() => 
            _removeOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Ввод типа сортировки.
        /// </summary>
        internal static void InputStudentSortOptions() =>
            _sortOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Операция сортировки.
        /// </summary>
        /// <param name="group"> Группа </param>
        internal static void SortStudents(StudentGroup group)
        {
            Console.WriteLine("Введите sortOptions: По имени - 1");

            InputStudentSortOptions();

            switch ((StudentSortOptions)_sortOptions)
            {
                case StudentSortOptions.SortByName:
                    var comparator = new StudentNameComparator();
                    group.Sort(comparator);
                    break;
                default:
                    Console.WriteLine("Не знаю такого!");
                    break;
            }
        }
    }
}
