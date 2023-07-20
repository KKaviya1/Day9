using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<player> listplayers = new List<player>()
            {
                new player { Id =1, Name = "MSD", Team="CSK", MFee=20000.89},
                new player { Id =2, Name = "KY", Team="RCB", MFee=40000.89},
                new player { Id =3, Name = "SKK", Team="MI", MFee=35000.89},
                new player { Id =4, Name = "DK", Team="GUR", MFee=85000.89},
                new player { Id =5, Name = "VK", Team="AUST", MFee=40000.89},
            };
            Console.WriteLine("number of players are : "+ listplayers.Count);
            foreach (player player in listplayers) {

                Console.WriteLine("ID: " + player.Id);
                Console.WriteLine("Name: " + player.Name);
                Console.WriteLine("Team: " + player.Team);
                Console.WriteLine("Match Fee: " + player.MFee);
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}
