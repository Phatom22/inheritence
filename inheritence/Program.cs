using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            Chef chef2 = new Chef();
            ItalianChef chef3 = new ItalianChef();

            Console.WriteLine("this is now from normal chef");
            chef1.MakeSalad();
            chef2.MakeChicken();
            chef3.MakeChicken();

            Console.WriteLine("this is now from italian chef");
            chef3.MakeChicken();
            chef3.MakeSalad();

            
            //freeze screen
            Console.ReadLine();
        }
    }
}
