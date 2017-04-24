using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecretAgency.Engine;

namespace SecretAgency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Time.Instance.DayPassed += new Time.DayPassedHandler(DateTime_Textbox_Update);
            Time.Instance.DayPassed += new Time.DayPassedHandler(Heat_Textbox_Update);
            Time.Instance.DayPassed += new Time.DayPassedHandler(Polls_Textbox_Update);
            this.PlayerName_textbox.Text = Player.Instance.Title;
            this.Polls_textbox.Text = Player.Instance.Polls.ToString()+"%";
            this.Heat_Textbox.Text = Player.Instance.Heat.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DateTime_textbox.Text = string.Format("{0:00}/{1:00}/{2:00}", Time.Instance.DayOfMonth, Time.Instance.Month, Time.Instance.Year);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void NextDay_button_Click(object sender, EventArgs e)
        {
            Time.Instance.RequestNextDay();
            //this.Refresh(); // TODO also won't work ;/
            //this.NextDay_button.Enabled = false;
           

        }
        private void Heat_Textbox_Update(object sender, EventArgs e)
        {
            this.Heat_Textbox.Text = Player.Instance.Heat.ToString();
        }
        private void Polls_Textbox_Update(object sender, EventArgs e)
        {
            this.Polls_textbox.Text = Player.Instance.Polls.ToString()+"%";
        }
        private void DateTime_Textbox_Update(object sender, DayPassedEventArgs e)
        {
            this.DateTime_textbox.Text = $"{e.Day:00}/{e.Month:00}/{e.Year:0000}";
          
            //NextDay_button.Enabled = true; // TODO this doesn't work! :/

        }

        private void PlayerName_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_textbox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Main_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0: //General
                    break;
                case 1: //Facts
                    break;
                case 2: //Suspects
                    DrawSuspects();
                    break;
                case 3: //Groups
                    break;
                case 4: //Locations
                    DrawLocations();
                    break;
                case 5: //Assets
                    break;
                case 6: //Archive
                    DrawArchives();
                    break;
                default:
                    throw new NullReferenceException("Tried to call an nonexistant tab page");
            }
        }

        private void DrawSuspects()
        {
            Suspects_listView.Items.Clear();
            foreach (Character c in Repository.Instance.Characters)
            {
                if (c.IsRevealed)
                {
                    Suspects_listView.Items.Add(c.FullName);
                }
                
            }
        }
        private void Suspects_listView_ItemActivate(object sender, EventArgs e)
        {
            Character cha = Repository.Instance.Characters[Suspects_listView.SelectedItems[0].Index];
            string entry = $"{cha.FullName}, {cha.Age} y.o.\n{cha.Address}\n\nOccupation: {cha.Occupation}\nProminence: {cha.Prominence}\n\nSummary: {cha.Summary}\n\nNotes: {cha.TriviaList[0]}\n\n[CURRENT ORDERS]"; 
            Suspects_richTextBox.Text = entry;
        }

        private void DrawLocations()
        {
            Locations_listView.Items.Clear();
            foreach(Location l in Repository.Instance.Locations)
            {
                if (l.IsRevealed)
                {
                    Locations_listView.Items.Add(l.Address);
                }
            }
        }

        private void Locations_listView_ItemActivate(object sender, EventArgs e)
        {
            Location loc = Repository.Instance.Locations[Locations_listView.SelectedItems[0].Index];
            string entry = $"{loc.Address}\n\n{loc.Summary}";
            Locations_richTextBox.Text = entry;
        }

        private void DrawArchives()
        {
            Archive_Listview.Items.Clear();
            foreach(Document d in Repository.Instance.Docs)
            {
                if (d.IsRevealed)
                {
                    Archive_Listview.Items.Add(d.DocName);
                }
           
            }
        }

        private void Archive_Listview_ItemActivate(object sender, EventArgs e)
        {
            Document doc = Repository.Instance.Docs[Archive_Listview.SelectedItems[0].Index];
            string entry = string.Format("{0}\n\n{1}\n\n{2}\n\n[CURRENT ORDERS]",doc.HeaderText,doc.BodyText,doc.EndText);
            Archive_Richtextbox.Text = entry;
        }


    }
}
