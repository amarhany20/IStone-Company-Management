using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace IStone_Application
{
    class Methods
    {
        public static bool LogIn(string username, string password)
        {
            try
            {
                string query = "Select * from Users where Username = @username and Password = @password";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader;
                SqlVariables.con.Open();
                reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                if (i == 1)
                {
                    reader.Close(); reader = cmd.ExecuteReader(); reader.Read();
                    Public_Variables.rank = reader.GetFieldValue<int>(reader.GetOrdinal("Actual_Rank"));
                    Public_Variables.SignedInUsername = reader.GetFieldValue<string>(reader.GetOrdinal("Username"));
                    Public_Variables.signedInID = reader.GetFieldValue<int>(reader.GetOrdinal("ID"));
                    SqlVariables.con.Close();
                    return true;
                    //Login Successful
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                    SqlVariables.con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E001 \n " + ex);
                SqlVariables.con.Close();
                return false;
            }
        }
        public static bool Register(string username, string password, string repeatpassword, int rank)
        {
            int i = 0;
            if (username.Length == 0 || password.Length == 0 || repeatpassword.Length == 0)
            {
                MessageBox.Show("Please fill the Register Fields");
                return false;
            }
            try
            {
                string query = "Select * from Users where Username = @username";
                SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader;
                SqlVariables.con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                }
                SqlVariables.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! \n E002 \n " + ex);
                SqlVariables.con.Close();
                return false;
            }
            if (i != 1)
            {
                if (password == repeatpassword)
                {
                    try
                    {
                        string query2 = "INSERT INTO Users (Username, Password , Rank) VALUES(@username, @password , @rank) ";
                        SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                        cmd2.Parameters.AddWithValue("@username", username);
                        cmd2.Parameters.AddWithValue("@password", password);
                        cmd2.Parameters.AddWithValue("@rank", rank);
                        SqlVariables.con.Open();
                        cmd2.ExecuteNonQuery();
                        SqlVariables.con.Close();
                        MessageBox.Show("You have been registered successfully! Please login using your account.");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error! \n E003 \n " + ex);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password and repeat passwords aren't the same");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username Already Exists.");
                return false;
            }
        }
        public static bool SQLInsert(bool customer, bool order, bool job, bool incomingMarble, bool payment, bool outGoingMarble)
        {
            try
            {
                SqlCommand cmd;
                if (customer)
                {
                    if (Public_Variables.creationFullName.Length == 0)
                    {
                        MessageBox.Show("FullName is empty! Please write the name of the customer.");
                        return false;
                    }
                    string checkquery = "Select * from Customers where [Full Name] like @FullName";
                    SqlVariables.con.Open();
                    SqlCommand checkcmd = new SqlCommand(checkquery, SqlVariables.con);
                    checkcmd.Parameters.AddWithValue("@FullName", Public_Variables.creationFullName);
                    SqlDataReader reader;
                    reader = checkcmd.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("Choose a new customer name please!");
                        SqlVariables.con.Close();
                        return false;
                    }
                    SqlVariables.con.Close();
                    string query = "INSERT INTO Customers ([Full Name],[Mobile Number 1],[Mobile Number 2],[Email],[Notes],Username,UserID) VALUES(@FullName,@Mobile1,@Mobile2,@Email,@Notes,@username,@ID) ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@FullName", Public_Variables.creationFullName);
                    cmd.Parameters.AddWithValue("@Mobile1", Public_Variables.creationMobile1);
                    cmd.Parameters.AddWithValue("@Mobile2", Public_Variables.creationMobile2);
                    cmd.Parameters.AddWithValue("@Email", Public_Variables.creationEmail);
                    cmd.Parameters.AddWithValue("@Notes", Public_Variables.creationNotes);
                    cmd.Parameters.AddWithValue("@username", Public_Variables.SignedInUsername);
                    cmd.Parameters.AddWithValue("@ID", Public_Variables.signedInID);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }

                else if (order)
                {
                    if (Public_Variables.creationOrder.Length == 0)
                    {
                        MessageBox.Show("Order name is empty! please write the order name.");
                        return false;
                    }
                    string checkQuery = "Select * from Orders where [Order Name] like @order And CustomerID like @customerid";
                    SqlVariables.con.Open();
                    SqlCommand checkcmd = new SqlCommand(checkQuery, SqlVariables.con);
                    checkcmd.Parameters.AddWithValue("@order", Public_Variables.creationOrder);
                    checkcmd.Parameters.AddWithValue("@customerid", Public_Variables.selectedCustomerID);
                    SqlDataReader reader;
                    reader = checkcmd.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("There is an already existing order with the same name for this customer! Please write a new order name or check it in current orders.");
                        SqlVariables.con.Close();
                        return false;
                    }
                    SqlVariables.con.Close();
                    string query = "INSERT INTO Orders ([Order Name],CustomerID,[Customer Name],Username,UserID) VALUES(@order,@ID,@name,@Username,@ID2)";
                    SqlVariables.con.Close();
                    cmd = new SqlCommand(query, SqlVariables.con);
                    SqlCommand command = new SqlCommand(query, SqlVariables.con);
                    command.Parameters.AddWithValue("@order", Public_Variables.creationOrder); ;
                    command.Parameters.AddWithValue("@ID", Public_Variables.selectedCustomerID);
                    command.Parameters.AddWithValue("@name", Public_Variables.selectedCustomerName);
                    command.Parameters.AddWithValue("@Username", Public_Variables.SignedInUsername);
                    command.Parameters.AddWithValue("@ID2", Public_Variables.signedInID);
                    SqlVariables.con.Open();
                    command.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;

                }
                else if (job)
                {
                    if (Public_Variables.creationType.Length == 0)
                    {
                        MessageBox.Show("Job type is empty. Please write the job type.");
                        return false;
                    }
                    string query = "INSERT INTO Jobs ([Type], [Meters], [Meter Price],[Days Requested],[Customer Name],[Customer ID],OrderName,OrderID,Username,UserID) VALUES(@Type, @Meters, @meterPrice,@requestedDays,@customerName,@customerID,@ordername,@orderID,@username,@userid) ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@Type", Public_Variables.creationType);
                    cmd.Parameters.AddWithValue("@Meters", Public_Variables.creationMeter);
                    cmd.Parameters.AddWithValue("@meterPrice", Public_Variables.creationPrice);
                    cmd.Parameters.AddWithValue("@requestedDays", Public_Variables.creationDaysRequested);
                    cmd.Parameters.AddWithValue("@customerName", Public_Variables.selectedCustomerName);
                    cmd.Parameters.AddWithValue("@customerID", Public_Variables.selectedCustomerID);
                    cmd.Parameters.AddWithValue("ordername", Public_Variables.selectedOrderName);
                    cmd.Parameters.AddWithValue("@orderID", Public_Variables.selectedOrderID);
                    cmd.Parameters.AddWithValue("@username", Public_Variables.SignedInUsername);
                    cmd.Parameters.AddWithValue("@userid", Public_Variables.signedInID);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (incomingMarble)
                {
                    if (Public_Variables.creationMarbleType.Length == 0)
                    {
                        MessageBox.Show("Marble's type is empty. Please write the type.");
                    }
                    string query = "INSERT INTO Marble (Type,Length,Width,Amount,Notes,Customer_Name,Customer_ID,Order_Name,Order_ID,Username,User_ID) VALUES(@Type, @Length,@Width,@Amount,@Notes,@Customer_Name,@Customer_ID,@Order_Name,@Order_ID,@Username,@User_ID)";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@Type", Public_Variables.creationMarbleType);
                    cmd.Parameters.AddWithValue("@Length", Public_Variables.creationMarbleLength);
                    cmd.Parameters.AddWithValue("@Width", Public_Variables.creationMarbleWidth);
                    cmd.Parameters.AddWithValue("@Amount", Public_Variables.creationMarbleAmount);
                    cmd.Parameters.AddWithValue("@Notes", Public_Variables.creationMarbleNotes);
                    cmd.Parameters.AddWithValue("@Customer_Name", Public_Variables.selectedCustomerName);
                    cmd.Parameters.AddWithValue("@Customer_ID", Public_Variables.selectedCustomerID);
                    cmd.Parameters.AddWithValue("@Order_Name", Public_Variables.selectedOrderName);
                    cmd.Parameters.AddWithValue("@Order_ID", Public_Variables.selectedOrderID);
                    cmd.Parameters.AddWithValue("@Username", Public_Variables.SignedInUsername);
                    cmd.Parameters.AddWithValue("@User_ID", Public_Variables.signedInID);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (payment)
                {
                    string query = "INSERT INTO Payments (Payment_Name,Amount,Customer_Name,Customer_ID,Order_Name,Order_ID,Username,User_ID) VALUES(@Payment_Name, @Amount,@Customer_Name,@Customer_ID,@Order_Name,@Order_ID,@Username,@User_ID)";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@Payment_Name", Public_Variables.creationPaymentName);
                    cmd.Parameters.AddWithValue("@Amount", Public_Variables.creationPaymentAmount);
                    cmd.Parameters.AddWithValue("@Customer_Name", Public_Variables.selectedCustomerName);
                    cmd.Parameters.AddWithValue("@Customer_ID", Public_Variables.selectedCustomerID);
                    cmd.Parameters.AddWithValue("@Order_Name", Public_Variables.selectedOrderName);
                    cmd.Parameters.AddWithValue("@Order_ID", Public_Variables.selectedOrderID);
                    cmd.Parameters.AddWithValue("@Username", Public_Variables.SignedInUsername);
                    cmd.Parameters.AddWithValue("@User_ID", Public_Variables.signedInID);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();

                    return true;
                }
                else
                {
                    MessageBox.Show("BUG");
                    return false;
                }


            }
            catch (Exception x)
            {
                MessageBox.Show("Error at SQLInsert in Methods \n the error may be connection \n " + x);
                SqlVariables.con.Close();
                return false;
            }
        }
        public static SqlDataAdapter da(string search, bool searchByFirstLetter, bool searchByDate, bool customer, bool order, bool currentOrders, bool job, bool orderjobs, bool currentJobs, bool incomingMarble, bool imcomingMarbleorder, bool Orderspayment, bool payment, bool outGoingMarble, bool user)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("",SqlVariables.con);
            string query;
            try
            {
                if (customer)
                {
                    if (searchByDate == true & searchByFirstLetter == false)
                    {
                        if (Public_Variables.rank == 2)
                        {
                            query = "Select ID, [Full Name],[Profile Creation Date] from Customers  where CONCAT(MONTH([Profile Creation Date]),'-',YEAR([Profile Creation Date])) = @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search);
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Customers  where CONCAT(MONTH([Profile Creation Date]),'-',YEAR([Profile Creation Date])) = @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search);
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                    }

                    else if (searchByFirstLetter == true & searchByDate == false)
                    {
                        if (Public_Variables.rank == 2)
                        {
                            query = "Select ID,[Full Name],[Profile Creation Date] from Customers where ID like @search or [Full Name] like @search";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Customers where ID like @search or [Full Name] like @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                    }
                    else if (searchByFirstLetter == false & searchByDate == false)
                    {

                        if (Public_Variables.rank == 2)
                        {
                            query = "Select ID,[Full Name],[Profile Creation Date] from Customers where ID like @search or [Full Name] like @search or [Mobile Number 1] like @search or [Mobile Number 2] like @search or [Email] like @search or [Notes] like @search  or Username like @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Customers where ID like @search or [Full Name] like @search or [Mobile Number 1] like @search or [Mobile Number 2] like @search or [Email] like @search or [Notes] like @search or Username like @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                    }
                    else if (searchByFirstLetter == true & searchByDate == true)
                    {
                        MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                        return da;
                    }
                    else
                    {
                        MessageBox.Show("Bug!");
                        return da;
                    }
                }
                else if (currentOrders)
                {
                    Refreshing(true, false);
                    if (Public_Variables.rank == 2)
                    {
                        query = "select ID , [Order Name] , [CustomerID] , [Customer Name] , [Order Date] , [All Jobs Done] ,username,UserID from Orders where [Order End] like '0'";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else
                    {
                        query = "select * from Orders where [Order End] like '0'";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                }
                else if (orderjobs)
                {
                    if (Public_Variables.rank == 2)
                    {
                        query = "Select [ID],[End],[Type],[OrderName],[OrderID],[Customer Name],[Customer ID],[Meters],[Job Date],[Days Requested],[Days Remaining],[Drawing],[Drawing Finish Time],[Program],[Program Finish Time],[Cutting],[Cutting Finish Time],[Finishing],[Finishing Finish Time],[Polishing],[Polishing Finish Time],[Delivered],[Delivering Finish Time] , Username , UserID from Jobs where OrderID like @orderid ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@orderid", Public_Variables.selectedOrderID);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else
                    {
                        query = "Select * from Jobs where OrderID like @orderid";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@orderid", Public_Variables.selectedOrderID);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                }
                else if (currentJobs)
                {
                    if (searchByDate == false && searchByFirstLetter == false)
                    {
                        if (Public_Variables.rank == 2)
                        {
                            query = "select [ID],[End],[Type],[OrderName],[OrderID],[Customer Name],[Customer ID],[Meters],[Job Date],[Days Requested],[Days Remaining],[Drawing],[Drawing Finish Time],[Program],[Program Finish Time],[Cutting],[Cutting Finish Time],[Finishing],[Finishing Finish Time],[Polishing],[Polishing Finish Time],[Delivered],[Delivering Finish Time] , Username , UserID FROM [IStone].[dbo].[Jobs] where  [End] like '0' AND ( [ID] like @search OR [Type] like @search or [OrderName] like @search or  [Customer Name] like @search or Username like @search ) ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Jobs where [End] Like '0' AND ( [ID] like @search OR [Type] like @search or [OrderName] like @search or [Customer Name] like @search or Username like @search )";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                    }
                    else if (searchByDate == true && searchByFirstLetter == false)
                    {
                        if (Public_Variables.rank == 2)
                        {
                            query = "select [ID],[End],[Type],[OrderName],[OrderID],[Customer Name],[Customer ID],[Meters],[Job Date],[Days Requested],[Days Remaining],[Drawing],[Drawing Finish Time],[Program],[Program Finish Time],[Cutting],[Cutting Finish Time],[Finishing],[Finishing Finish Time],[Polishing],[Polishing Finish Time],[Delivered],[Delivering Finish Time] , Username , UserID FROM [IStone].[dbo].[Jobs] where  [End] like '0' AND ( CONCAT(MONTH([Job Date]),'-',YEAR([Job Date])) = @search )";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search);
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Jobs where  [End] like '0' AND ( CONCAT(MONTH([Job Date]),'-',YEAR([Job Date])) = @search )";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search);
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }


                    }
                    else if (searchByDate == false && searchByFirstLetter == true)
                    {
                        if (Public_Variables.rank == 2)
                        {
                            query = "select [ID],[End],[Type],[OrderName],[OrderID],[Customer Name],[Customer ID],[Meters],[Job Date],[Days Requested],[Days Remaining],[Drawing],[Drawing Finish Time],[Program],[Program Finish Time],[Cutting],[Cutting Finish Time],[Finishing],[Finishing Finish Time],[Polishing],[Polishing Finish Time],[Delivered],[Delivering Finish Time] , Username , UserID FROM [IStone].[dbo].[Jobs] where  [End] like '0' AND ( [ID] like @search OR [Type] like @search or [OrderName] like @search or  [Customer Name] like @search or Username like @search ) ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else
                        {
                            query = "Select * from Jobs where [End] Like '0' AND ( [ID] like @search OR [Type] like @search or [OrderName] like @search or [Customer Name] like @search or [Meters] like @search or Username like @search )";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                    }
                    else if (searchByDate == true && searchByFirstLetter == true)
                    {
                        MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                        return da;
                    }

                }
                else if (imcomingMarbleorder)
                {
                    query = "Select * from Marble where Order_ID = @id";

                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", Public_Variables.selectedOrderID);
                    SqlVariables.con.Open();
                    da = new SqlDataAdapter(cmd);
                    SqlVariables.con.Close();
                    return da;
                }
                else if (Orderspayment)
                {
                    query = "select * from Payments where Order_ID = @id";

                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", Public_Variables.selectedOrderID);
                    SqlVariables.con.Open();
                    da = new SqlDataAdapter(cmd);
                    SqlVariables.con.Close();
                    return da;
                }
                else if (order)
                {
                    if (searchByDate == false && searchByFirstLetter == false)
                    {
                        query = "Select * from Orders where ID like @search or [Order Name] like @search or [Customer Name] like @search or Username like @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == true && searchByFirstLetter == false)
                    {
                        query = "Select * from Orders  where CONCAT(MONTH([Order Date]),'-',YEAR([Order Date])) = @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == false && searchByFirstLetter == true)
                    {
                        query = "Select * from Orders where ID like @search or [Order Name] like @search  or [Customer Name] like @search or Username like @search";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == true && searchByFirstLetter == true)
                    {
                        MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                        return da;
                    }

                }
                else if (job)
                {
                    if (searchByDate == false && searchByFirstLetter == false)
                    {

                        query = "Select * from Jobs where [ID] like @search OR [Type] like @search or [OrderName] like @search or [Customer Name] like @search or  Username like @search  " +
                            "";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == true && searchByFirstLetter == false)
                    {

                        query = "Select * from Jobs where  CONCAT(MONTH([Job Date]),'-',YEAR([Job Date])) = @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == false && searchByFirstLetter == true)
                    {

                        query = "Select * from Jobs where [ID] like @search OR [Type] like @search or [OrderName] like @search or [Customer Name] like @search or Username like @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;

                    }
                    else if (searchByDate == true && searchByFirstLetter == true)
                    {
                        MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                        return da;
                    }
                }
                else if (incomingMarble)
                {
                    if (searchByDate == false && searchByFirstLetter == false)
                    {

                        query = "Select * from Marble where [ID] like @search OR [Type] like @search or [Notes] like @search or [Customer_Name] like @search or [Order_Name] like @search or [Username] like @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == true && searchByFirstLetter == false)
                    {

                        query = "Select * from Marble where  CONCAT(MONTH(Date),'-',YEAR(Date)) = @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search);
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    else if (searchByDate == false && searchByFirstLetter == true)
                    {

                        query = "Select * from Marble where [ID] like @search OR [Type] like @search or [Notes] like @search or [Customer_Name] like @search or [Order_Name] like @search or [Username] like @search ";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;

                    }
                    else if (searchByDate == true && searchByFirstLetter == true)
                    {
                        MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                        return da;
                    }
                }
                else if (payment)
                {

                    {
                        if (searchByDate == false && searchByFirstLetter == false)
                        {

                            query = "Select * from Payments where [ID] like @search OR [Payment_Name] like @search or [Customer_Name] like @search or [Order_Name] like @search or [Username] like @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else if (searchByDate == true && searchByFirstLetter == false)
                        {

                            query = "Select * from Payments where  CONCAT(MONTH(Date),'-',YEAR(Date)) = @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search);
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;
                        }
                        else if (searchByDate == false && searchByFirstLetter == true)
                        {

                            query = "Select * from Payments where [ID] like @search OR [Payment_Name] like @search or [Customer_Name] like @search or [Order_Name] like @search or [Username] like @search ";
                            cmd = new SqlCommand(query, SqlVariables.con);
                            cmd.Parameters.AddWithValue("@search", search + "%");
                            SqlVariables.con.Open();
                            da = new SqlDataAdapter(cmd);
                            SqlVariables.con.Close();
                            return da;

                        }
                        else if (searchByDate == true && searchByFirstLetter == true)
                        {
                            MessageBox.Show("You can't search by first letter and by date at the same time. Please either choose search by first letter of by date.");
                            return da;
                        }
                    }
                }
                else if (user)
                {
                    if (searchByDate == false && searchByFirstLetter == false)
                    {

                        query = "Select * from Users where [ID] like @search OR [Username] like @search or [Password] like @search";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;
                    }
                    
                    else if (searchByDate == false && searchByFirstLetter == true)
                    {

                        query = "select * from Users where [ID] like @search OR [Username] like @search or[Password] like @search";
                        cmd = new SqlCommand(query, SqlVariables.con);
                        cmd.Parameters.AddWithValue("@search", search + "%");
                        SqlVariables.con.Open();
                        da = new SqlDataAdapter(cmd);
                        SqlVariables.con.Close();
                        return da;

                    }
                }
            }

            catch (Exception x)
            {
                MessageBox.Show("Error at da in Methods \n it my be a connection problem \n " + x);
                SqlVariables.con.Close();
                return da;
            }
            return da;
        }
        public static void Refreshing(bool OrderPaymentsRefreshing, bool checkOrderEnd)
        {
            if (OrderPaymentsRefreshing)
            {


                string query;
                int counter = 0;

                query = "Select * from Orders";
                SqlCommand command = new SqlCommand(query, SqlVariables.con);
                SqlVariables.con.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                int i = 0;
                int orderID;
                List<int> lstorderid = new List<int>();
                try
                {
                    while (reader.Read())
                    {

                        orderID = reader.GetFieldValue<int>(reader.GetOrdinal("ID"));
                        lstorderid.Add(orderID);
                        i++;
                    }
                    SqlVariables.con.Close();
                    for (int i2 = 0; i2 < i; i2++)
                    {
                        try
                        {
                            string query1 = $"select sum([Total Price]) from Jobs where OrderID = {lstorderid[i2]}";
                            SqlCommand cmd = new SqlCommand(query1, SqlVariables.con);
                            SqlVariables.con.Open();
                            object result = cmd.ExecuteScalar();
                            decimal sum = decimal.Parse(result.ToString());
                            SqlVariables.con.Close();
                            string query2 = $"update Orders set Total_Price = {sum} where ID = {lstorderid[i2]}";
                            SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                            SqlVariables.con.Open();
                            cmd2.ExecuteNonQuery();
                            SqlVariables.con.Close();
                            counter++;
                        }
                        catch (Exception x)
                        {
                            SqlVariables.con.Close();
                            string query2 = $"update Orders set Total_Price = '0' where ID = {lstorderid[i2]}";
                            SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                            SqlVariables.con.Open();
                            cmd2.ExecuteNonQuery();
                            SqlVariables.con.Close();
                            continue;
                        }


                    }
                    for (int i3 = 0; i3 < i; i3++)
                    {
                        try
                        {
                            string query1 = $"select sum(Amount) from Payments where Order_ID = {lstorderid[i3]}";
                            SqlCommand cmd = new SqlCommand(query1, SqlVariables.con);
                            SqlVariables.con.Open();
                            object result = cmd.ExecuteScalar();
                            decimal sum = decimal.Parse(result.ToString());
                            SqlVariables.con.Close();
                            string query2 = $"update Orders set Total_Paid = {sum} where ID = {lstorderid[i3]}";
                            SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                            SqlVariables.con.Open();
                            cmd2.ExecuteNonQuery();
                            SqlVariables.con.Close();
                            counter++;
                        }

                        catch (Exception)
                        {
                            SqlVariables.con.Close();
                            string query2 = $"update Orders set Total_Paid = '0' where ID = {lstorderid[i3]}";
                            SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                            SqlVariables.con.Open();
                            cmd2.ExecuteNonQuery();
                            SqlVariables.con.Close();
                            continue;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Refreshing in Methods \n \n " + ex);
                    SqlVariables.con.Close();
                }
            }
            else if (checkOrderEnd)
            {
                try
                {
                    string query = "Select * from Jobs where [End] like '0' AND OrderID like @id";
                    SqlCommand cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", Public_Variables.selectedOrderID);
                    SqlDataReader reader;
                    SqlVariables.con.Open();
                    reader = cmd.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                    }
                    SqlVariables.con.Close();
                    if (i == 0)
                    {
                        string query2 = "Update Orders SET [All Jobs Done] = 1 where ID like @ID";
                        MessageBox.Show("Updating All Jobs are done in Order");
                        SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                        cmd2.Parameters.AddWithValue("@ID", Public_Variables.selectedOrderID);
                        SqlVariables.con.Open();
                        cmd2.ExecuteNonQuery();
                        SqlVariables.con.Close();
                    }
                    else
                    {
                        string query2 = "Update Orders SET [All Jobs Done] = 0 where ID like @ID";
                        SqlCommand cmd2 = new SqlCommand(query2, SqlVariables.con);
                        cmd2.Parameters.AddWithValue("@ID", Public_Variables.selectedOrderID);
                        SqlVariables.con.Open();
                        cmd2.ExecuteNonQuery();
                        SqlVariables.con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Refreshing \n \n  " + ex);
                }
            }
            return;
        }
        public static bool Deleting(bool customer, bool user, bool order , bool job, bool incomingmarble , bool payment ,bool outgoingmarble ,int id)
        {
            if (MessageBox.Show("Are you sure? IT CAN'T BE UNDONE", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

            }
            else
            {
                return false;
            }
            string query;
            SqlCommand cmd;
            try
            {
                if (customer && MessageBox.Show("Are you sure? as if you delete the customer, all of his orders, payments, marbles, and jobs will be deleted as well. only delete customer if made by mistake otherwise leave him he won't affect anything", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    query = "delete from customers where ID like @id delete from Orders where CustomerID like @id delete from jobs where [Customer ID] like @id delete from Marble where Customer_ID like @id delete from payments where Customer_ID like @id ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;    
                }
               else if (user && MessageBox.Show("Are you sure? user will be deleted and he can't sign in back", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (id == Public_Variables.signedInID)
                    {
                        MessageBox.Show("You can't remove your account");
                        return false;
                    }
                    query = "delete from users where ID like @id ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (order && MessageBox.Show("Are you sure? as if you delete the order, all of his  payments, marbles, and jobs will be deleted as well. only delete order if made by mistake otherwise leave it as it won't affect anything", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    query = "delete from orders where ID like @id delete from jobs where OrderID like @id delete from payments where Order_ID like @id delete from marble where Order_ID like @id";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (job && MessageBox.Show("Are you sure? this job will be deleted", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    query = "delete from jobs where ID like @id ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (payment && MessageBox.Show("Are you sure? this payment will be deleted", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    query = "delete from Payments where ID like @id ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (incomingmarble && MessageBox.Show("Are you sure? this marble will be deleted", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    query = "delete from Marble where ID like @id ";
                    cmd = new SqlCommand(query, SqlVariables.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlVariables.con.Open();
                    cmd.ExecuteNonQuery();
                    SqlVariables.con.Close();
                    return true;
                }
                else if (outgoingmarble)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("BUG");
                    return false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error at Deleting in Methods \n it may be a connection error \n " + x);
                SqlVariables.con.Close();
                return false;
            }
        }

    }
}
