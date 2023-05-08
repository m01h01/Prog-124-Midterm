using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    public abstract class Member
    {
        string _firstName;
        string _lastName;
        int _memberNumber;
        int _pointsAmount;
        DateTime _memberSince;
        public ObservableCollection<Product> _previousTransation;

        protected Member(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            Random rand = new Random();
            _memberNumber = rand.Next(1000000, 10000000);

            _memberSince = DateTime.Now;
            _previousTransation = new ObservableCollection<Product>();
        }

        public ObservableCollection<Product> PreviousTransation { get => _previousTransation;}
        public int PointsAmount { get => _pointsAmount; set => _pointsAmount = value; }

        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);
        public void AddProduct(Product product)
        { 
          _previousTransation.Add(product);
        }
        public override string ToString()
        {
            return $"{GetType().Name} - {_memberNumber} - {_firstName} {_lastName} -Reward Point(s): {PointsAmount}, Member since: {_memberSince.ToShortDateString()}"; 


        }


       
    }
}
