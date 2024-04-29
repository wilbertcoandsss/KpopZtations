using KpopZtations.Factory;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Repository
{
    public class ArtistRepository
    {
        private DatabaseNewEntities db = new DatabaseNewEntities();
        public void add(String artistName, String artistImage)
        {
            ArtistFactory af = new ArtistFactory();
            Artist a = af.create(artistName, artistImage);

            db.Artists.Add(a);
            db.SaveChanges();
        }

        public List<Artist> fetchAll()
        {
            return (from artist in db.Artists select artist).ToList();
        }

        public Artist search(int id)
        {
            return (from artist in db.Artists where artist.ArtistID == id select artist).FirstOrDefault();
        }

        public Artist getUniqueName(String name)
        {
            return (from artist in db.Artists where artist.ArtistName == name select artist).FirstOrDefault();
        }

        public void delete(int id)
        {
            Artist a = search(id);
            db.Artists.Remove(a);
            db.SaveChanges();
        }

        public void update(int id, String artistName, String artistImage)
        {
            Artist a = search(id);
            a.ArtistName = artistName;
            a.ArtistImage = artistImage;

            db.SaveChanges();
        }
    }
}