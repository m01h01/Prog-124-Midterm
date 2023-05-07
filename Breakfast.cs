using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Breakfast : Food
    {
        bool _hasDiary;
        public Breakfast(string name, double price, int points, bool isHeated, bool hasDiary) : base(name, price, points, isHeated)
        {
            _hasDiary = hasDiary;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Has Diary: {_hasDiary}";
        }
    }
}
