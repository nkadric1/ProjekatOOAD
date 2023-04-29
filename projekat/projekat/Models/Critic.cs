using System.Collections.Generic;

namespace projekat.Models
{
    public class Critic : Person
    {
        int ID;
        List<Review> reviews;
        Song song;
        Account account;

    }
}
