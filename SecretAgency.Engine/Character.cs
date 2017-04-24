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
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string FullName { get {return  FirstName + " " + LastName; } }
        public int Age { get;  set; }
        public Gender Gender { get;  set; }
        public Prominence Prominence { get;  set; }
        public List<string> TriviaList { get;  set; }
        public string Summary { get;  set; }
        public string Occupation { get;  set; }
        public string Address { get;  set; }

        public bool IsRevealed { get;  set; }
        // public Location Location {get; protected set;}

        public Character(bool isRevealed)
        {
            FirstName = TextGen.GetFirstName(this.Gender);
            LastName = TextGen.GetLastName();
            Age = RNG.Rng.Next(18,65);
            TriviaList = new List<string>
            {
                TextGen.GetTrivia()
            };
            //Summary = "Seems to be up to no good";
            Occupation = TextGen.GetOccupation();
            IsRevealed = isRevealed;
            Address = TextGen.GetAddrees();
        }

    }
}
