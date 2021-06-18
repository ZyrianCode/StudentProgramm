using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian
{
    /// <summary>
    /// Класс являющийся набором операций, производимых над студентами в группе
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Доступные опции удаления
        /// </summary>
        internal enum RemoveOptions
        {
            RemoveByPersonalCode = 1,
            RemoveByIndex = 2
        }

        /// <summary>
        /// Доступные опции сортировки
        /// </summary>
        internal enum SortOptions 
        {
            SortByName = 1
        }

        private static int _removeOptions;
        private static int _sortOptions;

        /// <summary>
        /// Операция печати студентов группы
        /// </summary>
        /// <param name="group"> Группа студентов </param>
        internal static void Print(StudentGroup group)
        {
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }
        }

        /// <summary>
        /// Операция добавления студентов
        /// </summary>
        /// <param name="input"> Объект оболочки множественного ввода </param>
        /// <param name="group"> Группа </param>
        internal static void Add(InputData input, StudentGroup group)
        {
            input.InputStudentSpecifications();
            group.AddStudent(input.GetName(), input.GetSurname(), input.GetPatronymic(), input.GetPersonalCode(), input.GetDateOfBirthday());
        }

        /// <summary>
        ///  Операция удаления студентов
        /// </summary>
        /// <param name="input"> Объект оболочки единственного ввода </param>
        /// <param name="group"> Группа </param>
        internal static void Remove(SingleInput input, StudentGroup group)
        {
            RemoveOptions removeOptions = new RemoveOptions();
            Console.WriteLine("Введите removeOptions: По персональному коду - 1, По индексу - 2 ");
            InputRemoveOptions(removeOptions);

            switch ((RemoveOptions)_removeOptions)
            {
                case RemoveOptions.RemoveByPersonalCode:
                    input.InputPersonalCode();
                    group.RemoveStudentByPersonalCode(input.GetPersonalCode());
                    input.ClearPersonalCode();
                    break;
                case RemoveOptions.RemoveByIndex:
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
        /// Ввод типа удаления
        /// </summary>
        /// <param name="_removeOptions"> Доступные опции удаления </param>
        internal static void InputRemoveOptions(RemoveOptions removeOptions) => 
            _removeOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Ввод типа сортировки
        /// </summary>
        /// <param name="_sortOptions"> Доступные опции сортировки </param>
        internal static void InputSortOptions(SortOptions sortOptions) =>
            _sortOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Операция сортировки
        /// </summary>
        /// <param name="input"> Объект оболочки единственного ввода </param>
        /// <param name="group"> Группа </param>
        internal static void Sort(SingleInput input, StudentGroup group)
        {
            SortOptions sortOptions = new SortOptions();
            Console.WriteLine("Введите sortOptions: По имени - 1");

            InputSortOptions(sortOptions);

            switch ((SortOptions)_sortOptions)
            {
                case SortOptions.SortByName:
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
