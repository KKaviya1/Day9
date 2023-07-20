using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 21, 20, 3, 4, 55, 61 };
            Console.WriteLine("all numbers");
            Console.WriteLine("total number in list are:" + numbers.Count);
            Console.WriteLine("capacity:" + numbers.Capacity);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine("total Number in list area:" + numbers.Count);
            Console.WriteLine("capacity:" + numbers.Capacity);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }
            Console.WriteLine("enter number to search in list");
            int searchNumber = int.Parse(Console.ReadLine());

            if (numbers.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is a part of numbers list ");

            }
            else {
                Console.WriteLine("not found");
                    
                    }
            Console.ReadKey();  
        }
    }
}
