using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecretAgency.Engine.Helpers
{
    /// <summary>
    /// Text generator helper class
    /// </summary>
    public static class TextGen
    {
        static Random rnd = new Random();
        static string[] maleNames = new string[] { "John", "Arnold", "Ben", "Michael", "Robert", "Aaron","Bruce","Richard" };
        static string[] femaleNames = new string[] { "Alice", "Eve", "Hannah", "Judy", "Mary", "Lara" };
        static string[] lastNames = new string[] { "Dylan", "Smith", "Robinson", "Stiller", "Rothstein", "Kowalski" };
        static string[] trivias = new string[] { "Likes to smoke", "Athletic","Physically weak","Has nerve ticks" };
        static string[] occupations = new string[] {"Unemployed","Factory worker","Scientist","Clerk","Security guard" };

        public static string GetFirstName(Gender gender)
        {
            if(gender == Gender.Male)
            {
                return maleNames[RNG.Rng.Next(0, maleNames.Length)];
            }
            else
            {
                return femaleNames[RNG.Rng.Next(0, femaleNames.Length)];
            }
        }
        public static string GetLastName()
        {
            return lastNames[RNG.Rng.Next(0, lastNames.Length)];
        }

        public static string GetTrivia()
        {
            return trivias[RNG.Rng.Next(0, trivias.Length)];
        }
        // Can add tiering by prominence lvl later
        public static string GetOccupation()
        {
            return occupations[RNG.Rng.Next(0, occupations.Length)];
        }
    }
}
