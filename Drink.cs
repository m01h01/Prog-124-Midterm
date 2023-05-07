using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal abstract class Drink : Product
    {
        public enum drinksize {Short, Tall, Grade, Venti, Trenta};

        drinksize _drinksize;

        protected Drink(string name, double price, int points, drinksize size) : base(name, price, points)
        {
            Drinksize = size;
        }
        internal drinksize Drinksize { get => _drinksize; set => _drinksize = value; }
        public override string ToString()
        {
            return $"{base.ToString()} - {Drinksize}";
        }
    }
}
