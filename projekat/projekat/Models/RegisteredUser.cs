using System.Collections.Generic;

namespace projekat.Models
{
    public class RegisteredUser : Person
    {
        int ID;
        Song song;
        List<Playlist> playlists;
        Account account;
    }
}
