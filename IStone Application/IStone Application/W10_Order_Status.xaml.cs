using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace IStone_Application
{
    /// <summary>
    /// Interaction logic for W10_.xaml
    /// </summary>
    public partial class W10_Order_Status : Window
    {
        public W10_Order_Status()
        {
            InitializeComponent();
            if (Public_Variables.rank == 2)
            {
                button_EndJob.Visibility = Visibility.Hidden;
                button_PaymentDone.Visibility = Visibility.Hidden;
                button_PaymentList.Visibility = Visibility.Hidden;
            }
            dg();
        }
        public static void SelectRowByIndex(DataGrid dataGrid, int rowIndex)
        {
            //if (Public_Variables.firstTime)
            //{
            //    Public_Variables.firstTime = false;
            //    return;
            //}
            if (!dataGrid.SelectionUnit.Equals(DataGridSelectionUnit.FullRow))
                throw new ArgumentException("The SelectionUnit of the DataGrid must be set to FullRow.");
            if (rowIndex < 0 || rowIndex > (dataGrid.Items.Count - 1))
            {
                return;
            }
            //dataGrid.SelectedItems.Clear();
            /* set the SelectedItem property */
            object item = dataGrid.Items[rowIndex]; // = Product X
            dataGrid.SelectedItem = item;
            DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromIndex(rowIndex) as DataGridRow;
            if (row == null)
            {
                /* bring the data item (Product object) into view
                 * in case it has been virtualized away */
                dataGrid.ScrollIntoView(item);
                row = dataGrid.ItemContainerGenerator.ContainerFromIndex(rowIndex) as DataGridRow;
            }
            //TODO: Retrieve and focus a DataGridCell object
        }
        void CheckOrederEnd()
        {
            Methods.Refreshing(false, true);
        }
        void Selection()
        {
            if (Public_Variables.rank == 2)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)datagrid_CurrentJobs.SelectedItem;
                    jobID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[11].ToString()))
                    {
                        drawingDone = true;
                    }
                    else
                    {
                        drawingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[13].ToString()))
                    {
                        programDone = true;
                    }
                    else
                    {
                        programDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[15].ToString()))
                    {
                        cuttingDone = true;
                    }
                    else
                    {
                        cuttingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[17].ToString()))
                    {
                        finishingDone = true;
                    }
                    else
                    {
                        finishingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[19].ToString()))
                    {
                        polishingDone = true;
                    }
                    else
                    {
                        polishingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[21].ToString()))
                    {
                        deliveredDone = true;
                    }
                    else
                    {
                        deliveredDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[21].ToString()))
                    {
                        end = false;
                    }
                    else
                    {
                        end = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select an order! ");
                    shouldIreturn = true;
                    return;
                }
            }
            else
            {
                try
                {
                    DataRowView dataRow = (DataRowView)datagrid_CurrentJobs.SelectedItem;
                    jobID = Convert.ToInt32(dataRow.Row.ItemArray[0].ToString());
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[13].ToString()))
                    {
                        drawingDone = true;
                    }
                    else
                    {
                        drawingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[15].ToString()))
                    {
                        programDone = true;
                    }
                    else
                    {
                        programDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[17].ToString()))
                    {
                        cuttingDone = true;
                    }
                    else
                    {
                        cuttingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[19].ToString()))
                    {
                        finishingDone = true;
                    }
                    else
                    {
                        finishingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[21].ToString()))
                    {
                        polishingDone = true;
                    }
                    else
                    {
                        polishingDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[23].ToString()))
                    {
                        deliveredDone = true;
                    }
                    else
                    {
                        deliveredDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[25].ToString()))
                    {
                        paymentDone = true;
                    }
                    else
                    {
                        paymentDone = false;
                    }
                    if (Convert.ToBoolean(dataRow.Row.ItemArray[23].ToString()))
                    {
                        end = false;
                    }
                    else
                    {
                        end = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select an order! ");
                    shouldIreturn = true;
                    return;
                }
            }
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
                SelectRowByIndex(datagrid_CurrentJobs, index);
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public int jobID;
        public bool shouldIreturn = false;
        public bool drawingDone = false;
        public bool programDone = false;
        public bool cuttingDone = false;
        public bool finishingDone = false;
        public bool polishingDone = false;
        public bool deliveredDone = false;
        public bool paymentDone = false;
        public bool end = false;
        private void button_DrawingDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (drawingDone)
            {
                MessageBox.Show("It's already Done");
                drawingDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Drawing = 1 , [Drawing Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E013 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_ProgramDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (programDone)
            {
                MessageBox.Show("It's already Done");
                programDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Program = 1 , [Program Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E014 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_CuttingDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (cuttingDone)
            {
                MessageBox.Show("It's already Done");
                cuttingDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Cutting = 1 , [Cutting Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E015 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_FinishingDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (finishingDone)
            {
                MessageBox.Show("It's already Done");
                finishingDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Finishing = 1 , [Finishing Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E016 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_PolishingDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (polishingDone)
            {
                MessageBox.Show("It's already Done");
                polishingDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Polishing = 1 , [Polishing Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E017 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_Delivered_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (deliveredDone)
            {
                MessageBox.Show("It's already Done");
                deliveredDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET Delivered = 1 , [Delivering Finish Time] = GetDate() WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E018 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }
        private void button_PaymentDone_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (paymentDone)
            {
                MessageBox.Show("It's already Done");
                paymentDone = false;
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET [Payment Done] = 1 , [Payment Done Finish Time] = GetDate()  WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E019 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
            }
        }
        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Public_Variables.selectedOrderID = 0;
            Public_Variables.selectedOrderName = "";
            Public_Variables.selectedCustomerName = "";
            Public_Variables.selectedCustomerID = 0;
        }
        private void button_EndJob_Click(object sender, RoutedEventArgs e)
        {
            Selection();
            if (shouldIreturn)
            {
                shouldIreturn = false;
                return;
            }
            if (end)
            {
                end = false;
                MessageBox.Show("Job isn't delivered yet!");
                return;
            }
            if (MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                MessageBox.Show("Canceled!");
                return;
            }
            try
            {
                string query = $"UPDATE Jobs SET [End] = 1 WHERE ID = '{jobID}'; ";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                cmd.ExecuteNonQuery();
                SqlVariables.con.Close();
                dg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E020 \n " + ex);
            }
            finally
            {
                SqlVariables.con.Close();
                CheckOrederEnd();
            }
        }


        private void button_PaymentList_Click(object sender, RoutedEventArgs e)
        {
            W09_Payment_Creation t = new W09_Payment_Creation();
            t.ShowDialog();
        }

        private void button_IncomingMarbleList_Click(object sender, RoutedEventArgs e)
        {
            W08_Incoming_Marble_Creation t = new W08_Incoming_Marble_Creation();
            t.ShowDialog();
        }

        private void button_AddJobs_Click(object sender, RoutedEventArgs e)
        {
            W07_Job_Creation t = new W07_Job_Creation();
            t.ShowDialog();
            dg();
        }
    }
}
