using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
            Employee employee2 = new Employee(12 , "sam");
            employee2.Display();
            Employee emp3 = new Employee();
            emp3.Register();    
            emp3.Display(); 

            Console.ReadKey();  
        }
    }
}
