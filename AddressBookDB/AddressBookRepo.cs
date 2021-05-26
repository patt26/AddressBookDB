using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
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
                            model.ZIP_Code = dr.GetInt32(6);
                            model.Phone_Number = dr.GetInt32(7);
                            model.Email_ID = dr.GetString(8);
                            model.Book_Name = dr.GetString(9);
                            model.Type = dr.GetString(10);
                            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} ",model.FirstName,model.LastName,model.Address,model.City,model.State,model.ZIP_Code,model.Phone_Number,model.Email_ID,model.Book_Name,model.Type);
                           

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
    }
}
