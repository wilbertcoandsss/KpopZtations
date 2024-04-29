using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtations.Factory
{
    public class ArtistFactory
    {
        public Artist create(String artistName, String artistImage)
        {
            Artist a = new Artist();
            a.ArtistName = artistName;
            a.ArtistImage = artistImage;

            return a;

        }
    }
}