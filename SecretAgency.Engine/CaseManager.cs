using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    /// <summary>
    /// The heart of the game. Responsible for keeping track of cases, creating new ones, making sure the progress properly and they react to player actions.
    /// </summary>
    public class CaseManager
    {
        private static CaseManager _instance;
        private CaseManager()
        {

        }
        public static CaseManager Instance
        {
            get
            {
                if (_instance == null) _instance = new CaseManager();
                return _instance;
            }
        }

        public List<Case> Cases = new List<Case>();

        /// <summary>
        /// Request a new case to be made
        /// </summary>
        public void NewCase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This will be removed later in the development
        /// </summary>
        public void AddTestCase()
        {
            Case _case = new Case("intro_case");
            Character _char = new Character();
            Location _loc = new Location();
            Repository.Instance.Characters.Add(_char);
            Repository.Instance.Locations.Add(_loc);
            _case.Characters.Add(_char);
            _case.Locations.Add(_loc);
            Cases.Add(_case);
            Console.WriteLine("Test case created");
        }
    }
}
