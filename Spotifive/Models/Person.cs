using Microsoft.VisualBasic;

namespace Spotifive.Models
{
    public abstract class Person
    {
        int ID;
        string name;
        string surname;
        DateAndTime dateOfBirth;
        enum gender { M, F };

    }
}
