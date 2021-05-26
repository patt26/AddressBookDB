using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    class AddressBookRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Address_Book;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public void GetData()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    string query = @"Select * from Address_Book1;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            model.ID = dr.GetInt32(0);
                            model.FirstName = dr.GetString(1);
                            model.LastName = dr.GetString(2);
                            model.Address = dr.GetString(3);
                            model.City = dr.GetString(4);
                            model.State = dr.GetString(5);
                            model.ZIP_Code = dr.GetString(6);
                            model.Phone_Number = dr.GetString(7);
                            model.Email_ID = dr.GetString(8);
                            model.Book_Name = dr.GetString(9);
                            model.Type = dr.GetString(10);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",model.FirstName,model.LastName,model.Address,model.City,model.State,model.ZIP_Code,model.Phone_Number,model.Email_ID,model.Book_Name,model.Type);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Not Found");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        public bool AddDetails(AddressBookModel address)
        {
            try
            {
                using (this.connection)
                {
                    
                    SqlCommand command = new SqlCommand("SpAddDataAddressBook", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", address.FirstName);
                    command.Parameters.AddWithValue("@LastName", address.LastName);
                    command.Parameters.AddWithValue("@Address", address.Address);
                    command.Parameters.AddWithValue("@City", address.City);
                    command.Parameters.AddWithValue("@State", address.State);
                    command.Parameters.AddWithValue("@ZIP_Code", address.ZIP_Code);
                    command.Parameters.AddWithValue("@Phone_Number", address.Phone_Number);
                    command.Parameters.AddWithValue("@Email_ID", address.Email_ID);
                    command.Parameters.AddWithValue("@Book_Name", address.Book_Name);
                    command.Parameters.AddWithValue("@Type", address.Type);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    }
}
