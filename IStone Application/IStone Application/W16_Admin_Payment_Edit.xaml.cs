using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for W16_Admin_Payment_Edit.xaml
    /// </summary>
    public partial class W16_Admin_Payment_Edit : Window
    {
        public W16_Admin_Payment_Edit()
        {
            InitializeComponent();
            datagridInfo();
        }
        SqlDataAdapter dataAdapter;
        DataTable dt = new DataTable();
        void datagridInfo()
        {
            dataAdapter = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByDate.IsChecked == true,false,false,false,false,false, false,  false,  false,  false,false,true,false,false);
            try
            {

                dt.Clear();
                dataAdapter.Fill(dt);
                datagrid_Payments.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {
            }
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            datagridInfo();
        }

        private void button_ApplyChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure you want to apply changes", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    SqlVariables.con.Open();
                    SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.UpdateCommand = builder.GetUpdateCommand();
                    dataAdapter.Update(dt);
                    SqlVariables.con.Close();
                    datagridInfo();
                }
                else
                {
                    MessageBox.Show("Canceled");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E040 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
            }
        }

        private void button_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Payments.SelectedItem;
                int paymentID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string paymentName = dataRow.Row.ItemArray[1].ToString();
                string customerName = dataRow.Row.ItemArray[3].ToString();
                string orderName = dataRow.Row.ItemArray[5].ToString();
                int amount = Convert.ToInt32(dataRow.Row.ItemArray[2].ToString());
                Methods.Deleting(false,false,false,false,false,true,false,paymentID);
                datagridInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a customer! ");
                return;
            }
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datagrid_Payments_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 3)
            {

                MessageBox.Show("Customer Name can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 4)
            {

                MessageBox.Show("Customer ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 5)
            {

                MessageBox.Show("Order Name can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 6)
            {

                MessageBox.Show("Order ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 7)
            {

                MessageBox.Show("Date can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 8)
            {

                MessageBox.Show("Username can't be edited!");
                datagridInfo();
            }
            if (datagrid_Payments.CurrentColumn.DisplayIndex == 9)
            {

                MessageBox.Show("User ID can't be edited!");
                datagridInfo();
            }
        }
    }
}
