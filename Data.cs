using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal static class Data
    {
        private static ObservableCollection<Member> _members;
        private static ObservableCollection<Product> _products;
        private static Product currentProduct = null;
        private static Member currentMember = null;

        static Data() 
        { 
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>();
           
        }
        public static ObservableCollection<Member> Members { get => _members; }
        public static Product CurrentProduct { get => currentProduct; set => currentProduct = value; }
        public static Member CurrentMember { get => currentMember; set => currentMember = value; }
        public static ObservableCollection<Product> Products { get => _products; }
        
        public static void AddMemberToCollection(Member member)
        {
            _members.Add(member);
        }
        public static void AddProductToCollection(Product product)
        {
            _products.Add(product);
        }

        //And could I ask when should I use these two data class method?
        public static void UpdateCurrentProduct(Product product)
        {
            product = currentProduct;
        }
        public static void UpdateCurrentMember(Member member)
        {
            member = currentMember;
           
        }

    }
}
