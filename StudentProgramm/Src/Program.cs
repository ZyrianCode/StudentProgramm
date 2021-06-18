using System;
using StudentProgramm.Src.Zyrian;

namespace StudentProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.CallMenu();

            while (menu.isBack)
            {
                menu.CallMenu();
            }
        }
    }
}