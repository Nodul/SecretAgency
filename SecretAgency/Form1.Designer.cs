﻿namespace SecretAgency
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("SURVEILLANCE");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("PURSUIT");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("SEARCH");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("INTERROGATION");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("REMOVAL");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("HEAVY ASSAULT");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("DISINFORMATION");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("INFILTRATION");
            this.Main_tabControl = new System.Windows.Forms.TabControl();
            this.General_Tabpage = new System.Windows.Forms.TabPage();
            this.Facts_Tabpage = new System.Windows.Forms.TabPage();
            this.Suspects_Tabpage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Suspects_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Suspects_listView = new System.Windows.Forms.ListView();
            this.Groups_Tagpage = new System.Windows.Forms.TabPage();
            this.Locations_Tabpage = new System.Windows.Forms.TabPage();
            this.Locations_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Locations_listView = new System.Windows.Forms.ListView();
            this.Items_Tabpage = new System.Windows.Forms.TabPage();
            this.Archive_Tabpage = new System.Windows.Forms.TabPage();
            this.Archive_Richtextbox = new System.Windows.Forms.RichTextBox();
            this.Archive_Listview = new System.Windows.Forms.ListView();
            this.Polls_label = new System.Windows.Forms.Label();
            this.Heat_label = new System.Windows.Forms.Label();
            this.Polls_textbox = new System.Windows.Forms.TextBox();
            this.Heat_Textbox = new System.Windows.Forms.TextBox();
            this.NextDay_button = new System.Windows.Forms.Button();
            this.DateTime_textbox = new System.Windows.Forms.TextBox();
            this.Assets_listView = new System.Windows.Forms.ListView();
            this.Assets_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Date_label = new System.Windows.Forms.Label();
            this.DaysTillReview_label = new System.Windows.Forms.Label();
            this.DaysTillReview_textBox = new System.Windows.Forms.TextBox();
            this.PlayerName_Label = new System.Windows.Forms.Label();
            this.Main_tabControl.SuspendLayout();
            this.Suspects_Tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Locations_Tabpage.SuspendLayout();
            this.Archive_Tabpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tabControl
            // 
            this.Main_tabControl.Controls.Add(this.General_Tabpage);
            this.Main_tabControl.Controls.Add(this.Facts_Tabpage);
            this.Main_tabControl.Controls.Add(this.Suspects_Tabpage);
            this.Main_tabControl.Controls.Add(this.Groups_Tagpage);
            this.Main_tabControl.Controls.Add(this.Locations_Tabpage);
            this.Main_tabControl.Controls.Add(this.Items_Tabpage);
            this.Main_tabControl.Controls.Add(this.Archive_Tabpage);
            this.Main_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Main_tabControl.Location = new System.Drawing.Point(242, 60);
            this.Main_tabControl.Name = "Main_tabControl";
            this.Main_tabControl.SelectedIndex = 0;
            this.Main_tabControl.Size = new System.Drawing.Size(530, 425);
            this.Main_tabControl.TabIndex = 0;
            this.Main_tabControl.SelectedIndexChanged += new System.EventHandler(this.Main_tabControl_SelectedIndexChanged);
            // 
            // General_Tabpage
            // 
            this.General_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.General_Tabpage.Name = "General_Tabpage";
            this.General_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.General_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.General_Tabpage.TabIndex = 0;
            this.General_Tabpage.Text = "General";
            this.General_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Facts_Tabpage
            // 
            this.Facts_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.Facts_Tabpage.Name = "Facts_Tabpage";
            this.Facts_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Facts_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.Facts_Tabpage.TabIndex = 1;
            this.Facts_Tabpage.Text = "Facts";
            this.Facts_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Suspects_Tabpage
            // 
            this.Suspects_Tabpage.Controls.Add(this.pictureBox1);
            this.Suspects_Tabpage.Controls.Add(this.Suspects_richTextBox);
            this.Suspects_Tabpage.Controls.Add(this.Suspects_listView);
            this.Suspects_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.Suspects_Tabpage.Name = "Suspects_Tabpage";
            this.Suspects_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Suspects_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.Suspects_Tabpage.TabIndex = 2;
            this.Suspects_Tabpage.Text = "Suspects";
            this.Suspects_Tabpage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(437, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 102);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Suspects_richTextBox
            // 
            this.Suspects_richTextBox.Location = new System.Drawing.Point(207, 7);
            this.Suspects_richTextBox.Name = "Suspects_richTextBox";
            this.Suspects_richTextBox.ReadOnly = true;
            this.Suspects_richTextBox.Size = new System.Drawing.Size(309, 386);
            this.Suspects_richTextBox.TabIndex = 1;
            this.Suspects_richTextBox.Text = "";
            // 
            // Suspects_listView
            // 
            this.Suspects_listView.Location = new System.Drawing.Point(7, 7);
            this.Suspects_listView.Name = "Suspects_listView";
            this.Suspects_listView.Size = new System.Drawing.Size(193, 386);
            this.Suspects_listView.TabIndex = 0;
            this.Suspects_listView.UseCompatibleStateImageBehavior = false;
            this.Suspects_listView.ItemActivate += new System.EventHandler(this.Suspects_listView_ItemActivate);
            // 
            // Groups_Tagpage
            // 
            this.Groups_Tagpage.Location = new System.Drawing.Point(4, 22);
            this.Groups_Tagpage.Name = "Groups_Tagpage";
            this.Groups_Tagpage.Padding = new System.Windows.Forms.Padding(3);
            this.Groups_Tagpage.Size = new System.Drawing.Size(522, 399);
            this.Groups_Tagpage.TabIndex = 3;
            this.Groups_Tagpage.Text = "Groups";
            this.Groups_Tagpage.UseVisualStyleBackColor = true;
            // 
            // Locations_Tabpage
            // 
            this.Locations_Tabpage.Controls.Add(this.Locations_richTextBox);
            this.Locations_Tabpage.Controls.Add(this.Locations_listView);
            this.Locations_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.Locations_Tabpage.Name = "Locations_Tabpage";
            this.Locations_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Locations_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.Locations_Tabpage.TabIndex = 4;
            this.Locations_Tabpage.Text = "Locations";
            this.Locations_Tabpage.UseVisualStyleBackColor = true;
            this.Locations_Tabpage.Click += new System.EventHandler(this.TabPage5_Click);
            // 
            // Locations_richTextBox
            // 
            this.Locations_richTextBox.Location = new System.Drawing.Point(227, 7);
            this.Locations_richTextBox.Name = "Locations_richTextBox";
            this.Locations_richTextBox.ReadOnly = true;
            this.Locations_richTextBox.Size = new System.Drawing.Size(289, 386);
            this.Locations_richTextBox.TabIndex = 1;
            this.Locations_richTextBox.Text = "";
            // 
            // Locations_listView
            // 
            this.Locations_listView.Location = new System.Drawing.Point(7, 7);
            this.Locations_listView.Name = "Locations_listView";
            this.Locations_listView.Size = new System.Drawing.Size(213, 386);
            this.Locations_listView.TabIndex = 0;
            this.Locations_listView.UseCompatibleStateImageBehavior = false;
            this.Locations_listView.ItemActivate += new System.EventHandler(this.Locations_listView_ItemActivate);
            // 
            // Items_Tabpage
            // 
            this.Items_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.Items_Tabpage.Name = "Items_Tabpage";
            this.Items_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.Items_Tabpage.TabIndex = 7;
            this.Items_Tabpage.Text = "Items";
            this.Items_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Archive_Tabpage
            // 
            this.Archive_Tabpage.Controls.Add(this.Archive_Richtextbox);
            this.Archive_Tabpage.Controls.Add(this.Archive_Listview);
            this.Archive_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.Archive_Tabpage.Name = "Archive_Tabpage";
            this.Archive_Tabpage.Size = new System.Drawing.Size(522, 399);
            this.Archive_Tabpage.TabIndex = 6;
            this.Archive_Tabpage.Text = "Archive";
            this.Archive_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Archive_Richtextbox
            // 
            this.Archive_Richtextbox.Location = new System.Drawing.Point(179, 4);
            this.Archive_Richtextbox.Name = "Archive_Richtextbox";
            this.Archive_Richtextbox.ReadOnly = true;
            this.Archive_Richtextbox.Size = new System.Drawing.Size(340, 392);
            this.Archive_Richtextbox.TabIndex = 1;
            this.Archive_Richtextbox.Text = "";
            // 
            // Archive_Listview
            // 
            this.Archive_Listview.Location = new System.Drawing.Point(4, 4);
            this.Archive_Listview.MultiSelect = false;
            this.Archive_Listview.Name = "Archive_Listview";
            this.Archive_Listview.Size = new System.Drawing.Size(169, 392);
            this.Archive_Listview.TabIndex = 0;
            this.Archive_Listview.UseCompatibleStateImageBehavior = false;
            this.Archive_Listview.ItemActivate += new System.EventHandler(this.Archive_Listview_ItemActivate);
            // 
            // Polls_label
            // 
            this.Polls_label.AutoSize = true;
            this.Polls_label.Location = new System.Drawing.Point(12, 35);
            this.Polls_label.Name = "Polls_label";
            this.Polls_label.Size = new System.Drawing.Size(29, 13);
            this.Polls_label.TabIndex = 1;
            this.Polls_label.Text = "Polls";
            // 
            // Heat_label
            // 
            this.Heat_label.AutoSize = true;
            this.Heat_label.Location = new System.Drawing.Point(12, 60);
            this.Heat_label.Name = "Heat_label";
            this.Heat_label.Size = new System.Drawing.Size(30, 13);
            this.Heat_label.TabIndex = 2;
            this.Heat_label.Text = "Heat";
            this.Heat_label.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Polls_textbox
            // 
            this.Polls_textbox.Location = new System.Drawing.Point(54, 32);
            this.Polls_textbox.Name = "Polls_textbox";
            this.Polls_textbox.ReadOnly = true;
            this.Polls_textbox.Size = new System.Drawing.Size(32, 20);
            this.Polls_textbox.TabIndex = 3;
            // 
            // Heat_Textbox
            // 
            this.Heat_Textbox.Location = new System.Drawing.Point(54, 57);
            this.Heat_Textbox.Name = "Heat_Textbox";
            this.Heat_Textbox.ReadOnly = true;
            this.Heat_Textbox.Size = new System.Drawing.Size(32, 20);
            this.Heat_Textbox.TabIndex = 4;
            // 
            // NextDay_button
            // 
            this.NextDay_button.Location = new System.Drawing.Point(692, 6);
            this.NextDay_button.Name = "NextDay_button";
            this.NextDay_button.Size = new System.Drawing.Size(75, 23);
            this.NextDay_button.TabIndex = 5;
            this.NextDay_button.Text = "Next Day";
            this.NextDay_button.UseVisualStyleBackColor = true;
            this.NextDay_button.Click += new System.EventHandler(this.NextDay_button_Click);
            // 
            // DateTime_textbox
            // 
            this.DateTime_textbox.Location = new System.Drawing.Point(586, 8);
            this.DateTime_textbox.Name = "DateTime_textbox";
            this.DateTime_textbox.ReadOnly = true;
            this.DateTime_textbox.Size = new System.Drawing.Size(100, 20);
            this.DateTime_textbox.TabIndex = 6;
            // 
            // Assets_listView
            // 
            listViewItem21.ToolTipText = "HEAVY ASSAULT";
            this.Assets_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.Assets_listView.Location = new System.Drawing.Point(15, 236);
            this.Assets_listView.MultiSelect = false;
            this.Assets_listView.Name = "Assets_listView";
            this.Assets_listView.ShowItemToolTips = true;
            this.Assets_listView.Size = new System.Drawing.Size(221, 249);
            this.Assets_listView.TabIndex = 8;
            this.Assets_listView.UseCompatibleStateImageBehavior = false;
            this.Assets_listView.View = System.Windows.Forms.View.Tile;
            // 
            // Assets_label
            // 
            this.Assets_label.AutoSize = true;
            this.Assets_label.Location = new System.Drawing.Point(12, 220);
            this.Assets_label.Name = "Assets_label";
            this.Assets_label.Size = new System.Drawing.Size(41, 13);
            this.Assets_label.TabIndex = 9;
            this.Assets_label.Text = "Assets:";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(545, 12);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(30, 13);
            this.Date_label.TabIndex = 10;
            this.Date_label.Text = "Date";
            // 
            // DaysTillReview_label
            // 
            this.DaysTillReview_label.AutoSize = true;
            this.DaysTillReview_label.Location = new System.Drawing.Point(475, 27);
            this.DaysTillReview_label.Name = "DaysTillReview_label";
            this.DaysTillReview_label.Size = new System.Drawing.Size(105, 13);
            this.DaysTillReview_label.TabIndex = 11;
            this.DaysTillReview_label.Text = "Days till next Review";
            // 
            // DaysTillReview_textBox
            // 
            this.DaysTillReview_textBox.Location = new System.Drawing.Point(586, 24);
            this.DaysTillReview_textBox.Name = "DaysTillReview_textBox";
            this.DaysTillReview_textBox.ReadOnly = true;
            this.DaysTillReview_textBox.Size = new System.Drawing.Size(100, 20);
            this.DaysTillReview_textBox.TabIndex = 12;
            this.DaysTillReview_textBox.Text = "Not implemented";
            // 
            // PlayerName_Label
            // 
            this.PlayerName_Label.AutoSize = true;
            this.PlayerName_Label.Location = new System.Drawing.Point(12, 12);
            this.PlayerName_Label.Name = "PlayerName_Label";
            this.PlayerName_Label.Size = new System.Drawing.Size(86, 13);
            this.PlayerName_Label.TabIndex = 13;
            this.PlayerName_Label.Text = "PLAYER_NAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PlayerName_Label);
            this.Controls.Add(this.DaysTillReview_textBox);
            this.Controls.Add(this.DaysTillReview_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Assets_label);
            this.Controls.Add(this.Assets_listView);
            this.Controls.Add(this.DateTime_textbox);
            this.Controls.Add(this.NextDay_button);
            this.Controls.Add(this.Heat_Textbox);
            this.Controls.Add(this.Polls_textbox);
            this.Controls.Add(this.Heat_label);
            this.Controls.Add(this.Polls_label);
            this.Controls.Add(this.Main_tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Secret Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_tabControl.ResumeLayout(false);
            this.Suspects_Tabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Locations_Tabpage.ResumeLayout(false);
            this.Archive_Tabpage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Main_tabControl;
        private System.Windows.Forms.TabPage General_Tabpage;
        private System.Windows.Forms.TabPage Facts_Tabpage;
        private System.Windows.Forms.TabPage Suspects_Tabpage;
        private System.Windows.Forms.TabPage Groups_Tagpage;
        private System.Windows.Forms.TabPage Locations_Tabpage;
        private System.Windows.Forms.TabPage Archive_Tabpage;
        private System.Windows.Forms.Label Polls_label;
        private System.Windows.Forms.Label Heat_label;
        private System.Windows.Forms.TextBox Polls_textbox;
        private System.Windows.Forms.TextBox Heat_Textbox;
        private System.Windows.Forms.Button NextDay_button;
        private System.Windows.Forms.TextBox DateTime_textbox;
        private System.Windows.Forms.RichTextBox Archive_Richtextbox;
        private System.Windows.Forms.ListView Archive_Listview;
        private System.Windows.Forms.RichTextBox Suspects_richTextBox;
        private System.Windows.Forms.ListView Suspects_listView;
        private System.Windows.Forms.RichTextBox Locations_richTextBox;
        private System.Windows.Forms.ListView Locations_listView;
        private System.Windows.Forms.TabPage Items_Tabpage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView Assets_listView;
        private System.Windows.Forms.Label Assets_label;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label DaysTillReview_label;
        private System.Windows.Forms.TextBox DaysTillReview_textBox;
        private System.Windows.Forms.Label PlayerName_Label;
    }
}

