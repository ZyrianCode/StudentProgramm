using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.Menu
{
    public class Menu
    {
        private int chosedActions = 0;
        public bool isAbleToBack = false;

        /// <summary>
        /// Доступные действия для работы со студентами и группами.
        /// </summary>
        internal enum Actions
        {
            OpenGroupMenu = 1,
            OpenStudentsMenu = 2,
            Quit = 3,
        }
        

        /// <summary>
        /// Вызов меню
        /// </summary>
        public void CallMenu()
        {
            PrintMenu();
            InputActions();

            PerformOperations();
        }

        /// <summary>
        /// Печатает меню
        /// </summary>
        private void PrintMenu() =>
            Console.WriteLine("Введите номер операции: Groups Menu - 1, Students Menu - 2, Quit - 3");

        /// <summary>
        /// Ввод действий из списка доступных действий
        /// </summary>
        /// <param name="actions"> Доступные действия </param>
        private void InputActions() =>
            chosedActions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Выполнение операций по рабработе со студентами и группами
        /// </summary>
        /// <param name="actions"> Доступные действия </param>
        private void PerformOperations()
        {
            switch ((Actions)chosedActions)
            {
                case Actions.OpenGroupMenu:
                    GroupMenu _groupMenu = new GroupMenu();
                    _groupMenu.CallGroupMenu();
                    isAbleToBack = true;
                    break;

                case Actions.OpenStudentsMenu:
                    StudentMenu _studentMenu = new StudentMenu();
                    _studentMenu.CallStudentMenu();
                    isAbleToBack = true;
                    break;

                case Actions.Quit:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Опять ты брешишь...");
                    isAbleToBack = true;
                    break;
            }
        }
    }
}
