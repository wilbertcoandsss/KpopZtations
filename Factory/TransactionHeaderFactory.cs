using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Factory
{
    public class TransactionHeaderFactory
    {
        public TransactionHeader create(String transactionDate, int customerId)
        {
            TransactionHeader t = new TransactionHeader();
            t.TransactionDate = DateTime.Parse(transactionDate);
            t.CustomerID = customerId;

            return t;

        }
    }
}