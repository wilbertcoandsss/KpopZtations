using KpopZtations.Model;
using System;

namespace KpopZtations.Factory
{
    public class AlbumFactory
    {
        public Album create(int artistId, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescirption)
        {
            Album a = new Album();
            a.ArtistID = artistId;
            a.AlbumName = albumName;
            a.AlbumImage = albumImage;
            a.AlbumPrice = albumPrice;
            a.AlbumStock = albumStock;
            a.AlbumDescription = albumDescirption;
            return a;
        }
    }
}