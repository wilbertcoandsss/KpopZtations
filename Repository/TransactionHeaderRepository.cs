using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class TransactionHeaderRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();

        public void add(String transactionDate, int customerId)
        {
            TransactionHeaderFactory tf = new TransactionHeaderFactory();
            TransactionHeader t = tf.create(transactionDate, customerId);

            db.TransactionHeaders.Add(t);
            db.SaveChanges();
        }

        public List<TransactionHeader> fetchAll()
        {
            return (from transaction in db.TransactionHeaders select transaction).ToList();
        }

        public List<TransactionHeader> fetchByCustomer(int id)
        {
            return (from transaction in db.TransactionHeaders  where transaction.CustomerID == id select transaction).ToList();
        }

        public TransactionHeader search(int id)
        {
            return (from transaction in db.TransactionHeaders where transaction.TransactionID == id select transaction).FirstOrDefault();
        }

        public void delete(int id)
        {
            TransactionHeader a = search(id);
            db.TransactionHeaders.Remove(a);
            db.SaveChanges();
        }

        public void update(int id, String transactionDate, int customerId)
        {
            TransactionHeader t = search(id);
            t.TransactionDate = DateTime.Parse(transactionDate);
            t.CustomerID = customerId;

            db.SaveChanges();
        }

    }
}