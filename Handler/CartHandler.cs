using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Handler
{
    public class CartHandler
    {
        CartRepository cr = new CartRepository();
        public void insertCart(int userId, int albumId, int qty)
        {
            cr.add(userId, albumId, qty);
        }

        public List<Cart> getUserCart(int userId)
        {
            return cr.fetchByCustomer(userId);
        }

        public void clearCart(int userId)
        {
            cr.clearCart(userId);
        }

        public void deleteCart(int userId, int albumId)
        {
            cr.delete(userId, albumId);
        }
    }
}