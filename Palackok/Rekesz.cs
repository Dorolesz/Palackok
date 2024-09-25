using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Rekesz
    {
        //Adattag
        private int maxTeherbiras;
        private List<Palack> palackok;

        //konstruktor
        public Rekesz(int max_teherbiras)
        {
            this.MaxTeherbiras = max_teherbiras;
            palackok = new List<Palack>();
        }

        //Property
        public double MaxTeherbiras { get => maxTeherbiras; set => maxTeherbiras = (int)value; }

        public new double Suly()
        {
            double osszSuly = 0;
            foreach (var palack in palackok)
            {
                osszSuly += palack.Suly();
            }
            return osszSuly;
        }

        public void UjPalack(Palack palack)
        {
            if (Suly() + palack.Suly() <= MaxTeherbiras) 
            {
                palackok.Add(palack);
            }
        }

        public double OsszesPenz()
        {
            double osszeg = 0;
            foreach (var palack in palackok)
            {
                if (palack is VisszavalthatoPalack visszavalthatoPalack)
                {
                    osszeg += visszavalthatoPalack.Palackdij;
                }
            }
            return osszeg;
        }
    }
}
