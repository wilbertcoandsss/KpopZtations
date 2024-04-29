using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class AlbumRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();

        public void add(int artistId, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescirption)
        {
            AlbumFactory af = new AlbumFactory();
            Album a = af.create(artistId, albumName, albumImage, albumPrice, albumStock, albumDescirption);

            db.Albums.Add(a);
            db.SaveChanges();
        }

        public List<Album> fetchAll()
        {
            return (from album in db.Albums select album).ToList();
        }

        public List<Album> fetchByArtist(int id)
        {
            return (from album in db.Albums where album.ArtistID == id select album).ToList();
        }

        public Album search(int id)
        {
            return (from album in db.Albums where album.AlbumID == id select album).FirstOrDefault();
        }

        public void delete(int id)
        {
            Album a = search(id);
            db.Albums.Remove(a);
            db.SaveChanges();
        }

        public void update(int albumId, int artistId, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescirption)
        {
            Album a = search(albumId);
            a.ArtistID = artistId;
            a.AlbumName = albumName;
            a.AlbumImage = albumImage;
            a.AlbumPrice = albumPrice;
            a.AlbumStock = albumStock;
            a.AlbumDescription = albumDescirption;
            // update

            db.SaveChanges();
        }

    }
}