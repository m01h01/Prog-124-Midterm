using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class RegularMember : Member
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
       
        public override void AddPoints(Product product)
        {
            PointsAmount += product.Points;

        }

        public override void DeductPoints(Product product)
        {
            PointsAmount -= product.Points;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}
