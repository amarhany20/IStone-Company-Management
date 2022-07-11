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
    /// Interaction logic for W12_AllCurrentlyJobs.xaml
    /// </summary>
    public partial class W12_AllCurrentlyJobs : Window
    {
        public W12_AllCurrentlyJobs()
        {
            InitializeComponent(); dg();
        }
        void dg()
        {

            SqlDataAdapter da = Methods.da(textbox_Search.Text.Trim(),checkbox_SearchByFirstLetter.IsChecked==true,checkbox_SearchByDate.IsChecked==true,false,false,false,false,false,true,false,false,false,false,false,false);
            DataTable dt = new DataTable();
            dt.Clear(); 
            try
            {
                da.Fill(dt);
                SqlVariables.con.Close();
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                datagrid_AllJobs.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {


            }
            
        }
        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            dg();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
