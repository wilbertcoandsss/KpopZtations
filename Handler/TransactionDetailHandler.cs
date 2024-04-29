using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Handler
{
    public class TransactionDetailHandler
    {
        TransactionDetailRepository tdr = new TransactionDetailRepository();
        public int getLatestThId()
        {
            return tdr.getLatestThId();
        }

        public void insert(int latestThId, int albumId, int qty)
        {
            tdr.add(latestThId, albumId, qty);
        }


        public List<TransactionDetail> getTrDetail(int trId)
        {
            return tdr.fetchByTransaction(trId);
        }
    }
}