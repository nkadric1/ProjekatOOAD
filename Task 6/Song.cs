using System;

namespace SpotiFIVE
{
    public class Song
    {
        int ID;
        string songName;
        Artist artist;
        DateTime dateRelase;
        enum genre
        {
            classical,
            acoustic,
            RnB,
            pop,
            rock,
            jazz,
            country,
            folk,
            punk,
            hipHop,
            newWave,
            rap,
            latin,
            indie,
            disco
        }
        string codeQR;
        Review review;
        string linkYT;

    }
}
