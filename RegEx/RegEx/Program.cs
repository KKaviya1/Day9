using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //List<string> list = new List<string>()
            //            //{ "viya", "priya","ravi","raj","suman"};
            //            string mobPattern = @"^\d{10}$";
            //            Regex regex = new Regex(mobPattern);

            //            string[] mobiles = new string[] { "+91-8545545426", "9856231475", "+91-9874561235", "8451313151" };
            //            foreach(string mobile in mobiles)
            //            {
            //                if(regex.IsMatch(mobile))
            //                {
            //                    Console.WriteLine("{0} is a valid mobile number", mobile);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("{0} is not a valid mobile number", mobile); ;
            //                }
            //            }
            //            Console.ReadKey();




            //create a example to input name, mobile and pincode check validation in C sharp

            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            Console.WriteLine("enter your pincode");
            string pincode = Console.ReadLine();

           
            bool isNameValid = ValidateName(name);
            bool isMobileNumberValid = ValidateMobileNumber(mobileNumber);
            bool isPincodeValid = ValidatePincode(pincode);

            if(isNameValid && isMobileNumberValid && isPincodeValid)
                {
                Console.WriteLine("All input are valid");
                }
            else
            {
                Console.WriteLine("Invalid input detected. Please check your inputs.");
            }
        }

        static bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("invalid name");
                return false;
            }
            Console.WriteLine("valid name");
            return true;
            
        }

        static bool ValidateMobileNumber(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber) || mobileNumber.Length != 10 || !mobileNumber.All(char.IsDigit))
            {
                Console.WriteLine("invalid mobile number");
                return false;
            }
            Console.WriteLine("valid mobile number");
            return true;
        }

        static bool ValidatePincode(string pincode)
        {
      
            if (string.IsNullOrWhiteSpace(pincode) || pincode.Length != 6 || !pincode.All(char.IsDigit))
            {
                Console.WriteLine("invalid pincode number");
                return false;
            }
            Console.WriteLine("valid pincode number");
            return true;
        }
    }
}
    
