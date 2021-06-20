using StudentProgramm.Src.Zyrian.Input;
using StudentProgramm.Src.Zyrian.Operations;
using StudentProgramm.Src.Zyrian.SchoolSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.Menu
{
    public class GroupMenu
    {
        internal static School _school = new School();
        private InputGroupData _input = new InputGroupData();
        private Menu _menu = new Menu();

        private int _chosedActions = 0;
        public bool isAbleToBack = false;

        /// <summary>
        /// Доступные действия для работы со студентами и группами.
        /// </summary>
        internal enum Actions
        {
            Add = 1,
            Print = 2,
            Remove = 3,
            Sort = 4,
            Find = 5,
            Quit = 6
        }

        /// <summary>
        /// Вызов меню
        /// </summary>
        public void CallGroupMenu()
        {
            PrintMenu();
            InputActions();

            PerformOperations();
        }


        /// <summary>
        /// Печатает меню
        /// </summary>
        private void PrintMenu() =>
            Console.WriteLine("Введите номер операции: Add - 1, Print - 2, Remove - 3, Sort - 4, Find - 5, Quit - 6");

        /// <summary>
        /// Ввод действий из списка доступных действий
        /// </summary>
        private void InputActions() =>
            _chosedActions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Выполнение операций по рабработе со студентами и группами
        /// </summary>
        private void PerformOperations()
        {
            switch ((Actions)_chosedActions)
            {
                case Actions.Add:
                    GroupOperations.AddGroup(_input, _school);
                    isAbleToBack = true;
                    break;

                case Actions.Print:
                    GroupOperations.PrintGroups(_school);
                    isAbleToBack = true;
                    break;

                case Actions.Remove:
                    GroupOperations.RemoveGroup(_input, _school);
                    isAbleToBack = true;
                    break;

                case Actions.Sort:
                    Console.WriteLine("Операция не поддерживается!");
                    isAbleToBack = true;
                    break;

                case Actions.Find:
                    GroupOperations.FindGroup(_input, _school);
                    isAbleToBack = true;
                    break;

                case Actions.Quit:
                    _menu.CallMenu();
                    break;

                default:
                    Console.WriteLine("Опять ты брешишь...");
                    isAbleToBack = false;
                    break;
            }
        }
    }
}
