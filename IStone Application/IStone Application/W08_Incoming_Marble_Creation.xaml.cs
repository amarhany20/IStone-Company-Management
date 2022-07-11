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
    /// Interaction logic for W08_Incoming_Marble_Creation.xaml
    /// </summary>
    public partial class W08_Incoming_Marble_Creation : Window
    {
        public W08_Incoming_Marble_Creation()
        {
            InitializeComponent();
            dg();
        }
        void dg()
        {
            try
            {

            SqlDataAdapter da = Methods.da("",false,false,false,false,false,false,false,false,false,true,false,false,false,false);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            datagrid_Marble.ItemsSource = dt.DefaultView;
        }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
}
        private void button_AddMarble_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Public_Variables.creationMarbleLength = double.Parse(textbox_Length.Text.Trim());
                Public_Variables.creationMarbleWidth = double.Parse(textbox_Width.Text.Trim());
                Public_Variables.creationMarbleAmount = (textbox_Amount.Text.Trim()).ToString();
                Public_Variables.creationMarbleType = textbox_Type.Text.Trim();
                Public_Variables.creationMarbleNotes = textbox_Notes.Text.Trim();
                if (Public_Variables.creationMarbleLength > 999 || Public_Variables.creationMarbleWidth > 999 || int.Parse(Public_Variables.creationMarbleAmount) > 999)
                {
                    MessageBox.Show("These numbers are very big");
                    return;
                }
                Methods.SQLInsert(false, false, false, true, false, false);
                dg();
                textbox_Length.Text = "";
                textbox_Width.Text = "";
                textbox_Amount.Text = "";
                textbox_Type.Text = "";
                textbox_Notes.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show("Make sure you wrote length or width or amount correctly or try to decrease the numbers , error at add marble click \n it may be a connection error. \n" + x);
                return;
            }

        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
