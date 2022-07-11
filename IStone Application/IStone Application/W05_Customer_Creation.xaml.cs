using System.Windows;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W05_Customer_Creation.xaml
    /// </summary>
    public partial class W05_Customer_Creation : Window
    {
        public W05_Customer_Creation()
        {
            InitializeComponent();
        }
        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            Public_Variables.creationFullName = textbox_FullName.Text.Trim();
            Public_Variables.creationMobile1 = textbox_Mobile1.Text.Trim();
            Public_Variables.creationMobile2 = textbox_Mobile2.Text.Trim();
            Public_Variables.creationEmail = textbox_Email.Text.Trim();
            Public_Variables.creationNotes = textbox_Notes.Text.Trim();
            if (MessageBox.Show("Are you sure?","Confirmation",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (Methods.SQLInsert(true, false, false, false, false, false))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debug! (This is just a test I will remove it when I make sure that the program is working)");
                }
            }
            else
            {
                MessageBox.Show("Canceled!");
            }
           
        }
    }
}
