using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

    }
}
