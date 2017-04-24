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
            Time.Instance.DayPassed += new Time.DayPassedHandler(this.DayPassed);
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



        private void DayPassed(object sender, DayPassedEventArgs e)
        {
            //Console.WriteLine("GameNanager sees that it is now day {0} and {1} days have passed in total",e.Day,e.TotalDays);
            if (Time.Instance.TotalDays == 1) CaseManager.Instance.AddTestCase();
        }

        public void Init()
        {
            Console.WriteLine("GameManager Initializing");
            // Add start documents - so the player knows what to do
            Repository.Instance.Docs.Add(new Document
            {
                name = "intro1",
                DocName = "Briefing",
                HeaderText = "To the new Director-General. EYES ONLY",
                BodyText = "Please use any available assets to ensure that our Party leads in polls. Use discretion or we will be forced to enforce silence.",
                EndText = "Glory to NTD!"
                
            });
            Repository.Instance.Docs.Add(new Document
            {
                name = "intro2",
                DocName = "Advice",
                HeaderText = "To the new Director-General. EYES ONLY",
                BodyText = "Send agents to gather information on any suspects and locations. Once you have enough information, decide on a course of action which will benefit NTD",
                EndText = "Glory to NTD!"

            });

        }
    }
}
