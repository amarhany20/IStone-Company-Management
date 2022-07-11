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
    /// Interaction logic for W13_Admin_Customer_Edit.xaml
    /// </summary>
    public partial class W13_Admin_Customer_Edit : Window
    {
        public W13_Admin_Customer_Edit()
        {
            InitializeComponent();
            dg();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter da;


        void dg()
        {
            da = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByFirstLetter.IsChecked == true, checkbox_SearchByDate.IsChecked== true, true, false, false, false, false, false, false, false, false, false, false, true);
            dt.Clear();
            try
            {
                da.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                datagrid_Customers.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {
            }
            
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }
        private void button_DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Customers.SelectedItem;
                int customerID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string customername = dataRow.Row.ItemArray[1].ToString();
                if (MessageBox.Show($"Are u sure you want to delete \"{customername}\" customer with id : {customerID}? This will Delete all of his Orders, Jobs and Marble and all of this can't be UNDONE.", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (MessageBox.Show($"Are u sure you want to delete \"{customername}\" customer with id : {customerID}? This will Delete all of his Orders, Jobs and Marble and all of this can't be UNDONE.", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        if (MessageBox.Show($"Are u sure you want to delete \"{customername}\" customer with id : {customerID}? This will Delete all of his Orders, Jobs and Marble and all of this can't be UNDONE.", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            Methods.Deleting(true,false,false,false,false,false,false,customerID);
                            dg();
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
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.UpdateCommand = builder.GetUpdateCommand();
                    da.Update(dt);
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
                MessageBox.Show("Connection Error! \n E21 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
            }

            string query;
            int counter = 0;

            query = "Select * from Customers ";
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
                    name = reader.GetFieldValue<string>(reader.GetOrdinal("Full Name"));
                    lst.Add(id);
                    lsts.Add(name);
                    i++;
                }

                for (int i2 = 0; i2 < lst.Count; i2++)
                {
                    string query2 = $"update Orders set [Customer Name] = '{lsts[i2]}' where  CustomerID like '{lst[i2]}'";
                    string query3 = $"update Jobs set [Customer Name] = '{lsts[i2]}' where  [Customer ID] like '{lst[i2]}' update Marble set Customer_Name = '{lsts[i2]}' where  Customer_ID like '{lst[i2]}' update Payments set Customer_Name = '{lsts[i2]}' where  Customer_ID like '{lst[i2]}'";
                    SqlCommand command2 = new SqlCommand(query2, SqlVariables.con);
                    SqlCommand command3 = new SqlCommand(query3, SqlVariables.con);
                    SqlVariables.con.Close();
                    SqlVariables.con.Open();
                    command2.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    SqlVariables.con.Open();
                    command3.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    counter++;

                }
                MessageBox.Show($"Refreshing Done , All Customer Names have been changed back in all other tables in Database \n Debug : {counter} reads happened!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Connection Error!  \n E028 \n " + ex);
            }
        }
        private void button_SelectUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Customers.SelectedItem;
                int customerID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string customername = dataRow.Row.ItemArray[1].ToString();
                W20_User_Selection t = new W20_User_Selection();
                t.ShowDialog();
                if (Public_Variables.selectionDone)
                {
                    try
                    {
                        Public_Variables.selectionDone = false;
                        string query = $"Update Customers set UserID = '{Public_Variables.selectedUserId}' , Username = '{Public_Variables.selectedUsername}' where ID like '{customerID}'";
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
                        MessageBox.Show(" Connection Error!  \n E031 \n " + ex);
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

        private void datagrid_Customers_BeginningEdit(object sender, System.Windows.Controls.DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Customers.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                dg();
            }
            if (datagrid_Customers.CurrentColumn.DisplayIndex == 6)
            {

                MessageBox.Show("Date can't be edited");
                dg();
            }
            if (datagrid_Customers.CurrentColumn.DisplayIndex == 8)
            {

                MessageBox.Show("UserId Can't be edited");
                dg();
            }
            if (datagrid_Customers.CurrentColumn.DisplayIndex == 7)
            {

                MessageBox.Show("Username can't be edited");
                dg();
            }
        }

        private void button_CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            W05_Customer_Creation t = new W05_Customer_Creation();
            t.ShowDialog();
            dg();
        }
    }
}
