using System;
using C20_Ex01_Ron_204464127_Tomer_312500937;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using AppLogic;
using SingletonT;


namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void OpeningForm_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            MainAppForm nextForm = new MainAppForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
