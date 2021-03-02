using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C20_Ex01_Ron_204464127_Tomer_312500937;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    public partial class MainAppForm : Form
    {
        private User m_LoggedInUser;

        public MainAppForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            this.m_LoggedInUser = AppLogic.SingletonLoggedInUser.Instance.LoggedInUser;
            initialiizeHomePage();
            this.triviaWelcomeLable.BackColor = Color.Transparent;
            this.findYourZodiacLable.BackColor = Color.Transparent;
        }

        private void initialiizeHomePage()
        {
            fetchProfilePicture();
            fetchCoverPicture();
            fetchWelcomeMessege();
            fetchHomeLables();
            fetchPersonalInfoListBox();
            this.checkinsListBox.Hide();
            this.postsListBox.Hide();
            this.friendsListBox.Hide();        
        }

        private void fetchHomeLables()
        {
            this.checkinsLable.Show();
            checkinsLable.BackColor = Color.Transparent;
            this.pesonalInfoLable.Show();
            pesonalInfoLable.BackColor = Color.Transparent;
            this.lastPostsLable.Show();
            lastPostsLable.BackColor = Color.Transparent;
            this.friendsLabel.Show();
            friendsLabel.BackColor = Color.Transparent;
        }

        private void fetchProfilePicture()
        {
            try
            {
                if(m_LoggedInUser.PictureNormalURL != null)
                {
                    profilePicture.Load(m_LoggedInUser.PictureNormalURL);
                    profilePicture.Show();
                }
                else
                {
                    profilePicture.Hide();
                }
            }
            catch
            {
                profilePicture.Hide();
            }
        }

        private void fetchCoverPicture()
        {
            try
            {
                if (m_LoggedInUser.Albums != null)
                {
                    foreach (Album currentAlbum in m_LoggedInUser.Albums)
                    {
                        if (string.Compare(currentAlbum.Name,"תמונות נושא") == 0 || string.Compare(currentAlbum.Name, "Cover Photos") == 0)
                        {
                            coverPictureBox.Load(currentAlbum.Photos[0].PictureNormalURL);
                            coverPictureBox.Show();
                        }
                    }
                }
                else
                {
                   coverPictureBox.Hide();
                }
            }
            catch
            {
                 coverPictureBox.Hide();
            }
        }

        private void fetchWelcomeMessege()
        {
            StringBuilder dayTime = new StringBuilder();
            string welcomeMessege;

            try
            {
                DateTime now = DateTime.Now;
                if (now.Hour > 6 && now.Hour < 12)
                {
                    dayTime.Append("morning");
                }
                else if (now.Hour >= 12 && now.Hour < 18)
                {
                    dayTime.Append("afternoon");
                }
                else
                {
                    dayTime.Append("night");
                }

                welcomeMessege = string.Format("Hello {0}, Good {1} !", m_LoggedInUser.FirstName, dayTime);
            }
            catch
            {
                welcomeMessege = "Hello Welcome !";
            }

            this.WelcomeLabel.Text = welcomeMessege;
            this.WelcomeLabel.BackColor = Color.Transparent;
        }

        private void fetchPersonalInfoListBox()
        {
            userBindingSource.DataSource = m_LoggedInUser;           
        }

        private void fetchFriendsListBox()
        {            
            try
            {
                if (m_LoggedInUser.Friends != null)
                {
                    foreach (User currentFriend in m_LoggedInUser.Friends)
                    {
                        if (string.IsNullOrEmpty(currentFriend.FirstName) != true)
                        {
                            friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(currentFriend.FirstName)));            
                        }
                    }
            
                    friendsListBox.Invoke(new Action(() => friendsListBox.Show()));            
                }
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook friends information");
                friendsListBox.Invoke(new Action(() => friendsListBox.Hide()));            
            }
        }

        private void fetchPostsListBox()
        {
            try
            {
                if (m_LoggedInUser.Posts != null)
                {
                    foreach (Post currentPost in m_LoggedInUser.Posts)
                    {
                        if (string.IsNullOrEmpty(currentPost.Message) != true && this.postsListBox.Items.Count <= 10)
                        {
                            this.postsListBox.Invoke(new Action(() => this.postsListBox.Items.Add(currentPost.Message)));
                        }
                    }

                    this.postsListBox.Invoke(new Action(() => postsListBox.Show()));
                }
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook posts information");
                this.postsListBox.Invoke(new Action(() => this.postsListBox.Hide()));
            }
        }

        private void fetchCheckinsListBox()
        {
            try
            {
                if (m_LoggedInUser.Checkins != null)
                {
                    foreach (Checkin currentCheckin in m_LoggedInUser.Checkins)
                    {
                        if (string.IsNullOrEmpty(currentCheckin.Place.Name) != true && this.postsListBox.Items.Count <= 20)
                        {
                            checkinsListBox.Invoke(new Action(()=> checkinsListBox.Items.Add(currentCheckin.Place.Name)));
                        }
                    }

                    checkinsListBox.Invoke(new Action(() => this.checkinsListBox.Show()));
                }
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook checkins information");
                checkinsListBox.Invoke(new Action(() => this.checkinsListBox.Hide()));
                
            }
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            
        }

        private void personalInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void triviaWelcomeLable_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_LoggedInUser.Friends.Count > 0)
                {
                    startTriviaGame();
                }
                else
                {
                    MessageBox.Show("App didn't receive access to your Facebook friend information");
                }
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook friend information");
            }
        }

        private void startTriviaGame()
        {
            FormTriviaGame nextForm = new FormTriviaGame();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void startZodiacMatchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_LoggedInUser.Friends.Count > 0)
                {
                    startZodiacMatch();
                }
                else
                {
                    MessageBox.Show("App didn't receive access to your Facebook friend information");
                }
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook friend information");
            }

        }

        private void startZodiacMatch()
        {
            FormTheTwelveZodiac nextForm = new FormTheTwelveZodiac();
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void coverPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void findYourZodiacLable_Click(object sender, EventArgs e)
        {

        }

        private void pesonalInfoLable_Click(object sender, EventArgs e)
        {
            
        }

        private void checkinsLable_Click(object sender, EventArgs e)
        {
            this.checkinsListBox.Items.Clear();
            new Thread (fetchCheckinsListBox).Start();
        }

        private void friendsLabel_Click(object sender, EventArgs e)
        {
            this.friendsListBox.Items.Clear();
            new Thread(fetchFriendsListBox).Start();
        }

        private void lastPostsLable_Click(object sender, EventArgs e)
        {
            this.postsListBox.Items.Clear();
            new Thread (fetchPostsListBox).Start();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm nextForm = new LoginForm();
            this.Hide();
            AppLogic.SingletonLoggedInUser.Instance.Logout();
            nextForm.ShowDialog();
            this.Close();
        }

        private void homeTab_Click(object sender, EventArgs e)
        {

        }

        private void messageTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
     
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdayTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!isDate(birthdayTextBox.Text))
            {
                MessageBox.Show("The birthday must be in the folloing format (dd/mm/yyyy) ");                
                e.Cancel = true;
            }      
        }

        private void birthdayTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void birthdayTextBox_Validated(object sender, EventArgs e)
        {           
        }

        private bool isDate(string i_DateString)
        {
            bool isDateCorrect = i_DateString.Length == 10;

            if (isDateCorrect == true)
            {
                string dayToCheck = i_DateString.Substring(0, 2);
                string monthToCheck = i_DateString.Substring(3, 2);
                string yearToCheck = i_DateString.Substring(6, 4);
                int intDayToCheck = 0, intMonthToCheck = 0, intYearToCheck = 0;
                char firstSlashToChaeck = i_DateString[2], secoundSlashToChaeck = i_DateString[5];

                try
                {
                    intDayToCheck = int.Parse(dayToCheck);
                    intMonthToCheck = int.Parse(monthToCheck);
                    intYearToCheck = int.Parse(yearToCheck);
                }
                catch
                {
                    isDateCorrect = false;
                }

                isDateCorrect = isIntInRange(intDayToCheck, 31, 1) && isIntInRange(intMonthToCheck, 12, 1) && isIntInRange(intYearToCheck, 9999, 0)
                && firstSlashToChaeck.Equals('/') && secoundSlashToChaeck.Equals('/');
            }

            return isDateCorrect;
        }

        private bool isIntInRange(int i_NumToCheck, int i_LargestInRange, int i_SmallestInRange)
        {
            return i_NumToCheck <= i_LargestInRange && i_NumToCheck >= i_SmallestInRange;
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(emailTextBox.Text.Contains('@') == false)
            {
                MessageBox.Show("The email must contain @.");
                e.Cancel = true;
            }
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {
            ActiveLable activelable = this.WelcomeLabel as ActiveLable;
            activelable.Shake();
        }
    }
}
