using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProgramm.Src.Zyrian.Input;
using StudentProgramm.Src.Zyrian.SchoolSimulator;

namespace StudentProgramm.Src.Zyrian.Operations
{
    public class GroupOperations
    {
        private static int _removeOptions;
        private static int _findOptions;
        private static StudentGroup _group = new StudentGroup();

        /// <summary>
        /// Виды удаления.
        /// </summary>
        internal enum GroupRemoveOptions
        {
            RemoveByGroupCode = 1
        }

        /// <summary>
        /// Виды поиска.
        /// </summary>
        internal enum GroupFindOptions
        {
            FindByGroupCode = 1
        }

        /// <summary>
        /// Метод, печатающий группы школы.
        /// </summary>
        /// <param name="school"> Школа </param>
        internal static void PrintGroups(School school)
        {
            foreach (var group in school)
            {
                Console.WriteLine(group);
                
            }
        }

        /// <summary>
        /// Метод, добавляющий группу в школу.
        /// </summary>
        /// <param name="input"> Хранит данные ввода для группы </param>
        /// <param name="school"> Школа </param>
        internal static void AddGroup(InputGroupData input, School school)
        {
            input.InputGroupSpecification();
            school.AddGroup(input.GetGroupCode());
        }

        /// <summary>
        /// Метод, который находит группу в школе. Если группу найти не удалось, возвращает 1-ую попавшуюся группу.
        /// </summary>
        /// <param name="input"> Хранит данные ввода для группы </param>
        /// <param name="school"> Школа </param>
        internal static void FindGroup(InputGroupData input, School school)
        {
            Console.WriteLine("Найти группу: По коду группы - 1 ");
            InputGroupFindOptions();

            switch ((GroupFindOptions)_findOptions)
            {
                case GroupFindOptions.FindByGroupCode:
                    input.InputGroupSpecification();
                    _group = school.FindGroup(input.GetGroupCode());
                    input.ClearData();
                    break;
                default:
                    Console.WriteLine("Ты херню какую-то мне вдалбливаешь");
                    break;
            }
        }

        /// <summary>
        /// Метод, удаляющий группу.
        /// </summary>
        /// <param name="input"> Хранит данные ввода для группы </param>
        /// <param name="school"> Школа </param>
        internal static void RemoveGroup(InputGroupData input, School school)
        {
            Console.WriteLine("Удалить группу: По коду группы - 1 ");
            InputGroupRemoveOptions();

            switch ((GroupRemoveOptions)_removeOptions)
            {
                case GroupRemoveOptions.RemoveByGroupCode:
                    input.InputGroupSpecification();
                    school.RemoveGroupByCode(input.GetGroupCode());
                    input.ClearData();
                    break;
                default:
                    Console.WriteLine("Ты херню какую-то мне вдалбливаешь");
                    break;
            }
        }
        
        /// <summary>
        /// Метод, осуществляющий ввод вида нахождения группы.
        /// </summary>
        private static void InputGroupFindOptions() =>
            _findOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Метод, осуществляющий ввод вида удаления группы.
        /// </summary>
        private static void InputGroupRemoveOptions() =>
            _removeOptions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Метод, возвращающий найденную группу.
        /// </summary>
        /// <returns></returns>
        internal static StudentGroup GetFoundedGroup() => _group;
    }
}
