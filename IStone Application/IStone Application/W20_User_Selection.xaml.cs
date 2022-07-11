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
    /// Interaction logic for W20_User_Selection.xaml
    /// </summary>
    public partial class W20_User_Selection : Window
    {
        public W20_User_Selection()
        {
            InitializeComponent(); dg();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        void dg()
        {
            da = Methods.da(textbox_Search.Text.Trim(), checkbox_SearchByFirstLetter.IsChecked == true, false, false, false, false, false, false, false, false, false, false, false, false, true);
            dt.Clear();
            da.Fill(dt);
            datagrid_Users.ItemsSource = dt.DefaultView;
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }
        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_SelectUser_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = (DataRowView)datagrid_Users.SelectedItem;
            int id = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
            string name = dataRow.Row.ItemArray[1].ToString();
            if (MessageBox.Show($"Are u sure you want to select \"{name}\" User with id : {id}?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Public_Variables.selectedUserId = id;
                Public_Variables.selectedUsername = name;
                Public_Variables.selectionDone = true;
                this.Close();
            }
        }
    }
}
