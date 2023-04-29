namespace projekat.Models
{
    public class Review
    {
        int ID;
        double grade;
        string comment;
        string timeStamp;
        Song song;
        Critic user;
    }
}
