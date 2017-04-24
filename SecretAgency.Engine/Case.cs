using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    /// <summary>
    /// A unit which consists of multiple events and characters which are related logically, per case basis
    /// </summary>
    public class Case
    {
        public string name; // internal name for id purposes
        public int StartDay;
        public List<Character> Characters = new List<Character>();
        public List<Location> Locations = new List<Location>();

        public Case(string name)
        {
            this.name = name;
            StartDay = Time.Instance.TotalDays;
            
        }
    }
}
