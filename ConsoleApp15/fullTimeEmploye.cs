using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class fullTimeEmploye:employe
    {
        public int VacationsDay;
        public fullTimeEmploye(string name, int id, int salary, int vacationsDay):base(name,id, salary)
        {
          
            VacationsDay = vacationsDay;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{VacationsDay}");
        }
    }
}
