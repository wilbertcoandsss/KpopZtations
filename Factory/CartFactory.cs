using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Factory
{
    public class CartFactory
    {
        public Cart create(int customerId, int albumId, int quantity)
        {
            Cart c = new Cart();
            c.CustomerID = customerId;
            c.AlbumID = albumId;
            c.Qty = quantity;

            return c;

        }
    }
}