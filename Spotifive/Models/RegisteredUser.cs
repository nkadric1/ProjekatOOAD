using System.Collections.Generic;

namespace Spotifive.Models
{
    public class RegisteredUser : Person
    {
        int ID;
        Song song;
        List<Playlist> playlists;
        Account account;
    }
}
