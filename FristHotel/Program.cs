using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FristHotel
{
    class Program
    {
        public static string notHereFilePath = @"C:\Users\dengd\Ctest\notHereGuests.txt";
        static void Main(string[] args)
        {

            //WelcomeGuests();
            //NotHereGuests();
            






            Console.ReadLine();
        }





        public static void NotHereGuests()
        {
            List<Guest> notHereGuests = new List<Guest>();
            List<string> lines = File.ReadAllLines(notHereFilePath).ToList();
            foreach (string line in lines)
            {
                string[] details = line.Split(' ');

                Guest gettingInf = new Guest();

                gettingInf.FirstName = details[0];
                gettingInf.LastName = details[1];
                gettingInf.RoomNum = details[2];

                notHereGuests.Add(gettingInf);

            }
            foreach (Guest guest in notHereGuests)
            {
                Console.WriteLine($"{guest.FirstName} is not here");
            }

            //Add another two people to notHereGuests
            Guest bob = new Guest() { FirstName = "Bob", LastName = "Smith", RoomNum = "101" };
            notHereGuests.Add(bob);
            notHereGuests.Add(new Guest { FirstName = "Robert", LastName = "Smith", RoomNum = "104" });        
            
            Console.WriteLine("\nAfter two other people gone missing");
            foreach (Guest guest in notHereGuests)
            {
                Console.WriteLine($"{guest.FirstName} is not here");
            }

            //Rewrite notHereFile
            lines.Clear();
            foreach (var guest in notHereGuests)
            {
                lines.Add($"{guest.FirstName} {guest.LastName} {guest.RoomNum}");
            }
            File.WriteAllLines(notHereFilePath, lines);
        }

        public static void WelcomeGuests()
        {
            List<Guest> guests = new List<Guest>();
            Guest fabian = new Guest() { FirstName = "Fabian", LastName = "Wimmer" };
            guests.Add(fabian);
            guests.Add(new Guest { FirstName = "Jiayang", LastName = "Zhou" });
            guests.Add(new Guest { FirstName = "Harry", LastName = "Potter" });
            guests.Add(new Guest { FirstName = "Donald", LastName = "Trump" });


            foreach (var guest in guests)
            {
                Console.WriteLine($"Hej, {guest.FirstName} {guest.LastName}. Welcome to our hotel!");
            }

            /*          
            List<string> lines = File.ReadAllLines(filePath).ToList();
            
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            lines.Add("line1, line2, line3");
            File.WriteAllLines(filePath, lines);
            */
        }
    }
}
