using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idisposal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex- 1

            //FileHandler fileHandler = new FileHandler("sam file one");
            //fileHandler.GetFileDetails();

            //fileHandler.Dispose();  

            //FileHandler fileHandler2 = new FileHandler("sam file two");
            //fileHandler2.GetFileDetails();



            // ex - 2

            using (FileHandler obj1 = new FileHandler("document -001"))
            {
                obj1.GetFileDetails();
            }
            Console.WriteLine(" ");

            using (FileHandler obj2 = new FileHandler("document -002"))
            {
                obj2.GetFileDetails();
            }

            Console.ReadKey();


        }
    }
}
