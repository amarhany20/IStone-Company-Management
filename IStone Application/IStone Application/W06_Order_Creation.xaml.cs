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

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W06_Order_Creation.xaml
    /// </summary>
    public partial class W06_Order_Creation : Window
    {
        public W06_Order_Creation()
        {
            InitializeComponent();
            label_OrderName.Content = "Creating order for " + Public_Variables.selectedCustomerName + " (ID : " + Public_Variables.selectedCustomerID;
        }

        private void button_CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            Public_Variables.creationOrder = textbox_OrderName.Text.Trim();
            if (Methods.SQLInsert(false, true, false, false, false, false))
            {
                MessageBox.Show("Order Created successfully. go to current orders to add this order's Jobs, Marbles or Payments(for Admin)");
            }
            this.Close();
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
