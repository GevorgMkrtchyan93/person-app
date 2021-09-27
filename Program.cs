using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person client = new Client("Arman Avagyan", 50000);
            Person employee = new Employee("Anna Hakobyan", "Director");
            client.Show();
            employee.Show();
            Console.ReadLine();
        }
    }
}
