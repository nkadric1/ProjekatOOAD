using System.Collections.Generic;

namespace Spotifive.Models
{
    public class Critic : Person
    {
        int ID;
        List<Review> reviews;
        Song song;
        Account account;

    }
}
