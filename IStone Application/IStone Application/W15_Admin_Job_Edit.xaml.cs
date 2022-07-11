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
    /// Interaction logic for W15_Admin_Job_Edit.xaml
    /// </summary>
    public partial class W15_Admin_Job_Edit : Window
    {
        public W15_Admin_Job_Edit()
        {
            InitializeComponent(); DatagridInfo();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter dataAdapter;
        void DatagridInfo()
        {
            dataAdapter = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByDate.IsChecked == true , false,false,false,false,true,false,false,false,false,false,false,false,false);
            dt.Clear();
            try
            {
                dataAdapter.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                datagrid_Jobs.ItemsSource = dt.DefaultView;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
          

        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            DatagridInfo();
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
                    DatagridInfo();
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
        }

        private void button_DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Jobs.SelectedItem;
                int id = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                string name = dataRow.Row.ItemArray[1].ToString();
                if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Jobs with id : {id}?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Jobs with id : {id}?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        if (MessageBox.Show($"Are u sure you want to delete \"{name}\" Jobs with id : {id}?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            if (Methods.Deleting(false,false,false,true,false,false,false,id))
                            {
                                MessageBox.Show("Job Deleted Successfully");
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

        //private void button_SelectOrder_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        DataRowView dataRow = (DataRowView)datagrid_Jobs.SelectedItem;
        //        int jobID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
        //        string jobname = dataRow.Row.ItemArray[1].ToString();
        //        Public_Variables.isAdminSelectingAChange = true;
        //        W04_Order_Selection t = new W04_Order_Selection();
        //        t.ShowDialog();
        //        if (Public_Variables.selectionDone)
        //        {
        //            try
        //            {
        //                Public_Variables.selectionDone = false;
        //                string query = $"Update Jobs set OrderID = '{Public_Variables.selectedOrderID}' , OrderName = '{Public_Variables.selectedOrderName}' , [Customer Name] = '{Public_Variables.selectedCustomerName}' , [Customer ID] = '{Public_Variables.selectedCustomerID}' where ID like '{jobID}'";
        //                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
        //                SqlVariables.con.Open();
        //                cmd.ExecuteNonQuery();
        //                SqlVariables.con.Close();
        //                Public_Variables.selectedOrderID = 0;
        //                Public_Variables.selectedOrderName = "";
        //                DatagridInfo();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(" Connection Error!  \n E032 \n " + ex);
        //                SqlVariables.con.Close();
        //                Public_Variables.selectedOrderID = 0;
        //                Public_Variables.selectedOrderName = "";
        //                DatagridInfo();
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please select a customer! ");
        //        return;
        //    }

        //}

        private void datagrid_Jobs_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 3)
            {

                MessageBox.Show("OrderName can't be edited, please edit the order by selecting the other order that you want to");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 4)
            {

                MessageBox.Show("OrderID Can't be edited, please edit the order by selecting the other order that you want to");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 5)
            {

                MessageBox.Show("Customer name can't be edited, Edit the order first");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 6)
            {

                MessageBox.Show("Customer ID can't be edited, Edit the order first");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 9)
            {

                MessageBox.Show("Total Price can't be edited, Edit the meter price and meters to calculate the total price");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 10)
            {

                MessageBox.Show("Date can't be edited");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 12)
            {

                MessageBox.Show("remaining days can't be edited");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 27)
            {

                MessageBox.Show("username can't be edited");
                DatagridInfo();
            }
            if (datagrid_Jobs.CurrentColumn.DisplayIndex == 28)
            {

                MessageBox.Show("userid can't be edited");
                DatagridInfo();
            }

        }


    }
}
