using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog_124_Midterm
{
    /// <summary>
    /// Interaction logic for AddNewProductWindow.xaml
    /// </summary>
    public partial class AddNewProductWindow : Window
    {
        public AddNewProductWindow()
        {
            InitializeComponent();
            PopulateSizeComboBox();
            lbProductInfoDisplay.ItemsSource = Data.Products;
        }
        public void PopulateSizeComboBox()
        {
            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;

        }
        public void Clear()
        {
            tbName.Text = "";
            tbPrice.Text = "";
            tbPoints.Text = "";
            tbRoastOrTea.Text = "";
            tbGiftCard.Text = "";
        }
        private void btnAddCoffee_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);

            Coffee.drinksize size = (Coffee.drinksize)cbSize.SelectedIndex;
            string roastOrtea = tbRoastOrTea.Text;

            Coffee coffee = new Coffee(name, price, points, size, roastOrtea);

            Data.AddProductToCollection(coffee);
            Clear();
        }

        private void btnAddTea_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);

            Tea.drinksize size = (Tea.drinksize)cbSize.SelectedIndex;
            string roastOrtea = tbRoastOrTea.Text;

            Data.AddProductToCollection(new Tea(name, price, points, size , roastOrtea));
            Clear();
        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);

            bool isHeated = cbIsHeated.IsChecked.Value;
            bool hasDiary = cbHasDiaryOrCombo.IsChecked.Value;

            Data.AddProductToCollection(new Breakfast(name, price, points, isHeated, hasDiary));
            Clear();
        }

        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);

            bool isHeated = cbIsHeated.IsChecked.Value;
            bool isCombo = cbHasDiaryOrCombo.IsChecked.Value;

            Data.AddProductToCollection(new Lunch(name, price, points, isHeated, isCombo));
            Clear();

        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);
            string color = tbColorOrStyle.Text;

            Data.AddProductToCollection(new Tumblurs(name, price, points, color));
            Clear();

        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);
            string style = tbColorOrStyle.Text;

            Data.AddProductToCollection(new Mug(name, price, points, style));
            Clear();
        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int points = int.Parse(tbPoints.Text);
            int amount = int.Parse(tbGiftCard.Text);

            Data.AddProductToCollection(new GiftCard(name, price, points, amount));
            Clear();
        }
    }
}
