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
            string roastOrtea = tbRoastOrTea.Text;
            bool isNameNotEmpty = name != "";
            bool isRoastOrTeatNotEmpty = roastOrtea != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    if (isRoastOrTeatNotEmpty)
                    {
                        Coffee.drinksize size = (Coffee.drinksize)cbSize.SelectedIndex;

                        Coffee coffee = new Coffee(name, price, points, size, roastOrtea);

                        Data.AddProductToCollection(coffee);

                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter type of Roast");
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else 
            {
                MessageBox.Show("Please enter Name");
            }
        }

        private void btnAddTea_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string roastOrtea = tbRoastOrTea.Text;
            bool isNameNotEmpty = name != "";
            bool isRoastOrTeatNotEmpty = roastOrtea != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    if (isRoastOrTeatNotEmpty)
                    {
                        Tea.drinksize size = (Tea.drinksize)cbSize.SelectedIndex;
                        
                        Data.AddProductToCollection(new Tea(name, price, points, size, roastOrtea));
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter type of Tea");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else
            {
                MessageBox.Show("Please enter Name");
            }
        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            bool isNameNotEmpty = name != "";
            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            bool isHeated = cbIsHeated.IsChecked.Value;
            bool hasDiary = cbHasDiaryOrCombo.IsChecked.Value;

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    Data.AddProductToCollection(new Breakfast(name, price, points, isHeated, hasDiary));
                    Clear();
                }
                else
                { 
                    MessageBox.Show("Please enter number only for Price and Points"); 
                }
            }
            else 
            {
                MessageBox.Show("Please enter Name");
            }
        }
        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            bool isNameNotEmpty = name != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            bool isHeated = cbIsHeated.IsChecked.Value;
            bool hasDiary = cbHasDiaryOrCombo.IsChecked.Value;

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    Data.AddProductToCollection(new Lunch(name, price, points, isHeated, hasDiary));
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else
            {
                MessageBox.Show("Please enter Name");
            }
        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            bool isNameNotEmpty = name != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            string color = tbColorOrStyle.Text;
            bool isColor = color != "";

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    if (isColor)
                    {
                        Data.AddProductToCollection(new Tumblurs(name, price, points, color));
                        Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Please choose Color for Tumblur");
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else 
            {
                MessageBox.Show("Please enter Name");
            }
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            bool isNameNotEmpty = name != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            string style = tbColorOrStyle.Text;
            bool isStyle = style != "";

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    if (isStyle)
                    {
                        Data.AddProductToCollection(new Mug(name, price, points, style));
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please choose Style for Mug");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else
            {
                MessageBox.Show("Please enter Name");
            }
        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            bool isNameNotEmpty = name != "";

            double price = 0;
            bool isPrice = double.TryParse(tbPrice.Text, out price);

            int points = int.Parse(tbPoints.Text);
            bool isPoints = int.TryParse(tbPrice.Text, out points);

            int amount = 0;
            bool isAmount = int.TryParse(tbGiftCard.Text, out amount);

            if (isNameNotEmpty)
            {
                if (isPrice && isPoints)
                {
                    if (isAmount)
                    {
                        Data.AddProductToCollection(new GiftCard(name, price, points, amount));
                        Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Please enter number only for Amount");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number only for Price and Points");
                }
            }
            else
            {
                MessageBox.Show("Please enter Name");
            }
        }
    }//class
}//namespace
