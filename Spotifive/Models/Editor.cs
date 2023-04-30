using System.Collections.Generic;

namespace Spotifive.Models
{
    public class Editor : Person
    {
        int ID;
        List<Song> songs;
        List<Artist> artists;
        Account account;
    }
}
