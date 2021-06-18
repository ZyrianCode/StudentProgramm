using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian
{
    public class Menu
    {

        private static string code = "1";
        internal StudentGroup _studentGroup = new StudentGroup(code);
        private InputData _inputData = new InputData();
        private SingleInput _singleInput = new SingleInput();
        private int chosedActions = 0;
        public bool isBack = false;
        /// <summary>
        /// Доступные действия для работы со студентами и группами.
        /// </summary>
        internal enum Actions
        {
            Print = 1,
            Add = 2,
            Remove = 3,
            Sort = 4,
            Find = 5,
            Quit = 6
        }
        

        /// <summary>
        /// Вызов меню
        /// </summary>
        public void CallMenu()
        {
            Actions actions = new Actions();
            PrintMenu();
            InputActions(actions);

            PerformOperations(actions);
        }

        /// <summary>
        /// Печатает меню
        /// </summary>
        private void PrintMenu() =>
            Console.WriteLine("Введите номер операции: Print - 1, Add - 2, Remove - 3, Sort - 4, Find - 5, Quit - 6");

        /// <summary>
        /// Ввод действий из списка доступных действий
        /// </summary>
        /// <param name="actions"> Доступные действия </param>
        private void InputActions(Actions actions) =>
            chosedActions = int.Parse(Console.ReadLine());

        /// <summary>
        /// Выполнение операций по рабработе со студентами и группами
        /// </summary>
        /// <param name="actions"> Доступные действия </param>
        private void PerformOperations(Actions actions)
        {
            switch ((Actions)chosedActions)
            {
                case Actions.Print:
                    Operations.Print(_studentGroup);
                    isBack = true;
                    break;

                case Actions.Add:
                    Operations.Add(_inputData, _studentGroup);
                    isBack = true;
                    break;

                case Actions.Remove:
                    Operations.Remove(_singleInput, _studentGroup);
                    isBack = true;
                    break;

                case Actions.Sort:

                    Operations.Sort(_singleInput, _studentGroup);
                    isBack = true;
                    break;

                case Actions.Find:
                    Console.WriteLine("Не работает такое!");
                    isBack = true;
                    break;

                case Actions.Quit:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Опять ты брешишь...");
                    isBack = true;
                    break;
            }
        }
    }
}
