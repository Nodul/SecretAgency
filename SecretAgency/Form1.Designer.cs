namespace SecretAgency
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Polls_label = new System.Windows.Forms.Label();
            this.Heat_label = new System.Windows.Forms.Label();
            this.Polls_textbox = new System.Windows.Forms.TextBox();
            this.Heat_Textbox = new System.Windows.Forms.TextBox();
            this.nextDay_button = new System.Windows.Forms.Button();
            this.DateTime_textbox = new System.Windows.Forms.TextBox();
            this.PlayerName_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(242, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suspects";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(522, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Groups";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(522, 399);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Locations";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.TabPage5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(522, 399);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Assets";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(522, 399);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Archive";
            this.tabPage7.UseVisualStyleBackColor = true;
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
            // nextDay_button
            // 
            this.nextDay_button.Location = new System.Drawing.Point(692, 6);
            this.nextDay_button.Name = "nextDay_button";
            this.nextDay_button.Size = new System.Drawing.Size(75, 23);
            this.nextDay_button.TabIndex = 5;
            this.nextDay_button.Text = "Next Day";
            this.nextDay_button.UseVisualStyleBackColor = true;
            this.nextDay_button.Click += new System.EventHandler(this.NextDay_button_Click);
            // 
            // DateTime_textbox
            // 
            this.DateTime_textbox.Location = new System.Drawing.Point(586, 8);
            this.DateTime_textbox.Name = "DateTime_textbox";
            this.DateTime_textbox.ReadOnly = true;
            this.DateTime_textbox.Size = new System.Drawing.Size(100, 20);
            this.DateTime_textbox.TabIndex = 6;
            this.DateTime_textbox.TextChanged += new System.EventHandler(this.DateTime_textbox_TextChanged);
            // 
            // PlayerName_textbox
            // 
            this.PlayerName_textbox.Location = new System.Drawing.Point(12, 6);
            this.PlayerName_textbox.Name = "PlayerName_textbox";
            this.PlayerName_textbox.ReadOnly = true;
            this.PlayerName_textbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerName_textbox.TabIndex = 7;
            this.PlayerName_textbox.Text = "PLAYER_NAME";
            this.PlayerName_textbox.TextChanged += new System.EventHandler(this.PlayerName_textbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PlayerName_textbox);
            this.Controls.Add(this.DateTime_textbox);
            this.Controls.Add(this.nextDay_button);
            this.Controls.Add(this.Heat_Textbox);
            this.Controls.Add(this.Polls_textbox);
            this.Controls.Add(this.Heat_label);
            this.Controls.Add(this.Polls_label);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Secret Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label Polls_label;
        private System.Windows.Forms.Label Heat_label;
        private System.Windows.Forms.TextBox Polls_textbox;
        private System.Windows.Forms.TextBox Heat_Textbox;
        private System.Windows.Forms.Button nextDay_button;
        private System.Windows.Forms.TextBox DateTime_textbox;
        private System.Windows.Forms.TextBox PlayerName_textbox;
    }
}

