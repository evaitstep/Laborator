using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
    abstract class Pristroj
    {
        protected bool zapnuto;
        public string Nazev;
        public abstract void VypisDetailniInfo();
        public virtual void VypisInfo()

        {
            Console.WriteLine("Pristroj jehoz nazev je {0}", Nazev);
        }
        protected void VypisStav()
        {
            Console.WriteLine("Zapnuto: {0}", zapnuto);
        }

    }
}
