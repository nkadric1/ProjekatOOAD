using System.Collections.Generic;

namespace projekat.Models
{
    public class Editor : Person
    {
        int ID;
        List<Song> songs;
        List<Artist> artists;
        Account account;
    }
}
