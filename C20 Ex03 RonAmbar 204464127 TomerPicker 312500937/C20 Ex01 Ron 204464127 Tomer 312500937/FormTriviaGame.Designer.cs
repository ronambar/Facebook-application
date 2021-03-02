namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    partial class FormTriviaGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTriviaGame));
            this.AskedUserPicture = new ActivePictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerOneButton = new System.Windows.Forms.Button();
            this.answerTwoButton = new System.Windows.Forms.Button();
            this.answerFourButton = new System.Windows.Forms.Button();
            this.answerThreeButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AskedUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AskedUserPicture
            // 
            this.AskedUserPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AskedUserPicture.Location = new System.Drawing.Point(324, 18);
            this.AskedUserPicture.Margin = new System.Windows.Forms.Padding(4);
            this.AskedUserPicture.Name = "AskedUserPicture";
            this.AskedUserPicture.Size = new System.Drawing.Size(196, 186);
            this.AskedUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AskedUserPicture.TabIndex = 1;
            this.AskedUserPicture.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.questionLabel.Location = new System.Drawing.Point(225, 224);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(407, 50);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // answerOneButton
            // 
            this.answerOneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerOneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.answerOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answerOneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.answerOneButton.Location = new System.Drawing.Point(48, 303);
            this.answerOneButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerOneButton.Name = "answerOneButton";
            this.answerOneButton.Size = new System.Drawing.Size(333, 72);
            this.answerOneButton.TabIndex = 4;
            this.answerOneButton.Text = "Answer 1";
            this.answerOneButton.UseVisualStyleBackColor = true;
            this.answerOneButton.Click += new System.EventHandler(this.answerOneButton_Click);
            // 
            // answerTwoButton
            // 
            this.answerTwoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerTwoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.answerTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answerTwoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.answerTwoButton.Location = new System.Drawing.Point(48, 397);
            this.answerTwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerTwoButton.Name = "answerTwoButton";
            this.answerTwoButton.Size = new System.Drawing.Size(333, 72);
            this.answerTwoButton.TabIndex = 5;
            this.answerTwoButton.Text = "Answer 2";
            this.answerTwoButton.UseVisualStyleBackColor = true;
            this.answerTwoButton.Click += new System.EventHandler(this.answerTwoButton_Click);
            // 
            // answerFourButton
            // 
            this.answerFourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerFourButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.answerFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answerFourButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.answerFourButton.Location = new System.Drawing.Point(452, 397);
            this.answerFourButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerFourButton.Name = "answerFourButton";
            this.answerFourButton.Size = new System.Drawing.Size(333, 72);
            this.answerFourButton.TabIndex = 7;
            this.answerFourButton.Text = "Answer 4";
            this.answerFourButton.UseVisualStyleBackColor = true;
            this.answerFourButton.Click += new System.EventHandler(this.answerFourButton_Click);
            // 
            // answerThreeButton
            // 
            this.answerThreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerThreeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.answerThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answerThreeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.answerThreeButton.Location = new System.Drawing.Point(452, 303);
            this.answerThreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerThreeButton.Name = "answerThreeButton";
            this.answerThreeButton.Size = new System.Drawing.Size(333, 72);
            this.answerThreeButton.TabIndex = 6;
            this.answerThreeButton.Text = "Answer 3";
            this.answerThreeButton.UseVisualStyleBackColor = true;
            this.answerThreeButton.Click += new System.EventHandler(this.answerThreeButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.questionNumberLabel.Location = new System.Drawing.Point(99, 100);
            this.questionNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(182, 38);
            this.questionNumberLabel.TabIndex = 8;
            this.questionNumberLabel.Text = "Question X";
            this.questionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionNumberLabel.Click += new System.EventHandler(this.questionNumberLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.scoreLabel.Location = new System.Drawing.Point(568, 100);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(214, 38);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "Score : X";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Turquoise;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(18, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(180, 34);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "back To Home Page";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormTriviaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::C20_Ex01_Ron_204464127_Tomer_312500937.Properties.Resources.TriviaGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 514);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.answerFourButton);
            this.Controls.Add(this.answerThreeButton);
            this.Controls.Add(this.answerTwoButton);
            this.Controls.Add(this.answerOneButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.AskedUserPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTriviaGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trivia Game";
            this.Load += new System.EventHandler(this.formTriviaGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AskedUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AskedUserPicture;

        private System.Windows.Forms.Label questionLabel;

        private System.Windows.Forms.Button answerOneButton;

        private System.Windows.Forms.Button answerTwoButton;

        private System.Windows.Forms.Button answerFourButton;

        private System.Windows.Forms.Button answerThreeButton;

        private System.Windows.Forms.Label questionNumberLabel;

        private System.Windows.Forms.Label scoreLabel;

        private System.Windows.Forms.Button backButton;
    }
}