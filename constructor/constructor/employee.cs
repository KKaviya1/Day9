using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("parameterized constructor call");
            id = -1;
            name = "not given";

        }

        public Employee(int id, string name)
        {
            Console.WriteLine("parameterized constructor");
            this.id = id;
            this.name = name;
        }
        public void Register()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }

        public void Display()

        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t " + name);
            Console.WriteLine(" ");
        }

    }
}
