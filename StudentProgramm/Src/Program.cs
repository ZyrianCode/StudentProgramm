using System;
using StudentProgramm.Src.Zyrian;
using StudentProgramm.Src.Zyrian.Menu;

namespace StudentProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.CallMenu();

            while (menu.isAbleToBack)
            {
                menu.CallMenu();
            }
        }
    }
}