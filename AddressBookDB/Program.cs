using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            AddressBookRepo adress = new AddressBookRepo();
            adress.GetData();
            Console.ReadLine();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Ken";
            model.LastName = "Williams";
            model.Address = "29,Almond Street";
            model.City = "Londan";
            model.State = "Winchester";
            model.ZIP_Code = "898562";
            model.Phone_Number = "4872630154";
            model.Email_ID = "kenwill48@yahoo.com";
            model.Book_Name = "Club";
            model.Type = "Friend";
            if (adress.AddDetails(model))
            {
                Console.WriteLine("Records Added Sucessfully");
            }
            adress.GetData();
            Console.ReadKey();
        }
    }
}
