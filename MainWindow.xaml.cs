using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Name: Monika Heang
        //Date: 05/09/2023
        //Assignment: Prog 124 Midterm
        public MainWindow()
        {
            InitializeComponent();
            lbCollectionOfProducts.ItemsSource = Data.Products;
            cbMemberInfo.ItemsSource = Data.Members;

            //always make sure listbox and combobox is selected
            cbMemberInfo.SelectedIndex = 0;
            lbCollectionOfProducts.SelectedIndex = 0;

        }
        private void btnAddNewProduct_Click_1(object sender, RoutedEventArgs e)
        {
            new AddNewProductWindow().Show();
        }//button Add new product

        private void btnMemberInformation_Click(object sender, RoutedEventArgs e)
        {
            new MemeberInformation().Show();
        }//button Member Information

        private void lbCollectionOfProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //make selection change in the listbox of product, then store it as CurrentProduct
            int selectedIndex = lbCollectionOfProducts.SelectedIndex;
            Data.CurrentProduct = Data.Products[selectedIndex];

        }
        private void cbMemeberInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // make selection change in the combo box of member, then store it as CurrentMember
            int selected = cbMemberInfo.SelectedIndex;
            Data.CurrentMember = Data.Members[selected];

            //when combo box selection change, the previous transaction of current member
            //appear on the listbox
            lbCurrentTransaction.ItemsSource = Data.CurrentMember.PreviousTransation;

            //also make the point amount of current member appear on the label
            LabelPointsCount.Content = Data.CurrentMember.PointsAmount;

        }

        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            //add product of the selected member to the prior purchases
            Data.CurrentMember.AddProduct(Data.CurrentProduct);

            //adding points of selected product to the point amount of current member
            Data.CurrentMember.AddPoints(Data.CurrentProduct);

            //the transaction that belong to the current member appears on the listbox
            lbCurrentTransaction.ItemsSource = Data.CurrentMember.PreviousTransation;

            LabelPointsCount.Content = Data.CurrentMember.PointsAmount;

            lbCurrentTransaction.Items.Refresh();
            cbMemberInfo.Items.Refresh();

        }

        private void btnUsePoint_Click(object sender, RoutedEventArgs e)
        {
            //add product of the selected member to the prior purchases
            Data.CurrentMember.AddProduct(Data.CurrentProduct);

            //deduct points of product from the CurrentMemebr's point amount
            Data.CurrentMember.DeductPoints(Data.CurrentProduct);

            lbCurrentTransaction.ItemsSource = Data.CurrentMember.PreviousTransation;

            LabelPointsCount.Content = Data.CurrentMember.PointsAmount;

            lbCurrentTransaction.Items.Refresh();
            cbMemberInfo.Items.Refresh();
        }
    }//namespace
}//class
