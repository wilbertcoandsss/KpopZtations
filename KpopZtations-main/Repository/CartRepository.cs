using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class CartRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();

        public void add(int customerId, int albumId, int quantity)
        {

            CartFactory cf = new CartFactory();
            Cart c = cf.create(customerId, albumId, quantity);

            db.Carts.Add(c);
            db.SaveChanges();
        }

        public List<Cart> fetchAll()
        {
            return (from cart in db.Carts select cart).ToList();
        }

        public List<Cart> fetchByCustomer(int id)
        {
            return (from cart in db.Carts where cart.CustomerID == id select cart).ToList();
        }

        public List<Cart> fetchByAlbum(int id)
        {
            return (from cart in db.Carts where cart.AlbumID == id select cart).ToList();
        }

        public Cart search(int customerId, int albumId)
        {
            return (from cart in db.Carts where cart.CustomerID == customerId && cart.AlbumID == albumId select cart).FirstOrDefault();
        }

        public void delete(int customerId, int albumId)
        {
            Cart c = search(customerId, albumId);
            db.Carts.Remove(c);
            db.SaveChanges();
        }

        public void update(int customerId, int albumId, int quantity)
        {
            Cart c = search(customerId, albumId);
            c.CustomerID = customerId;
            c.AlbumID = albumId;
            c.Qty = quantity;

            db.SaveChanges();
        }

        public void clearCart(int customerId)
        {
            List<Cart> cartsToDelete = db.Carts.Where(c => c.CustomerID == customerId).ToList();

            db.Carts.RemoveRange(cartsToDelete);
            db.SaveChanges();

        }
    }
}