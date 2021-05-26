using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    class AddressBookModel
    {
        public int ID { get;set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIP_Code { get; set; }
        public int Phone_Number { get; set; }
        public string Email_ID { get; set; }
        public string Book_Name { get; set; }
        public string Type { get; set; }
    }
}
