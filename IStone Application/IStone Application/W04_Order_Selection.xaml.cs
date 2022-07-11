using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W04_Order_Selection.xaml
    /// </summary>
    public partial class W04_Order_Selection : Window
    {
        public W04_Order_Selection()
        {
            InitializeComponent();
            if (Public_Variables.rank == 2 || Public_Variables.isAdminSelectingAChange == true)
            {
                button_EndOrder.Visibility = Visibility.Hidden;

            }
            dg();
        }
        void dg()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                da = Methods.da("", false, false, false, false, true, false, false, false, false, false, false, false, false, false);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count;
                datagrid_Orders.ItemsSource = dt.DefaultView;
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_SelectOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Orders.SelectedItem;
                Public_Variables.selectedOrderID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                Public_Variables.selectedOrderName = dataRow.Row.ItemArray[1].ToString();
                Public_Variables.selectedCustomerName = dataRow.Row.ItemArray[3].ToString();
                Public_Variables.selectedCustomerID = Convert.ToInt32(dataRow.Row.ItemArray[2].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an order! ");
                return;
            }
            if (MessageBox.Show("You have selected " + Public_Variables.selectedOrderName.Trim() + " order with ID : " + Public_Variables.selectedOrderID + " for " + Public_Variables.selectedCustomerName, "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (Public_Variables.isAdminSelectingAChange)
                {
                    Public_Variables.isAdminSelectingAChange = false;
                    Public_Variables.selectionDone = true;
                    this.Close();
                    return;
                }
            }
            else
            {
                W10_Order_Status t = new W10_Order_Status();
                t.ShowDialog();
                dg();
            }
            
        }



        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_EndOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Orders.SelectedItem;
                Public_Variables.selectedOrderID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                Public_Variables.selectedOrderName = dataRow.Row.ItemArray[1].ToString();
                Public_Variables.selectedCustomerName = dataRow.Row.ItemArray[3].ToString();
                Public_Variables.selectedCustomerID = Convert.ToInt32(dataRow.Row.ItemArray[2].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an order! ");
                return;
            }
            if (MessageBox.Show("Are you sure you want to end " + Public_Variables.selectedOrderName.Trim() + " order with ID : " + Public_Variables.selectedOrderID + " for " + Public_Variables.selectedCustomerName, "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    string query = "Update Orders set [Order End] = 1 where ID = @id";
                    SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", Public_Variables.selectedOrderID);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    dg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in button_EndOrder_Click \n \n " + ex);
                    SqlVariables.con.Close();
                }
            }
            else
            {
                MessageBox.Show("Canceled!");
            }
        }
    }
}
