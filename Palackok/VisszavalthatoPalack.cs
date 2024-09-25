using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class VisszavalthatoPalack : Palack
    {
        //Adattag
        private double palackdij; //Ft

        //konstruktor
        public VisszavalthatoPalack(string ital, int maxUrtartalom, int jelenlegiUrtartalom, double palackdij = 25) : base(ital, maxUrtartalom, jelenlegiUrtartalom)
        {
            this.Palackdij = palackdij;
        }

        //Property
        public double Palackdij { get => palackdij; set => palackdij = value; }

        public override string ToString()
        {
            return ($"VisszavalthatoPalack, benne lévő ital: {Ital}, jelenleg {JelenlegiUrtartalom} ml van benne, maximum {MaxUrtartalom} ml fér bele.");
        }
    }
}
