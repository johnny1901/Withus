using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Withus
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        #region LoginForm Event
        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region UI Event 
        // UI EVENT FUCNTION START

        private void UserLogin_Button_Click(object sender, EventArgs e)
        {
            string userAccount = InputUserAccount_TextBox.Text;
            string userPassword = InputUserPassword_TextBox.Text;
            DBcontext DBC = new DBcontext();
            int loginResult = DBC.TryUserLogin(userAccount, userPassword);

            if (loginResult == 1)
            {
                MessageBox.Show("로그인 성공");
                MainForm mf = new MainForm();
                mf.Show();
                this.Close();
            }
            if (loginResult == 2)
            {
                MessageBox.Show("사용자 ID/PASSWORD를 확인 해주세요.");
            }
            if (loginResult == 3)
            {
                MessageBox.Show("서버 오류");
            }
        }

        // UI EVENT FUCNTION END
        #endregion

        #region Top Menu Event

        private void ProgramKill_ClickEvent(object sender, EventArgs e)
        {
            //Process.GetCurrentProcess().Close();
            Process.GetCurrentProcess().Kill();
        }
        private void HelpCenterView_ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("업데이트 예정");
        }
        private void FeedBack_ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("업데이트 예정");
        }

        #endregion

        #region TextBox Input Event Vaildations
        private void PasswordInputKeys_Event(object sender, KeyEventArgs e)
        {
            if (InputUserAccount_TextBox.Text == "")
            {
                MessageBox.Show("사용자 아이디를 입력 해주세요.");
                InputUserPassword_TextBox.Clear();
                InputUserAccount_TextBox.Focus();
            }
        }
        private void IDInputKeys_Event(object sender, EventArgs e)
        {
            string filter = @"[~!@\#$%^&*\()\=+|\\/:;?""<>' ]";
            Regex regex = new Regex(filter);

            if (regex.IsMatch(InputUserAccount_TextBox.Text) == true)
            {
                InputUserAccount_TextBox.Clear();
                MessageBox.Show("특수문자 또는 띄어쓰기는 불가능 합니다.");
            }
        }

        #endregion

        
    }
}
