using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal abstract class Food : Product
    {
        bool _isHeated;
        protected Food(string name, double price, int points, bool isHeated) : base(name, price, points)
        {
            _isHeated = isHeated;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Is Heated: {_isHeated}";
        }
    }
}
