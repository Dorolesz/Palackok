using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Palack
    {
        //Adattag
        private string ital;
        private int maxUrtartalom; // ml
        private int jelenlegiUrtartalom; // ml

        //konstruktor
        public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1)
        {
            this.Ital = ital;
            this.MaxUrtartalom = maxUrtartalom;
            this.JelenlegiUrtartalom = jelenlegiUrtartalom;
        }

        //Property
        public string Ital { get => ital; set => ital = value; }
        public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }
        public int JelenlegiUrtartalom { get => jelenlegiUrtartalom; set => jelenlegiUrtartalom = value; }

        public void MaximumUrtartalom(int ml)
        {
            if (jelenlegiUrtartalom > maxUrtartalom)
            {
                jelenlegiUrtartalom = maxUrtartalom;
            }else
            {
                jelenlegiUrtartalom = ml;
            }
        }

        public double Suly()
        {
            return (maxUrtartalom / 35.0) + jelenlegiUrtartalom;
        }
        public override string ToString()
            {
                return $" Palack, benne lévő ital: {ital},  jelenleg {jelenlegiUrtartalom} ml van benne, maximum {maxUrtartalom} ml fér bele.";
            }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Palack))
            {
                return false;

            }
                Palack other = (Palack)obj;
                return Ital == other.Ital && MaxUrtartalom == other.MaxUrtartalom && JelenlegiUrtartalom == other.JelenlegiUrtartalom;
        }


        public void HozzaOnt(Palack masikPalack)
        {
            if (masikPalack == null || masikPalack.JelenlegiUrtartalom == 0)
                return;
            
            int ujUrtartalom = JelenlegiUrtartalom + masikPalack.JelenlegiUrtartalom;
            JelenlegiUrtartalom = ujUrtartalom;

            if (Ital == null)
            {
                Ital = masikPalack.Ital;
            }
            else if (Ital != masikPalack.Ital)
            {
                Ital = "keverek";
            }
        }
    }

}
