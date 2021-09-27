using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Employee:Person
    {
        public Employee(string name,string position):base(name)
        {
            Position = position;
        }

        public string Position { get; set; }

        public override void Show()
        {
            Console.WriteLine($"{Name} is the {Position} of VTB");
        }
    }
}
