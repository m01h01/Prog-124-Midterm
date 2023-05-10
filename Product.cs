using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    public abstract class Product
    {
        //fields
        string _name;
        int _sku;
        double _price;
        int _points;
        static int _numberOfproducts;

        //properties
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Points { get => _points; set => _points = value;}
        public static int NumberOfproducts { get => _numberOfproducts;}

        protected Product(string name, double price, int points)
        {
            _name = name;
            _price = price;
            _points = points;

            Random rand = new Random();
            _sku = rand.Next(1000000, 10000000);

            _numberOfproducts ++;
        }
        public override string ToString()
        {
            return $"{GetType().Name} - {_sku} - {Name} - {Price.ToString("c")} - Points {_points}";
        }
    }
}
