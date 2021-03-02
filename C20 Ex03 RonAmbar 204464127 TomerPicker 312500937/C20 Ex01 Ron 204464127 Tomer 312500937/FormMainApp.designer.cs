namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    partial class MainAppForm
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HomePageTab = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.aboutInfoPanel = new System.Windows.Forms.Panel();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.checkinsListBox = new System.Windows.Forms.ListBox();
            this.profilePicture = new C20_Ex01_Ron_204464127_Tomer_312500937.PicturesBoxAdditionalsProxy();
            this.logOutButton = new System.Windows.Forms.Button();
            this.lastPostsLable = new System.Windows.Forms.Label();
            this.checkinsLable = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.pesonalInfoLable = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.WelcomeLabel = new C20_Ex01_Ron_204464127_Tomer_312500937.ActiveLable();
            this.triviaGame = new System.Windows.Forms.TabPage();
            this.playButton = new System.Windows.Forms.Button();
            this.triviaWelcomeLable = new System.Windows.Forms.Label();
            this.zodiacTab = new System.Windows.Forms.TabPage();
            this.findYourZodiacLable = new System.Windows.Forms.Label();
            this.startZodiacMatchButton = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.HomePageTab.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.aboutInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.triviaGame.SuspendLayout();
            this.zodiacTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(13, 42);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(75, 21);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(15, 69);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 21);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(13, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // HomePageTab
            // 
            this.HomePageTab.Controls.Add(this.homeTab);
            this.HomePageTab.Controls.Add(this.triviaGame);
            this.HomePageTab.Controls.Add(this.zodiacTab);
            this.HomePageTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HomePageTab.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.HomePageTab.Location = new System.Drawing.Point(2, 2);
            this.HomePageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.SelectedIndex = 0;
            this.HomePageTab.ShowToolTips = true;
            this.HomePageTab.Size = new System.Drawing.Size(795, 594);
            this.HomePageTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.HomePageTab.TabIndex = 0;
            this.HomePageTab.TabStop = false;
            // 
            // homeTab
            // 
            this.homeTab.AutoScroll = true;
            this.homeTab.BackgroundImage = global::C20_Ex01_Ron_204464127_Tomer_312500937.Properties.Resources.HomePageGameBackground;
            this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeTab.Controls.Add(this.aboutInfoPanel);
            this.homeTab.Controls.Add(this.postsListBox);
            this.homeTab.Controls.Add(this.checkinsListBox);
            this.homeTab.Controls.Add(this.profilePicture);
            this.homeTab.Controls.Add(this.logOutButton);
            this.homeTab.Controls.Add(this.lastPostsLable);
            this.homeTab.Controls.Add(this.checkinsLable);
            this.homeTab.Controls.Add(this.friendsLabel);
            this.homeTab.Controls.Add(this.pesonalInfoLable);
            this.homeTab.Controls.Add(this.coverPictureBox);
            this.homeTab.Controls.Add(this.friendsListBox);
            this.homeTab.Controls.Add(this.WelcomeLabel);
            this.homeTab.Location = new System.Drawing.Point(4, 30);
            this.homeTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeTab.Size = new System.Drawing.Size(787, 560);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            this.homeTab.Click += new System.EventHandler(this.homeTab_Click);
            // 
            // aboutInfoPanel
            // 
            this.aboutInfoPanel.Controls.Add(birthdayLabel);
            this.aboutInfoPanel.Controls.Add(this.birthdayTextBox);
            this.aboutInfoPanel.Controls.Add(emailLabel);
            this.aboutInfoPanel.Controls.Add(this.emailTextBox);
            this.aboutInfoPanel.Controls.Add(nameLabel);
            this.aboutInfoPanel.Controls.Add(this.nameTextBox);
            this.aboutInfoPanel.Location = new System.Drawing.Point(16, 319);
            this.aboutInfoPanel.Name = "aboutInfoPanel";
            this.aboutInfoPanel.Size = new System.Drawing.Size(247, 105);
            this.aboutInfoPanel.TabIndex = 18;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(72, 39);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 29);
            this.birthdayTextBox.TabIndex = 1;
            this.birthdayTextBox.TextChanged += new System.EventHandler(this.birthdayTextBox_TextChanged);
            this.birthdayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.birthdayTextBox_Validating);
            this.birthdayTextBox.Validated += new System.EventHandler(this.birthdayTextBox_Validated);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(72, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(156, 29);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(72, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 29);
            this.nameTextBox.TabIndex = 5;
            // 
            // postsListBox
            // 
            this.postsListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.postsListBox.DisplayMember = "Caption";
            this.postsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 25;
            this.postsListBox.Location = new System.Drawing.Point(520, 319);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(184, 154);
            this.postsListBox.TabIndex = 16;
            this.postsListBox.ValueMember = "Caption";
            // 
            // checkinsListBox
            // 
            this.checkinsListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkinsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.checkinsListBox.FormattingEnabled = true;
            this.checkinsListBox.ItemHeight = 25;
            this.checkinsListBox.Location = new System.Drawing.Point(283, 319);
            this.checkinsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkinsListBox.Name = "checkinsListBox";
            this.checkinsListBox.Size = new System.Drawing.Size(179, 154);
            this.checkinsListBox.TabIndex = 14;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(16, 10);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(139, 143);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 12;
            this.profilePicture.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.logOutButton.Location = new System.Drawing.Point(16, 518);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(122, 41);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // lastPostsLable
            // 
            this.lastPostsLable.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lastPostsLable.Location = new System.Drawing.Point(517, 276);
            this.lastPostsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastPostsLable.Name = "lastPostsLable";
            this.lastPostsLable.Size = new System.Drawing.Size(182, 41);
            this.lastPostsLable.TabIndex = 10;
            this.lastPostsLable.Text = "Your Last Posts";
            this.lastPostsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastPostsLable.Click += new System.EventHandler(this.lastPostsLable_Click);
            // 
            // checkinsLable
            // 
            this.checkinsLable.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.checkinsLable.Location = new System.Drawing.Point(280, 285);
            this.checkinsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinsLable.Name = "checkinsLable";
            this.checkinsLable.Size = new System.Drawing.Size(182, 22);
            this.checkinsLable.TabIndex = 9;
            this.checkinsLable.Text = "Your Last Checkins";
            this.checkinsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinsLable.Click += new System.EventHandler(this.checkinsLable_Click);
            // 
            // friendsLabel
            // 
            this.friendsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.friendsLabel.Location = new System.Drawing.Point(517, 10);
            this.friendsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendsLabel.Name = "friendsLabel";
            this.friendsLabel.Size = new System.Drawing.Size(182, 22);
            this.friendsLabel.TabIndex = 8;
            this.friendsLabel.Text = "Your Friends";
            this.friendsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.friendsLabel.Click += new System.EventHandler(this.friendsLabel_Click);
            // 
            // pesonalInfoLable
            // 
            this.pesonalInfoLable.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.pesonalInfoLable.Location = new System.Drawing.Point(-4, 285);
            this.pesonalInfoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pesonalInfoLable.Name = "pesonalInfoLable";
            this.pesonalInfoLable.Size = new System.Drawing.Size(182, 22);
            this.pesonalInfoLable.TabIndex = 7;
            this.pesonalInfoLable.Text = "Your About Info";
            this.pesonalInfoLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pesonalInfoLable.Click += new System.EventHandler(this.pesonalInfoLable_Click);
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.coverPictureBox.Location = new System.Drawing.Point(194, 10);
            this.coverPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(254, 158);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 6;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.Click += new System.EventHandler(this.coverPictureBox_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.friendsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 25;
            this.friendsListBox.Location = new System.Drawing.Point(520, 37);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(170, 154);
            this.friendsListBox.TabIndex = 4;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Location = new System.Drawing.Point(190, 219);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(381, 88);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome messege";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // triviaGame
            // 
            this.triviaGame.BackgroundImage = global::C20_Ex01_Ron_204464127_Tomer_312500937.Properties.Resources.Zoom_Question_Marks;
            this.triviaGame.Controls.Add(this.playButton);
            this.triviaGame.Controls.Add(this.triviaWelcomeLable);
            this.triviaGame.Location = new System.Drawing.Point(4, 30);
            this.triviaGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triviaGame.Name = "triviaGame";
            this.triviaGame.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triviaGame.Size = new System.Drawing.Size(787, 560);
            this.triviaGame.TabIndex = 1;
            this.triviaGame.Text = "Trivia Game";
            this.triviaGame.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.playButton.Location = new System.Drawing.Point(266, 241);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(217, 88);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // triviaWelcomeLable
            // 
            this.triviaWelcomeLable.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.triviaWelcomeLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.triviaWelcomeLable.Location = new System.Drawing.Point(138, 33);
            this.triviaWelcomeLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.triviaWelcomeLable.Name = "triviaWelcomeLable";
            this.triviaWelcomeLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triviaWelcomeLable.Size = new System.Drawing.Size(477, 122);
            this.triviaWelcomeLable.TabIndex = 2;
            this.triviaWelcomeLable.Text = "Let\'s Play Friends Trivia Game !";
            this.triviaWelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.triviaWelcomeLable.Click += new System.EventHandler(this.triviaWelcomeLable_Click);
            // 
            // zodiacTab
            // 
            this.zodiacTab.BackgroundImage = global::C20_Ex01_Ron_204464127_Tomer_312500937.Properties.Resources.ZodiacTabBackground;
            this.zodiacTab.Controls.Add(this.findYourZodiacLable);
            this.zodiacTab.Controls.Add(this.startZodiacMatchButton);
            this.zodiacTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zodiacTab.Location = new System.Drawing.Point(4, 30);
            this.zodiacTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zodiacTab.Name = "zodiacTab";
            this.zodiacTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zodiacTab.Size = new System.Drawing.Size(787, 560);
            this.zodiacTab.TabIndex = 2;
            this.zodiacTab.Text = "Zodiac Match";
            this.zodiacTab.UseVisualStyleBackColor = true;
            // 
            // findYourZodiacLable
            // 
            this.findYourZodiacLable.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.findYourZodiacLable.Location = new System.Drawing.Point(157, 27);
            this.findYourZodiacLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findYourZodiacLable.Name = "findYourZodiacLable";
            this.findYourZodiacLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.findYourZodiacLable.Size = new System.Drawing.Size(477, 118);
            this.findYourZodiacLable.TabIndex = 5;
            this.findYourZodiacLable.Text = "Find Your Zodiac Match !";
            this.findYourZodiacLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findYourZodiacLable.Click += new System.EventHandler(this.findYourZodiacLable_Click);
            // 
            // startZodiacMatchButton
            // 
            this.startZodiacMatchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startZodiacMatchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.startZodiacMatchButton.Location = new System.Drawing.Point(281, 231);
            this.startZodiacMatchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startZodiacMatchButton.Name = "startZodiacMatchButton";
            this.startZodiacMatchButton.Size = new System.Drawing.Size(212, 90);
            this.startZodiacMatchButton.TabIndex = 4;
            this.startZodiacMatchButton.Text = "Start";
            this.startZodiacMatchButton.UseVisualStyleBackColor = false;
            this.startZodiacMatchButton.Click += new System.EventHandler(this.startZodiacMatchButton_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 596);
            this.Controls.Add(this.HomePageTab);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.HomePageTab.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.aboutInfoPanel.ResumeLayout(false);
            this.aboutInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.triviaGame.ResumeLayout(false);
            this.zodiacTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HomePageTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage triviaGame;
        private System.Windows.Forms.TabPage zodiacTab;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label triviaWelcomeLable;
        private System.Windows.Forms.Button startZodiacMatchButton;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label findYourZodiacLable;
        private System.Windows.Forms.Label checkinsLable;
        private System.Windows.Forms.Label friendsLabel;
        private System.Windows.Forms.Label pesonalInfoLable;
        private System.Windows.Forms.Label lastPostsLable;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ListBox checkinsListBox;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.Panel aboutInfoPanel;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private ActiveLable WelcomeLabel;
        private PicturesBoxAdditionalsProxy profilePicture;
    }
}