using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var initialData = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            using (var largeDataCollection = new LargeDataCollection(initialData))
            {
                largeDataCollection.Add(25);

                largeDataCollection.Add(77);

                largeDataCollection.Remove(3);
                largeDataCollection.Remove(6);

                Console.WriteLine("Elements in the collection:\n");

                for (int i = 0; i <initialData.Length; i++)
                {
                    { Console.WriteLine($"Index{i}: {largeDataCollection.GetElement(i)}"); }
                 
                }
                Console.WriteLine(" ");
                Console.WriteLine("**************************************************");
                Console.WriteLine("Added elements are 25 and 77 (Added Index:8 & 9)");
                Console.WriteLine("Removed elements are 3 and 6 (Removed Index:2 & 4)");

                Console.ReadKey();
            }
        }
    }
}

