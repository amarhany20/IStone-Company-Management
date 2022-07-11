using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W03_Customer_Selection.xaml
    /// </summary>
    public partial class W03_Customer_Selection : Window
    {
        public W03_Customer_Selection()
        {
            InitializeComponent();
            dg();
        }
        private void button_Close_Click(object sender, RoutedEventArgs e)
        {
            Public_Variables.selectedOrderID = 0;
            Public_Variables.selectedOrderName = "";
            Public_Variables.selectedCustomerName = "";
            Public_Variables.selectedCustomerID = 0;
            this.Close();
        }
        private void button_SelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Customers.SelectedItem;
                Public_Variables.selectedCustomerID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                Public_Variables.selectedCustomerName = dataRow.Row.ItemArray[1].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a customer! ");
                return;
            }
            if (MessageBox.Show("You have selected " + Public_Variables.selectedCustomerName.Trim() + " with ID : " + Public_Variables.selectedCustomerID, "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Public_Variables.selectionDone = true;
                this.Close();
            }
        }
        private void button_CreateANewCustomer_Click(object sender, RoutedEventArgs e)
        {
            W05_Customer_Creation t = new W05_Customer_Creation();
            t.ShowDialog();
            dg();
        }
        void dg()
        {
            try
            {



                SqlDataAdapter da = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByFirstLetter.IsChecked == true, checkbox_SearchByDate.IsChecked == true, true, false, false, false, false, false, false, false, false, false, false, false);
                DataTable dt = new DataTable();
                dt.Clear();
                try
                {
                    da.Fill(dt); 
                    SqlVariables.con.Close();
                    label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                    datagrid_Customers.ItemsSource = dt.DefaultView;
                }
                catch (Exception)
                {

                }
                
                
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }
    }
}

