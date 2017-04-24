using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    /// <summary>
    /// Doesn't do anythings by itself, just holds content for other classes to use
    /// </summary>
    public class Repository
    {
        private static Repository _instance;
        private Repository()
        {

        }
        public static Repository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Repository();
                }
                return _instance;
            }
        }

        public List<Character> Characters = new List<Character>();
        public List<Document> Docs = new List<Document>();
        public List<Location> Locations = new List<Location>();

        public void Add(Document doc)
        {
            Docs.Add(doc);
        }
        public void RemoveDoc(string docName)
        {
            Docs.RemoveAll(x => x.name == docName);
        }


    }
}
