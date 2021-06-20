using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.Input
{
    public class InputGroupData
    {
        private string _groupCode;

        public void InputGroupSpecification()
        {
            Console.WriteLine("Введите код группы: ");
            _groupCode = Console.ReadLine();
        }

        public string GetGroupCode() => _groupCode;
        public void ClearData() => _groupCode = null;
    }
}
