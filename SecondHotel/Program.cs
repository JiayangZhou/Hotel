using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction startBuilding = new Construction();
            startBuilding.Blueprint();
            Employees employee = new Cooks();

        }


    }

    public abstract class Employees
    {
        public string Name { get; set; }

        public abstract void AskWhenToRetire();

    }
    // it doesn't support multiple inheritance
    public class Cooks:Employees
    {
        public string skills { get; set; }

        public override void AskWhenToRetire()
        {
            
        }
    }

}
