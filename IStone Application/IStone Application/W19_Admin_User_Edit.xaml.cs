using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W19_Admin_User_Edit.xaml
    /// </summary>
    public partial class W19_Admin_User_Edit : Window
    {
        public W19_Admin_User_Edit()
        {
            InitializeComponent(); dg();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter dataAdapter;
        void dg()
        {
            dataAdapter = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByFirstLetter.IsChecked == true, false, false, false, false, false, false, false, false, false, false, false, false, true);
            dt.Clear();
            try
            {
                dataAdapter.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                datagrid_Users.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {
            }
           
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }
        private void button_DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Users.SelectedItem;
                int userID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string username = dataRow.Row.ItemArray[1].ToString();
                if (userID == Public_Variables.signedInID)
                {
                    MessageBox.Show("You can't delete your current signed in User, Please sign in from another Admin User to delete the currently selected used!");
                    return;
                }
                if (MessageBox.Show("Are you sure?","Confirmation",MessageBoxButton.YesNo)== MessageBoxResult.Yes)
                {
                    Methods.Deleting(false, true, false, false, false, false, false, userID);
                    dg();
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
        public bool setadmin = false;
        private void button_SetAdmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Users.SelectedItem;
                int userID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string username = dataRow.Row.ItemArray[1].ToString();
                SetAdminOrWorker(true, username, userID); dg();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a user");
            }
            
        }
        private void button_SetWorker_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Users.SelectedItem;
                int userID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string username = dataRow.Row.ItemArray[1].ToString();
                SetAdminOrWorker(false, username, userID);
                dg();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a user");
            }
            
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
                string query;
                int counter = 0;
                query = "Select * from Users ";
                SqlCommand command = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                int i = 0;
                string name;
                int id;
                List<int> lst = new List<int>();
                List<string> lsts = new List<string>();
                while (reader.Read())
                {
                    id = reader.GetFieldValue<int>(reader.GetOrdinal("ID"));
                    name = reader.GetFieldValue<string>(reader.GetOrdinal("Username"));
                    lst.Add(id);
                    lsts.Add(name);
                    i++;
                }
                for (int i2 = 0; i2 < lst.Count; i2++)
                {
                    string query2 = $"update Orders set Username = '{lsts[i2]}' where  UserID like '{lst[i2]}'";
                    string query3 = $"update Customers set Username = '{lsts[i2]}' where  UserID like '{lst[i2]}' update Payments set Username = '{lsts[i2]}' where User_ID like '{lst[i2]}'   update Marble set Username = '{lsts[i2]}' where User_ID like '{lst[i2]}' update Jobs set Username = '{lsts[i2]}' where UserID like '{lst[i2]}'";
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
                MessageBox.Show($"Refreshing Done , All User Names have been changed back in all other tables in Database \n Debug : {counter} reads happened!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E025 \n " + ex);
                SqlVariables.con.Close();
            }
        }
        private void datagrid_Users_BeginningEdit(object sender, System.Windows.Controls.DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Users.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                dg();
            }
            if (datagrid_Users.CurrentColumn.DisplayIndex == 4)
            {
                MessageBox.Show("You can't edit actual rank please. Please edit it using the buttons down");
                dg();
            }
        }
        public static void SetAdminOrWorker(bool isAdmin, string username, int userID)
        {
            try
            {
                if (userID == Public_Variables.signedInID)
                {
                    MessageBox.Show("You can't edit your rank you have to sign in from another admin account");
                    return;
                }

                if (isAdmin)
                {
                    if (MessageBox.Show($"Are u sure you want to set this user as ADMIN?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {

                        string query = "Update Users SET Actual_Rank = 1 where ID = @id";
                        SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@id", userID);
                        SqlVariables.con.Open();
                        cmd.ExecuteNonQuery();
                        SqlVariables.con.Close();
                        MessageBox.Show($"{username} with ID : {userID} has been set as Admin Successfully");
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show($"Are u sure you want to set this user as Worker?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        string query = "Update Users SET Actual_Rank = 2 where ID = @id";
                        SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@id", userID);
                        SqlVariables.con.Open();
                        cmd.ExecuteNonQuery();
                        SqlVariables.con.Close();
                        MessageBox.Show($"{username} with ID : {userID} has been set as Worker Successfully");
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Connection Error!  \n E023 \n " + ex);
                SqlVariables.con.Close();
                return;
            }


        }
    }
}
