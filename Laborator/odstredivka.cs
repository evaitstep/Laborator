using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
   
    class odstredivka : Pristroj, Ovladanie
    {

        public override void VypisDetailniInfo()
        {
            base.VypisInfo();
            Console.WriteLine("Jsme odstredivka");
            base.VypisStav();
        }
        public void Zapni()
        {
            zapnuto = true;
        }
        public void Vypni()
        {
            zapnuto = false;
        }
    
    }
}
