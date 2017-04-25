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
using SecretAgency.Engine.Helpers;
using SecretAgency.Properties;

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
            this.PlayerName_Label.Text = Player.Instance.Title;
            this.Polls_textbox.Text = Player.Instance.Polls.ToString()+"%";
            this.Heat_Textbox.Text = Player.Instance.Heat.ToString();
            LoadTooltips();
            LoadAssets();
        }

        private void LoadAssets()
        {
            this.Assets_listView.Items[0].Text = $"Surveillance   {Player.Instance.Surveillance} [{Player.Instance.MaxSurveillance}]";
            this.Assets_listView.Items[1].Text = $"Pursuit        {Player.Instance.Pursuit} [{Player.Instance.MaxPursuit}]";
            this.Assets_listView.Items[2].Text = $"Search         {Player.Instance.Search} [{Player.Instance.MaxSearch}]";
            this.Assets_listView.Items[3].Text = $"Interrogation  {Player.Instance.Interrogation} [{Player.Instance.MaxInterrogation}]";
            this.Assets_listView.Items[4].Text = $"Removal        {Player.Instance.Removal} [{Player.Instance.MaxRemoval}]";
            this.Assets_listView.Items[5].Text = $"Heavy Assault  {Player.Instance.HeavyAssault} [{Player.Instance.MaxHeavyAssault}]";
            this.Assets_listView.Items[6].Text = $"Disinformation {Player.Instance.Disinformation}$ [{Player.Instance.MaxDisinformation}$]";
            this.Assets_listView.Items[7].Text = $"Infiltration   {Player.Instance.Infiltration} [{Player.Instance.MaxInfiltration}]";
        }

        private void LoadTooltips()
        {
            this.toolTip1.SetToolTip(PlayerName_Label, Resources.PlayerName_Textbox_Tooltip);
            this.toolTip1.SetToolTip(Heat_label,Resources.Heat_Label_Tooltip);
            this.toolTip1.SetToolTip(Assets_label,Resources.Assets_Label_Tooltip);
            this.toolTip1.SetToolTip(Polls_label,Resources.Polls_Label_Tooltip);
            this.toolTip1.SetToolTip(DaysTillReview_label, Resources.DaysTillReview_Label_Tooltip);
            this.toolTip1.SetToolTip(Date_label, Resources.Date_Label_Tooltip);

            this.Assets_listView.Items[0].ToolTipText = Resources.Surveillance_ListItem_Tooltip;
            this.Assets_listView.Items[1].ToolTipText = Resources.Pursuit_ListItem_Tooltip;
            this.Assets_listView.Items[2].ToolTipText = Resources.Search_ListItem_Tooltip;
            this.Assets_listView.Items[3].ToolTipText = Resources.Interrogation_ListItem_Tooltip;
            this.Assets_listView.Items[4].ToolTipText = Resources.Removal_ListItem_Tooltip;
            this.Assets_listView.Items[5].ToolTipText = Resources.HeavyAssault_ListItem_Tooltip;
            this.Assets_listView.Items[6].ToolTipText = Resources.Disinformation_ListItem_Tooltip;
            this.Assets_listView.Items[7].ToolTipText = Resources.Infiltration_ListItem_Tooltip;

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


        private void Main_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0: //General
                    // DrawGeneral();
                    break;
                case 1: //Facts
                    // DrawFacts();
                    break;
                case 2: //Suspects
                    DrawSuspects();
                    break;
                case 3: //Groups
                    // DrawGroups();
                    break;
                case 4: //Locations
                    DrawLocations();
                    break;
                case 5: // Items
                    //DrawItems()
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
            Document d = DocCon.Convert(Repository.Instance.Characters[Suspects_listView.SelectedItems[0].Index],true);
            Suspects_richTextBox.Text = d.Text;
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
            Document d = DocCon.Convert(Repository.Instance.Locations[Locations_listView.SelectedItems[0].Index],true);
            Locations_richTextBox.Text = d.Text;
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
            Archive_Richtextbox.Text = doc.Text;
        }


    }
}
