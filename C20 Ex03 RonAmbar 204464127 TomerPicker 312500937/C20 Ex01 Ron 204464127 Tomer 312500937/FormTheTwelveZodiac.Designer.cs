namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    partial class FormTheTwelveZodiac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheTwelveZodiac));
            this.label1 = new System.Windows.Forms.Label();
            this.theTwelveZodiacLable = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.answersListBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.nextMatchButton = new System.Windows.Forms.Button();
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.matchedFriendsProfilePicture = new C20_Ex01_Ron_204464127_Tomer_312500937.PicturesBoxAdditionalsProxy();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchedFriendName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedFriendsProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // theTwelveZodiacLable
            // 
            this.theTwelveZodiacLable.AllowDrop = true;
            this.theTwelveZodiacLable.AutoEllipsis = true;
            this.theTwelveZodiacLable.AutoSize = true;
            this.theTwelveZodiacLable.BackColor = System.Drawing.Color.Transparent;
            this.theTwelveZodiacLable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.theTwelveZodiacLable.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.theTwelveZodiacLable.Location = new System.Drawing.Point(241, 50);
            this.theTwelveZodiacLable.Name = "theTwelveZodiacLable";
            this.theTwelveZodiacLable.Size = new System.Drawing.Size(209, 25);
            this.theTwelveZodiacLable.TabIndex = 3;
            this.theTwelveZodiacLable.Text = "Let\'s Find You a Match!";
            this.theTwelveZodiacLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.theTwelveZodiacLable.UseMnemonic = false;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.questionLabel.Location = new System.Drawing.Point(157, 87);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(350, 25);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = " Which zodiac sign are you intrested in?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.nextQuestionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextQuestionButton.Location = new System.Drawing.Point(254, 320);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(171, 28);
            this.nextQuestionButton.TabIndex = 6;
            this.nextQuestionButton.Text = "Next question";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // answersListBox
            // 
            this.answersListBox.BackColor = System.Drawing.Color.White;
            this.answersListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answersListBox.FormattingEnabled = true;
            this.answersListBox.Items.AddRange(new object[] {
            "Aguarius",
            "Pisces",
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn"});
            this.answersListBox.Location = new System.Drawing.Point(236, 146);
            this.answersListBox.Name = "answersListBox";
            this.answersListBox.Size = new System.Drawing.Size(218, 29);
            this.answersListBox.TabIndex = 7;
            this.answersListBox.Text = "Aguarius";
            this.answersListBox.SelectedIndexChanged += new System.EventHandler(this.answersZodiacBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Turquoise;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "back To Home Page";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // showResultsButton
            // 
            this.showResultsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.showResultsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResultsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showResultsButton.Location = new System.Drawing.Point(229, 354);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(238, 28);
            this.showResultsButton.TabIndex = 10;
            this.showResultsButton.Text = "Show me the results!";
            this.showResultsButton.UseVisualStyleBackColor = false;
            this.showResultsButton.Visible = false;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click_1);
            // 
            // nextMatchButton
            // 
            this.nextMatchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.nextMatchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMatchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextMatchButton.Location = new System.Drawing.Point(431, 254);
            this.nextMatchButton.Name = "nextMatchButton";
            this.nextMatchButton.Size = new System.Drawing.Size(171, 28);
            this.nextMatchButton.TabIndex = 11;
            this.nextMatchButton.Text = "Next Match";
            this.nextMatchButton.UseVisualStyleBackColor = false;
            this.nextMatchButton.Visible = false;
            this.nextMatchButton.Click += new System.EventHandler(this.nextMatchButton_Click_1);
            // 
            // gamePicture
            // 
            this.gamePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePicture.BackColor = System.Drawing.Color.Ivory;
            this.gamePicture.BackgroundImage = global::C20_Ex01_Ron_204464127_Tomer_312500937.Properties.Resources.astrologyImage;
            this.gamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePicture.ErrorImage = null;
            this.gamePicture.InitialImage = null;
            this.gamePicture.Location = new System.Drawing.Point(0, -2);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(702, 415);
            this.gamePicture.TabIndex = 13;
            this.gamePicture.TabStop = false;
            this.gamePicture.WaitOnLoad = true;
            // 
            // matchedFriendsProfilePicture
            // 
            this.matchedFriendsProfilePicture.Location = new System.Drawing.Point(263, 164);
            this.matchedFriendsProfilePicture.Name = "matchedFriendsProfilePicture";
            this.matchedFriendsProfilePicture.Size = new System.Drawing.Size(171, 141);
            this.matchedFriendsProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.matchedFriendsProfilePicture.TabIndex = 14;
            this.matchedFriendsProfilePicture.TabStop = false;
            this.matchedFriendsProfilePicture.Visible = false;
            this.matchedFriendsProfilePicture.Click += new System.EventHandler(this.matchedFriendsProfilePicture_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // matchedFriendName
            // 
            this.matchedFriendName.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchedFriendName.Location = new System.Drawing.Point(246, 311);
            this.matchedFriendName.Name = "matchedFriendName";
            this.matchedFriendName.Size = new System.Drawing.Size(204, 30);
            this.matchedFriendName.TabIndex = 15;
            this.matchedFriendName.Visible = false;
            // 
            // FormTheTwelveZodiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 407);
            this.Controls.Add(this.matchedFriendName);
            this.Controls.Add(this.matchedFriendsProfilePicture);
            this.Controls.Add(this.nextMatchButton);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answersListBox);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.theTwelveZodiacLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTheTwelveZodiac";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The Twelve Zodiac";
            this.Load += new System.EventHandler(this.formTheTwelveZodiac);
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedFriendsProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label theTwelveZodiacLable;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.ComboBox answersListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.Button nextMatchButton;
        private System.Windows.Forms.PictureBox gamePicture;
        private C20_Ex01_Ron_204464127_Tomer_312500937.PicturesBoxAdditionalsProxy matchedFriendsProfilePicture;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox matchedFriendName;
    }
}