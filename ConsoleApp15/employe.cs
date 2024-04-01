using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    
    internal class employe
    {
        public string Name;
        public int ID;
        public int Salary;

        public employe(string name, int id, int salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Name},{ID}, {Salary}");
        }
    }
    
}
