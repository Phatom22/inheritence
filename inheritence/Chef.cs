using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("the chef makes chicken");


        }

        public virtual void MakeSalad()
        {
            Console.WriteLine("the chef makes salad");
        }
    }
}
