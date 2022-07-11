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
    /// Interaction logic for W09_Payment_Creation.xaml
    /// </summary>
    public partial class W09_Payment_Creation : Window
    {
        public W09_Payment_Creation()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            label_Title.Content = $"Payments for \"{Public_Variables.selectedOrderName}\" Order with ID: {Public_Variables.selectedOrderID} for \" {Public_Variables.selectedCustomerName}\" with ID : {Public_Variables.selectedCustomerID}";
            dg();
        }
        void dg()
        {
            try
            {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = Methods.da("",false,false,false,false,false,false,false,false,false,false,true,false,false,false);
            da.Fill(dt);
            datagrid_Payments.ItemsSource = dt.DefaultView;
        }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
}

        private void button_AddPayment_Click(object sender, RoutedEventArgs e)
        {
            if (textbox_Amount.Text.Length == 0)
            {
                MessageBox.Show("Payment Amount is empty!");
                return;
            }
            if (MessageBox.Show($"Are you sure you want to add {textbox_Name.Text.Trim()} payment with amount {textbox_Amount.Text.Trim()}", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    Public_Variables.creationPaymentName = textbox_Name.Text.Trim();
                    Public_Variables.creationPaymentAmount = double.Parse(textbox_Amount.Text.Trim());
                    if (Public_Variables.creationPaymentAmount >999999)
                    {
                        MessageBox.Show("This amount is very big");
                        return;
                    }

                    Methods.SQLInsert(false,false,false,false,true,false);
                    dg();
                    textbox_Name.Text = "";
                    textbox_Amount.Text = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Make sure you wrote the amount correctly!");
                    dg();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                    textbox_Name.Text = "";
                    textbox_Amount.Text = "";
                    dg();
                }
            }
            else
            {
                MessageBox.Show("Canceled");
                textbox_Name.Text = "";
                textbox_Amount.Text = "";
            }



        }

        private void button_DeleteSelectedPayment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)datagrid_Payments.SelectedItem;
                int paymentID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                if (MessageBox.Show("Are you sure?","Confirmation",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Methods.Deleting(false, false, false, false, false, true, false, paymentID);
                    dg();
                }
                else
                {
                    MessageBox.Show("Canceled!");
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
    }
}
