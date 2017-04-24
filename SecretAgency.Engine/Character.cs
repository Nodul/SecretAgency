using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecretAgency.Engine.Helpers;

namespace SecretAgency.Engine
{
    public enum Gender {Male, Female }
    public enum Prominence {Insignificant, Minor, Significant, Notable }

    public class Character
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string FullName { get {return  FirstName + " " + LastName; } }
        public int Age { get; protected set; }
        public Gender Gender { get; protected set; }
        public Prominence Prominence { get; protected set; }
        public List<string> TriviaList { get; protected set; }
        public string Summary { get; protected set; }
        public string Occupation { get; protected set; }
        // public Location Location {get; protected set;}

        public Character()
        {
            FirstName = TextGen.GetFirstName(this.Gender);
            LastName = TextGen.GetLastName();
            Age = RNG.Rng.Next(18,65);
            TriviaList = new List<string>
            {
                TextGen.GetTrivia()
            };
            Summary = "Seems to be up to no good";
            Occupation = TextGen.GetOccupation();          
        }

    }
}
