using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    public class Player
    {
        private static Player _instance;
        private Player()
        {
            _name = "K";
            _gender = Gender.Male;
            _polls = 50;
            _heat = 0;
            Surveillance = 2;
            MaxSurveillance = Surveillance;
            Pursuit = 2;
            MaxPursuit = Pursuit;
            Search = 2;
            MaxSearch = Search;
            Interrogation = 2;
            MaxInterrogation = Interrogation;
            Removal = 1;
            MaxRemoval = Removal;
            HeavyAssault = 1;
            MaxHeavyAssault = HeavyAssault;
            Disinformation = 20000;
            MaxDisinformation = Disinformation;
            Infiltration = 100;
            MaxInfiltration = Infiltration;
        }
        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Player();
                }
                return _instance;
            }
        }

        private string _name;
        public string Name { get { return _name; }  set { _name = value; } }
        private Gender _gender;
        public Gender Gender { get { return _gender; } set { _gender = value; } }

        public string Title
        {
            get
            {
                string r = "";
                switch (_gender)
                {
                    case Gender.Male:
                        r = "Mr.";
                        break;
                    case Gender.Female:
                        r = "Mrs.";
                        break;
                }

                return r + _name;
            }
        }

        private int _polls;
        public int Polls { get { return _polls; } set { _polls = value; } }

        private int _heat;
        public int Heat { get { return _heat; } set { _heat = value; } }

        // ASSETS
        public int Surveillance { get; set; }
        public int Pursuit { get; set; }
        public int Search { get; set; }
        public int Interrogation { get; set; }
        public int Removal { get; set; }
        public int HeavyAssault { get; set; }
        public int Disinformation { get; set; }
        public int Infiltration { get; set; }

        public int MaxSurveillance { get; set; }
        public int MaxPursuit { get; set; }
        public int MaxSearch { get; set; }
        public int MaxInterrogation { get; set; }
        public int MaxRemoval { get; set; }
        public int MaxHeavyAssault { get; set; }
        public int MaxDisinformation { get; set; }
        public int MaxInfiltration { get; set; }
    }
}
