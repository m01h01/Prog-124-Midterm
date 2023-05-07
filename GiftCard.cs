using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class GiftCard : Product
    {
        int _amount;
        public GiftCard(string name, double price, int points, int amount) : base(name, price, points)
        {
            _amount = amount;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Amount: {_amount}";
        }
    }
}
