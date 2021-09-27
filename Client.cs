using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Client:Person
    { 
        public int Sum { get; set; }
        public Client(string name,int sum):base(name)
        {
            Sum = sum;
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} have a {Sum} $ monney ");
        }
    }
}
