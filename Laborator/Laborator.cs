using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
    partial class Laborator
    {
        public Pristroj LaboratorniPristroj1;
        public Pristroj LaboratorniPristroj2;

        public void SpustVyzkum()
        {
            Vedouci vedouci = new Vedouci("Meno Fero");

            LaboratorniPristroj1 = new Mikroskop();
            LaboratorniPristroj2 = new odstredivka();

            LaboratorniPristroj1.Nazev = "hn301";
            LaboratorniPristroj2.Nazev = "ods56";

            Ovladanie ovladani = (Ovladanie) LaboratorniPristroj1;
            ovladani.Zapni();

            LaboratorniPristroj1.VypisDetailniInfo();
            LaboratorniPristroj2.VypisDetailniInfo();

        }
    }
}
