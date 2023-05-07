using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Mug : Merchandise
    {
        string _design;
        public Mug(string name, double price, int points, string design) : base(name, price, points)
        {
            Design = design;
        }

        public string Design { get => _design; set => _design = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Design: {Design}";
        }
    }
}
