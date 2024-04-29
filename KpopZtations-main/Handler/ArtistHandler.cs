using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Handler
{
    public class ArtistHandler
    {
        ArtistRepository ar = new ArtistRepository();
        public void addArtist(String name, String image)
        {
            ar.add(name, image);
        }

        public Artist getUniqueName(String name)
        {
            return ar.getUniqueName(name);
        }

        public List<Artist> getAllArtist()
        {
            return ar.fetchAll();
        }

        public Artist getArtist(int id)
        {
            return ar.search(id);
        }
        public void update(int id, String artistName, String artistImage)
        {
            ar.update(id, artistName, artistImage);
        }

        public void delete(int id)
        {
            ar.delete(id);
        }
    }
}