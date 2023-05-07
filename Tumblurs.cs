using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Tumblurs : Merchandise
    {
        string _color;
        public Tumblurs(string name, double price, int points, string color) : base(name, price, points)
        {
            Color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Color: {Color}";
        }
    }
}
