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
        }
        private void DateTime_Textbox_Update(object sender, DayPassedEventArgs e)
        {
            this.DateTime_textbox.Text = $"{e.Day:00}/{e.Month:00}/{e.Year:0000}";
        }

        private void PlayerName_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
