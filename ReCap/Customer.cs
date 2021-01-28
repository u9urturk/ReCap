using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        //private string _firsName;
        //public string FirsName
        //{ 
        //    get { return "Mrs." + _firsName; }
        //    set { _firsName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
