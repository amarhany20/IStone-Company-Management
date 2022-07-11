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
    /// Interaction logic for W17_Admin_Incoming_Marble_Edit.xaml
    /// </summary>
    public partial class W17_Admin_Incoming_Marble_Edit : Window
    {
        public W17_Admin_Incoming_Marble_Edit()
        {
            InitializeComponent();
            datagridInfo();
        }
        SqlDataAdapter dataAdapter;
        DataTable dt = new DataTable();
        void datagridInfo()
        {
            dataAdapter = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByDate.IsChecked == true, false, false, false, false, false, false, false, true, false, false,false, false, false);
            try
            {

                dt.Clear();
                dataAdapter.Fill(dt);
                datagrid_Marble.ItemsSource = dt.DefaultView;
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
                MessageBox.Show("Connection Error! \n E046 \n " + ex);
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
                DataRowView dataRow = (DataRowView)datagrid_Marble.SelectedItem;
                int ID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                Methods.Deleting(false,false,false,false,true,false,false,ID);
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

        private void datagrid_Marble_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 0)
            {

                MessageBox.Show("ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 7)
            {

                MessageBox.Show("Customer Name can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 8)
            {

                MessageBox.Show("Customer ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 9)
            {

                MessageBox.Show("Order Name can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 10)
            {

                MessageBox.Show("Order ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 13)
            {

                MessageBox.Show("Date can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 11)
            {

                MessageBox.Show("Username can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 12)
            {

                MessageBox.Show("User ID can't be edited!");
                datagridInfo();
            }
            if (datagrid_Marble.CurrentColumn.DisplayIndex == 5)
            {

                MessageBox.Show("area can't be edited!");
                datagridInfo();
            }
        }
    }
}
