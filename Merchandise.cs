using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal abstract class Merchandise : Product
    {
        protected Merchandise(string name, double price, int points) : base(name, price, points)
        {
        }
    }
}
