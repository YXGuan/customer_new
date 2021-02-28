using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace customer_new.Models
{
    public class UserModel
    {
        public int Name { get; set; }
        public int EmailAddress { get; set; }

        public int PhoneNumber { get; set; }

        //ctrl . auto generate constructor
        public UserModel(int n, int e, int p)
        {
            Name = n;
            EmailAddress = e;
            PhoneNumber = p;
        }
    }
}