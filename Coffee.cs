using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Coffee : Drink
    {
        string _typeOfRoast;
        public Coffee(string name, double price, int points, drinksize size, string typeOfRoast) : base(name, price, points, size)
        {
            _typeOfRoast = typeOfRoast;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {_typeOfRoast}";
        }
    }
}
