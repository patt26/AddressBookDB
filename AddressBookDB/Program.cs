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
        }
    }
}
