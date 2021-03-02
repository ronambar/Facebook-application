using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using AppLogic;


namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    public partial class FormTriviaGame : Form
    {
        private LogicTriviaGame m_LogicTriviaGame = new LogicTriviaGame();
        public int m_NumOfQuestionToPlay { get; set; }
        public FormTriviaGame()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            m_NumOfQuestionToPlay = 5;
            loadTurn();
        }

        private void backToMainAppForm()
        {
            MainAppForm backForm = new MainAppForm();

            backForm.StartPosition = FormStartPosition.Manual;
            backForm.Location = this.Location;
            this.Hide();
            backForm.ShowDialog();
            this.Close();
        }

        private void loadTurn()
        {
            try
            {
                m_LogicTriviaGame.CreateTurn();
            }
            catch
            {
                MessageBox.Show("App didn't receive access to your Facebook friends information");
                backToMainAppForm();
            }

            try
            {
                this.AskedUserPicture.Load(m_LogicTriviaGame.m_CurrentAskedUser.PictureNormalURL);
                this.AskedUserPicture.Show();
            }
            catch
            {
                this.AskedUserPicture.Hide();
            }

            this.questionLabel.Text = m_LogicTriviaGame.QuestionList[(int)m_LogicTriviaGame.m_CurrentQuestionSubject];
            updateAnswersButtons();
            this.scoreLabel.Text = string.Format("Score: {0}", m_LogicTriviaGame.m_Score);
            this.questionNumberLabel.Text = string.Format("Question {0}", m_LogicTriviaGame.m_QuestionNumber);
        }

        private void finishTurn(int i_UserChoice)
        {
            int oldScore, newScore;

            oldScore = m_LogicTriviaGame.m_Score;
            m_LogicTriviaGame.FinishTurn(i_UserChoice);
            newScore = m_LogicTriviaGame.m_Score;

            if (IsAnswerCorrect(oldScore, newScore))
            {
                ActivePictureBox activePictureBox = this.AskedUserPicture as ActivePictureBox;
                activePictureBox.Shake();
            }

            if (m_LogicTriviaGame.m_QuestionNumber > m_NumOfQuestionToPlay)
            {
                fetchFinishForm();
            }
        }

        private bool IsAnswerCorrect(int i_OldScore, int i_NewScore)
        {
            return i_OldScore < i_NewScore;
        }

        private void fetchFinishForm()
        {
            Label finishLabel = new System.Windows.Forms.Label();

            finishLabel.Size = this.questionLabel.Size;
            finishLabel.Location = this.questionLabel.Location;
            finishLabel.Name = "finishLabel";
            finishLabel.Text = string.Format("You answered {0} questions correctly out of {1} ! ", this.m_LogicTriviaGame.m_Score, m_NumOfQuestionToPlay);
            finishLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            finishLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            finishLabel.Font = this.questionLabel.Font;
            finishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Button finishButton = new Button();

            finishButton.Size = this.answerFourButton.Size;
            finishButton.Location = this.answerFourButton.Location;
            finishButton.Name = "finishButton";
            finishButton.Text = "End game";
            finishButton.Font = this.answerFourButton.Font;
            finishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            finishButton.Click += new System.EventHandler(this.finishButton_Click);

            Button restartButton = new Button();

            restartButton.Size = this.answerTwoButton.Size;
            restartButton.Location = this.answerTwoButton.Location;
            restartButton.Name = "restartButton";
            restartButton.Text = "Try again";
            restartButton.Font = this.answerTwoButton.Font;
            finishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            restartButton.Click += new System.EventHandler(this.restartButton_Click);

            this.Controls.Clear();
            this.Controls.Add(finishButton);
            finishButton.Show();
            this.Controls.Add(restartButton);
            restartButton.Show();
            this.Controls.Add(finishLabel);
            finishLabel.Show();

        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            MainAppForm nextForm = new MainAppForm();

            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            FormTriviaGame nextForm = new FormTriviaGame();

            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void updateAnswersButtons()
        {
            for (int answerIndex = 0; answerIndex < m_LogicTriviaGame.CurrentAnswers.Capacity; answerIndex++)
            {
                switch (answerIndex)
                {
                    case 0:
                        {
                            this.answerOneButton.Text = m_LogicTriviaGame.CurrentAnswers[answerIndex];
                            break;
                        }
                    case 1:
                        {
                            this.answerTwoButton.Text = m_LogicTriviaGame.CurrentAnswers[answerIndex];
                            break;
                        }
                    case 2:
                        {
                            this.answerThreeButton.Text = m_LogicTriviaGame.CurrentAnswers[answerIndex];
                            break;
                        }
                    case 3:
                        {
                            this.answerFourButton.Text = m_LogicTriviaGame.CurrentAnswers[answerIndex];
                            break;
                        }
                }
            }
        }

        private void answerOneButton_Click(object sender, EventArgs e)
        {
            finishTurn(1);
            loadTurn();
        }

        private void answerTwoButton_Click(object sender, EventArgs e)
        {
            finishTurn(2);
            loadTurn();
        }

        private void answerThreeButton_Click(object sender, EventArgs e)
        {
            finishTurn(3);
            loadTurn();
        }

        private void answerFourButton_Click(object sender, EventArgs e)
        {
            finishTurn(4);
            loadTurn();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backToMainAppForm();
        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void formTriviaGame_Load(object sender, EventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
