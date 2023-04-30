using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Spotifive.Models
{
    public class Song
    {
        int ID;
        string songName;
        DateAndTime dateRelease;
        enum genre { };
        string codeQR;
        string linkYT;
        List<Artist> artists;
        List<Review> reviews;
        List<Playlist> playlists;
    }
}
