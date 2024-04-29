using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Handler
{
    public class AlbumHandler
    {
        AlbumRepository ar = new AlbumRepository();

        public void addAlbum(int artistId, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescirption)
        {
            ar.add(artistId, albumName, albumImage, albumPrice, albumStock, albumDescirption);
        }

        public List<Album> getAlbumsByArtist(int artistId)
        {
            return ar.fetchByArtist(artistId);
        }

        public Album searchAlbum(int albumId)
        {
            return ar.search(albumId);
        }

        public void updateAlbum(int artistId, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescirption, int albumId)
        {
            ar.update(albumId, artistId, albumName, albumImage, albumPrice, albumStock, albumDescirption);
        }

        public void deleteAlbum(int albumId)
        {
            ar.delete(albumId);
        }
    }
}