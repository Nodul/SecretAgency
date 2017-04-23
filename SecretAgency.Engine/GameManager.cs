using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    public class GameManager
    {
        private static GameManager _instance;
        private GameManager()
        {

        }
        public static GameManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GameManager();
                }
                return _instance;
            }
        }




    }
}
