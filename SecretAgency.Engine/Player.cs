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
    }
}
