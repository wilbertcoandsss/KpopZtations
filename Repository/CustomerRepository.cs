using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class CustomerRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();

        public void add(String customerName, String customerEmail, String customerPassword, String customerGender, String customerAddress, String customerRole)
        {
            CustomerFactory cf = new CustomerFactory();
            Customer c = cf.create(customerName, customerEmail, customerPassword, customerGender, customerAddress, customerRole);

            db.Customers.Add(c);
            db.SaveChanges();
        }

        public List<Customer> fetchAll()
        {
            return (from customer in db.Customers select customer).ToList();
        }

        public Customer search(int id)
        {
            return (from customer in db.Customers where customer.CustomerID == id select customer).FirstOrDefault();
        }

        public Customer getCustomerIdByEmail(String email)
        {
            return (from customer in db.Customers where customer.CustomerEmail == email select customer).FirstOrDefault();
        }

        public Customer login(string email, string password)
        {
            return (from customer in db.Customers where customer.CustomerEmail == email && customer.CustomerPassword == password select customer).FirstOrDefault();
        }

        public Customer checkEmailUnique(string email)
        {
            return (from customer in db.Customers where customer.CustomerEmail == email select customer).FirstOrDefault();
        }

        public void delete(int id)
        {
            Customer a = search(id);
            db.Customers.Remove(a);
            db.SaveChanges();
        }

        public void update(int id, String customerName, String customerEmail, String customerPassword, String customerGender, String customerAddress)
        {
            Customer c = search(id);
            c.CustomerName = customerName;
            c.CustomerEmail = customerEmail;
            c.CustomerPassword = customerPassword;
            c.CustomerGender = customerGender;
            c.CustomerAddress = customerAddress;

            db.SaveChanges();
        }
    }
}