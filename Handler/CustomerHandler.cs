using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Handler
{
    public class CustomerHandler
    {
        CustomerRepository cr = new CustomerRepository();
        public void addCustomer(String customerName, String customerEmail, String customerPassword, String customerGender, String customerAddress, String customerRole)
        {
            cr.add(customerName, customerEmail, customerPassword, customerGender, customerAddress, customerRole) ;
        }
        public Customer checkEmailUnique(string email)
        {
            return cr.checkEmailUnique(email);
        }
        public Customer login(string email, string password)
        {
            return cr.login(email, password);
        }

        public Customer getCustomerIdByEmail(string email)
        {
            return cr.getCustomerIdByEmail(email);
        }

        public void updateCustomer(int customerId, String customerName, String customerEmail, String customerPassword, String customerGender, String customerAddress)
        {
            cr.update(customerId, customerName, customerEmail, customerPassword, customerGender, customerAddress);
        }

        public void deleteAccount(int customerId)
        {
            cr.delete(customerId);
        }
    }
}