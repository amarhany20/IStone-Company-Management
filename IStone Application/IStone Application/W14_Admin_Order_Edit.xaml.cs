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
    /// Interaction logic for W14_Admin_Order_Edit.xaml
    /// </summary>
    public partial class W14_Admin_Order_Edit : Window
    {
        public W14_Admin_Order_Edit()
        {
            InitializeComponent();
            dg();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter dataAdapter;
        void dg()
        {
            dataAdapter = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByFirstLetter.IsEnabled == true, checkbox_SearchByDate.IsChecked == true, false, true, false, false, false, false, false, false, false, false, false, false);
            dt.Clear();
            try
            {
                dataAdapter.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                datagrid_Orders.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {

            }
            
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }


        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
                    dg();
                }
                else
                {
                    MessageBox.Show("Canceled");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E28 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
            }

            string query;
            int counter = 0;

            query = "Select * from Orders ";
            SqlCommand command = new SqlCommand(query, SqlVariables.con);
            SqlVariables.con.Open();
            SqlDataReader reader;
            reader = command.ExecuteReader();
            int i = 0;
            string name;
            int id;
            List<int> lst = new List<int>();
            List<string> lsts = new List<string>();
            try
            {
                while (reader.Read())
                {
                    id = reader.GetFieldValue<int>(reader.GetOrdinal("ID"));
                    name = reader.GetFieldValue<string>(reader.GetOrdinal("Order Name"));
                    lst.Add(id);
                    lsts.Add(name);



                    i++;
                }

                for (int i2 = 0; i2 < lst.Count; i2++)
                {
                    string query2 = $"update Jobs set OrderName = '{lsts[i2]}' where  OrderID like '{lst[i2]}'";
                    SqlCommand command2 = new SqlCommand(query2, SqlVariables.con);
                    SqlVariables.con.Close();
                    SqlVariables.con.Open();
                    command2.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    counter++;
                    string query3 = $"update Marble set Order_Name = '{lsts[i2]}' where  Order_ID like '{lst[i2]}'";
                    SqlCommand command3 = new SqlCommand(query3, SqlVariables.con);
                    SqlVariables.con.Close();
                    SqlVariables.con.Open();
                    command2.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    string query4 = $"update Payments set Order_Name = '{lsts[i2]}' where  Order_ID like '{lst[i2]}'";
                    SqlCommand command4 = new SqlCommand(query3, SqlVariables.con);
                    SqlVariables.con.Close();
                    SqlVariables.con.Open();
                    command2.ExecuteNonQuery();
                    SqlVariables.con.Close();

                }
                MessageBox.Show($"Refreshing Done , All Order Names have been changed back in all other tables in Database \n Debug : {counter} reads happened!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E030 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
            }
        }

        private void button_DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Orders.SelectedItem;
                int id = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string name = dataRow.Row.ItemArray[1].ToString();
                if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Order with id : {id}? All of it's Jobs and incoming Marble will be deleted Permenantly and this can't be undone", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Order with id : {id}? All of it's Jobs and incoming Marble will be deleted Permenantly and this can't be undone", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Order with id : {id}? All of it's Jobs and incoming Marble will be deleted Permenantly and this can't be undone", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            if (Methods.Deleting(false,false,true,false,false,false,false,id))
                            {
                                MessageBox.Show("Selected order has been deleted successfully");
                                dg();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Canceled");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Canceled");
                    }
                }
                else
                {
                    MessageBox.Show("Canceled");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a customer! ");
                return;
            }
        }

        private void datagrid_Orders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 2)
            {

                MessageBox.Show("Customer ID Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 3)
            {

                MessageBox.Show("Customer name Can't be edited. Please edit it from all customers window");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 4)
            {

                MessageBox.Show("Date can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 6)
            {
                MessageBox.Show("Username Can't be edited. Please edit it in all users window");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 7)
            {
                MessageBox.Show("Username ID Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 9)
            {
                MessageBox.Show("Total_Price Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex ==10)
            {
                MessageBox.Show("Total_Paid Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 11)
            {
                MessageBox.Show("Remaining Can't be edited");
                dg();
            }

        }
        private void button_SelectUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Orders.SelectedItem;
                int orderID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string ordername = dataRow.Row.ItemArray[1].ToString();
                W20_User_Selection t = new W20_User_Selection();
                t.ShowDialog();
                if (Public_Variables.selectionDone)
                {
                    try
                    {
                        Public_Variables.selectionDone = false;
                        string query = $"Update Orders set UserID = '{Public_Variables.selectedUserId}' , Username = '{Public_Variables.selectedUsername}' where ID like '{orderID}'";
                        SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                        SqlVariables.con.Open();
                        cmd.ExecuteNonQuery();
                        SqlVariables.con.Close();
                        Public_Variables.selectedUserId = 0;
                        Public_Variables.selectedUsername = "";
                        dg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Connection Error!  \n E032 \n " + ex);
                        SqlVariables.con.Close();
                        Public_Variables.selectedUserId = 0;
                        Public_Variables.selectedUsername = "";
                        dg();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a customer! ");
                return;
            }
        }
        private void button_SelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Orders.SelectedItem;
                int orderID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string ordername = dataRow.Row.ItemArray[1].ToString();

                W03_Customer_Selection t = new W03_Customer_Selection();
                t.ShowDialog();
                if (Public_Variables.selectionDone)
                {


                    try
                    {//injection possible here
                        Public_Variables.selectionDone = false;
                        string query = $"Update Orders set CustomerID = '{Public_Variables.selectedCustomerID}' , [Customer Name] = '{Public_Variables.selectedCustomerName}' where ID like '{orderID}' " +

                            $"Update Payments set Customer_ID = '{Public_Variables.selectedCustomerID}' , Customer_Name = '{Public_Variables.selectedCustomerName}' where Order_ID like '{orderID}' " +

                            $"Update Marble set Customer_ID = '{Public_Variables.selectedCustomerID}' , Customer_Name = '{Public_Variables.selectedCustomerName}' where Order_ID like '{orderID}' " +

                            $" Update Jobs set [Customer ID] = '{Public_Variables.selectedCustomerID}' , [Customer Name] = '{Public_Variables.selectedCustomerName}' where OrderID like '{orderID}' ";
                        SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                        SqlVariables.con.Open();
                        cmd.ExecuteNonQuery();
                        SqlVariables.con.Close();

                        Public_Variables.selectedCustomerID = 0;
                        Public_Variables.selectedCustomerName = "";
                        dg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Connection Error!  \n E033 \n " + ex);
                        SqlVariables.con.Close();
                        Public_Variables.selectedCustomerID = 0;
                        Public_Variables.selectedCustomerName = "";
                        dg();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a customer! ");
                return;
            }
        }

        private void datagrid_Orders_BeginningEdit(object sender, System.Windows.Controls.DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 2)
            {

                MessageBox.Show("Customer ID Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 3)
            {

                MessageBox.Show("Customer name Can't be edited. Please edit it from all customers window");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 4)
            {

                MessageBox.Show("Date can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 6)
            {
                MessageBox.Show("Username Can't be edited. Please edit it in all users window");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 7)
            {
                MessageBox.Show("Username ID Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 9)
            {
                MessageBox.Show("Total Price Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 10)
            {
                MessageBox.Show("Total Paid Can't be edited");
                dg();
            }
            if (datagrid_Orders.CurrentColumn.DisplayIndex == 11)
            {
                MessageBox.Show("Remaining Can't be edited");
                dg();
            }
        }


    }
}
