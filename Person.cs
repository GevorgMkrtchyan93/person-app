using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    abstract class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public abstract void Show();
        public string Name { get; set; }
    }
}
