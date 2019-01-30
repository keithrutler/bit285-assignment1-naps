using System;

namespace bit285_assignment1_naps.Models
{
    public class PasswordSuggestionService
    {
        public string GeneratePassword(User user)
        {
            Random rnd = new Random();
            string NwPssWrd = "";
            // Adds three local strings together, each string is a random length,
            // up to the length of the user strings they were pulled from.
            NwPssWrd = NwPssWrd + user.LastName.Substring(0, rnd.Next(user.LastName.Length));
            NwPssWrd = NwPssWrd + user.BirthYear.Substring(0, rnd.Next(user.BirthYear.Length));
            NwPssWrd = NwPssWrd + user.FavColor.Substring(0, rnd.Next(user.FavColor.Length));
            return NwPssWrd;
        }
    }
}
