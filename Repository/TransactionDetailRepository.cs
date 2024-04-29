using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class TransactionDetailRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();

        public void add(int transactionId, int albumId, int quantity)
        {
            TransactionDetailFactory tf = new TransactionDetailFactory();
            TransactionDetail t = tf.create(transactionId, albumId, quantity);

            db.TransactionDetails.Add(t);
            db.SaveChanges();
        }

        public List<TransactionDetail> fetchAll()
        {
            return (from transaction in db.TransactionDetails select transaction).ToList();
        }

        public List<TransactionDetail> fetchByTransaction(int id)
        {
            return (from transaction in db.TransactionDetails where transaction.TransactionID == id select transaction).ToList();
        }

        public List<TransactionDetail> fetchByAlbum(int id)
        {
            return (from transaction in db.TransactionDetails where transaction.AlbumID == id select transaction).ToList();
        }

        public TransactionDetail search(int transactionId, int albumId)
        {
            return (from transaction in db.TransactionDetails where transaction.TransactionID == transactionId && transaction.AlbumID == albumId select transaction).FirstOrDefault();
        }

        public void delete(int transactionId, int albumId)
        {
            TransactionDetail t = search(transactionId, albumId);
            db.TransactionDetails.Remove(t);
            db.SaveChanges();
        }

        public void update(int transactionId, int albumId, int quantity)
        {
            TransactionDetail t = search(transactionId, albumId);
            t.TransactionID = transactionId;
            t.AlbumID = albumId;
            t.Qty = quantity;

            db.SaveChanges();
        }

        public int getLatestThId()
        {
            var latestTransaction = (from transaction in db.TransactionHeaders
                                     orderby transaction.TransactionID descending
                                     select transaction).FirstOrDefault();

            return latestTransaction.TransactionID;
        }

    }
}