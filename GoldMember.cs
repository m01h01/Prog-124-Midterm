using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override void AddPoints(Product product)
        {
            PointsAmount += Product.Points + 50;
           
        }

        public override void DeductPoints(Product product)
        {
            PointsAmount -= Product.Points / 2;
           
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
