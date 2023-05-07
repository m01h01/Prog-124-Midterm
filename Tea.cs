using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Tea : Drink
    {
        string _typeOfTea;

        public Tea(string name, double price, int points, drinksize size, string typeOfTea) : base(name, price, points, size)
        {
            _typeOfTea = typeOfTea;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_typeOfTea}";
        }
    }
}
