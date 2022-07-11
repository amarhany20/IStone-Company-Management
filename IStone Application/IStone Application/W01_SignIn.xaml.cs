using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class W01_SignIn : Window
    {
        public W01_SignIn()
        {
            InitializeComponent();
            textbox_IP.Text = "192.168.1.16";
            SqlVariables.SetIp(textbox_IP.Text.Trim());
            FillingRanks();
        }
        void LogginIn()
        {
            MessageBox.Show($"Welcome {Public_Variables.SignedInUsername}! Your ID is {Public_Variables.signedInID}.");
            W02_MainMenu t = new W02_MainMenu();
            this.Close();
            t.Show();
        }
        void FillingRanks()
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("Admin");
            list.Add("Worker");
            combobox_Rank.ItemsSource = list;
            combobox_Rank.SelectedIndex = 1;
        }
        private void button_Login_Click(object sender, RoutedEventArgs e)
        {
            if (Methods.LogIn(textbox_LoginUsername.Text.Trim(), passwordbox_LoginPassword.Password.Trim()))
            {
                LogginIn();
            }
        }
        private void button_RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            int rank = 2;
            if (combobox_Rank.SelectedIndex == 0)
            {
                rank = 1;
            }
            Methods.Register(textbox_RegisterUsername.Text.Trim(), passwordbox_RegisterPassword.Password.Trim(), passwordbox_RegisterRepeatePassword.Password.Trim(), rank);
            if (Methods.LogIn(textbox_RegisterUsername.Text.Trim(), passwordbox_RegisterPassword.Password.Trim()))
            {
                LogginIn();
            }
        }

        private void button_IP_Click(object sender, RoutedEventArgs e)
        {
            SqlVariables.SetIp(textbox_IP.Text.Trim());
            MessageBox.Show(SqlVariables.ipv4 + " has been set like : " + textbox_IP.Text.Trim());
        }
    }
}
