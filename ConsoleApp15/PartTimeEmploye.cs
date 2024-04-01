using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class PartTimeEmploye:employe
    {
        public int HoursWorked;
        public PartTimeEmploye(string name, int id, int salary, int hoursWorked):base(name, id, salary)
        {
            HoursWorked = hoursWorked;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{HoursWorked}");
        }
    }
}
