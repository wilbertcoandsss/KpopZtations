using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Factory
{
    public class CustomerFactory
    {
        public Customer create(String customerName, String customerEmail, String customerPassword, String customerGender, String customerAddress, String customerRole)
        {
            Customer c = new Customer();
            c.CustomerName = customerName;
            c.CustomerEmail = customerEmail;
            c.CustomerPassword = customerPassword;
            c.CustomerGender = customerGender;
            c.CustomerAddress = customerAddress;
            c.CustomerRole = customerRole;

            return c;

        }
    }
}