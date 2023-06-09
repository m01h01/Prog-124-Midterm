﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for MemeberInformation.xaml
    /// </summary>
    public partial class MemeberInformation : Window
    {
        public MemeberInformation()
        {
            InitializeComponent();
            lbMemberInfo.ItemsSource = Data.Members;
            RbRegularMember.IsChecked = true;
        }

        private void tbAddMember_Click(object sender, RoutedEventArgs e)
        {
            //get the info from all the text boxes and radio button
            //conditions are made

            bool isRegularMember = RbRegularMember.IsChecked.Value;
            bool isGoldMember = RbGoldMember.IsChecked.Value;

            string fname = tbFname.Text;
            string lname = tbLname.Text;
            bool isNotEmptyTextBox = fname != "" && lname != "";

            if (isNotEmptyTextBox)
            {
                if (isRegularMember)
                {
                    RegularMember regularMember = new RegularMember(fname, lname);
                    Data.AddMemberToCollection(regularMember);
                }
                else if (isGoldMember)
                {
                    GoldMember goldMember = new GoldMember(fname, lname);
                    Data.AddMemberToCollection(goldMember);
                }
            }
            else 
            {
                MessageBox.Show("Please Enter First Name and Last Name");
            }
            tbFname.Text = "";
            tbLname.Text = "";
        }
        private void lbMemberInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //save selected index as the current member
            int selectedIndex = lbMemberInfo.SelectedIndex;
            Data.CurrentMember = Data.Members[selectedIndex];

            //the transaction of the current member shows on the listbox
            lbTransHistory.ItemsSource = Data.CurrentMember.PreviousTransation;

            lbTransHistory.Items.Refresh();
           
        }
    }
}
