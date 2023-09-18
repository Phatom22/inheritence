using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class ItalianChef : Chef
    {
        public void MakePasta(){
            Console.WriteLine("make macaroni");
            
            }
        public override void MakeSalad()
        {
            Console.WriteLine("the chef makes salad");
        }
    }
}
