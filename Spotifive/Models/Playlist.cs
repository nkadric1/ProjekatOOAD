using System.Collections.Generic;

namespace Spotifive.Models
{
    public class Playlist
    {
        int ID;
        string playlistName;
        List<Song> playlist;
        RegisteredUser user;

    }
}
