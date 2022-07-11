using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W02_MainMenu.xaml
    /// </summary>
    public partial class W02_MainMenu : Window
    {
        public W02_MainMenu()
        {
            InitializeComponent();
            label_CurrentUser.Content = $"Welcome {Public_Variables.SignedInUsername}. Your ID is{Public_Variables.signedInID}";
            if (Public_Variables.rank == 2)
            {
                button_AllCustomers.Visibility = Visibility.Hidden;
                button_AllUsers.Visibility = Visibility.Hidden;
                button_AllOrders.Visibility = Visibility.Hidden;
                button_Payments.Visibility = Visibility.Hidden;
                label_AdminFeatures.Visibility = Visibility.Hidden;
                button_AllJobs.Visibility = Visibility.Hidden;
                button_IncomingMarbles.Visibility = Visibility.Hidden;
                button_OutGoingMarbles.Visibility = Visibility.Hidden;
            }
        }
        void cleaningVariables()
        {

            Public_Variables.creationFullName = "";
            Public_Variables.creationMobile1 = "";
            Public_Variables.creationMobile2 = "";
            Public_Variables.creationEmail = "";
            Public_Variables.creationNotes = "";
            Public_Variables.creationDaysRequested = "";
            Public_Variables.creationMarbleAmount = "";
            Public_Variables.creationMarbleLength = 0;
            Public_Variables.creationMarbleNotes = "";
            Public_Variables.creationMarbleType = "";
            Public_Variables.creationMarbleWidth = 0;
            Public_Variables.creationMeter = 0;
            Public_Variables.creationOrder = "";
            Public_Variables.creationPaymentAmount =0;
            Public_Variables.creationPaymentName = "";
            Public_Variables.creationPrice = 0;
            Public_Variables.creationType = "";
            Public_Variables.selectedOrderID = 0;
            Public_Variables.selectedCustomerID = 0;
            Public_Variables.selectedOrderName = "";
            Public_Variables.selectedCustomerName = "";
            Public_Variables.firstTime = true;
            Public_Variables.selectionDone = false;
            Public_Variables.isAdminSelectingAChange = false;

        }
        private void button_LogOut_Click(object sender, RoutedEventArgs e)
        {
            Public_Variables.signedInID = 0;
            Public_Variables.SignedInUsername = "";
            cleaningVariables();
            W01_SignIn t = new W01_SignIn();
            t.Show();
            this.Close();
        }
        private void button_NewOrder_Click(object sender, RoutedEventArgs e)
        {
            
            W03_Customer_Selection t = new W03_Customer_Selection();
            t.ShowDialog();
            if (Public_Variables.selectionDone == true )
            {
                Public_Variables.selectionDone = false;
                W06_Order_Creation t2 = new W06_Order_Creation();
                t2.ShowDialog();
                cleaningVariables();
            }
            else
            {

                cleaningVariables();
            }
        }





        private void button_CurrentOrders_Click(object sender, RoutedEventArgs e)
        {
            W04_Order_Selection t = new W04_Order_Selection();
            t.ShowDialog();
            cleaningVariables();
        }




        private void button_CurrentJobs_Click(object sender, RoutedEventArgs e)
        {
            W12_AllCurrentlyJobs t = new W12_AllCurrentlyJobs();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_AllUsers_Click(object sender, RoutedEventArgs e)
        {
            W19_Admin_User_Edit t = new W19_Admin_User_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_AllCustomers_Click(object sender, RoutedEventArgs e)
        {
            W13_Admin_Customer_Edit t = new W13_Admin_Customer_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_AllOrders_Click(object sender, RoutedEventArgs e)
        {
            W14_Admin_Order_Edit t = new W14_Admin_Order_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_AllJobs_Click(object sender, RoutedEventArgs e)
        {
            W15_Admin_Job_Edit t = new W15_Admin_Job_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_Payments_Click(object sender, RoutedEventArgs e)
        {
            W16_Admin_Payment_Edit t = new W16_Admin_Payment_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_IncomingMarbles_Click(object sender, RoutedEventArgs e)
        {
            W17_Admin_Incoming_Marble_Edit t = new W17_Admin_Incoming_Marble_Edit();
            t.ShowDialog();
            cleaningVariables();
        }

        private void button_OutGoingMarbles_Click(object sender, RoutedEventArgs e)
        {
            W18_Admin_Outgoing_Marble_Edit t = new W18_Admin_Outgoing_Marble_Edit();
            t.ShowDialog();
            cleaningVariables();
        }
    }
}
