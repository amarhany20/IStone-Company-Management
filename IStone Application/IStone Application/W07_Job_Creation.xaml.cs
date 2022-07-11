using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W07_Job_Creation.xaml
    /// </summary>
    public partial class W07_Job_Creation : Window
    {
        public W07_Job_Creation()
        {
            InitializeComponent();
            dg();
        }
        void dg()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = Methods.da("", false, false, false, false, false, false, true, false, false, false, false, false, false, false);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                label_Count.Content = "Count : " + dt.Rows.Count.ToString();
                int index = 0;
                index = datagrid_CurrentJobs.SelectedIndex;
                datagrid_CurrentJobs.ItemsSource = dt.DefaultView;
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }
        private void button_CreateJob_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Public_Variables.creationType = textbox_Type.Text; ;
                Public_Variables.creationMeter = double.Parse(textbox_Meters.Text);
                Public_Variables.creationPrice = double.Parse(textbox_MeterPrice.Text);
                if (Public_Variables.creationMeter > 9999 || Public_Variables.creationPrice > 9999)
                {
                    MessageBox.Show("These numbers are very big, try to decrease them.");
                    return;
                }
                if (MessageBox.Show("Are you sure? ","Confirmation",MessageBoxButton.YesNo)==MessageBoxResult.Yes)
                {

                }
                else
                {
                    return;
                }
                Public_Variables.creationDaysRequested = textbox_DaysRequested.Text;
                if (Methods.SQLInsert(false, false, true, false, false, false))
                {
                    MessageBox.Show("Job Created!");
                    textbox_Type.Text = "";
                    textbox_Meters.Text = "";
                    textbox_MeterPrice.Text = "";
                    textbox_DaysRequested.Text = "";
                    dg();
                }
            }
            catch (System.Exception x)
            {
                MessageBox.Show("Error at creaetjob mouse click \n it may be connection \n " + x);
            }
            
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
