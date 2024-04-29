using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Factory
{
    public class TransactionDetailFactory
    {
        public TransactionDetail create(int transactionId, int albumId, int quantity)
        {
            TransactionDetail t = new TransactionDetail();
            t.TransactionID = transactionId;
            t.AlbumID = albumId;
            t.Qty = quantity;

            return t;

        }
    }
}