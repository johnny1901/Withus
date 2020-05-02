using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        bool loginPass = false;

        private static string connectionString = "Server=192.168.219.100;Database=Withus;User ID=user;Password=a123123a";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }        
        private int UserLoginConnection(string account, string password)
        {
            command.Parameters.Clear();
            string query = $"SELECT UserAccount, UserPassword FROM Users " +
                $"WHERE UserAccount=@P1 AND UserPassword=@P2";

            command.Parameters.Add("@P1", SqlDbType.VarChar, 50).Value = account;
            command.Parameters.Add("@P2", SqlDbType.VarChar, 50).Value = password;

            command.Connection = connection;
            command.CommandText = query;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (account == reader.GetString(0) && password == reader.GetString(1))
                        {
                            connection.Close();
                            return 1;
                        }
                    }
                }
                connection.Close();
                return 2;
            }
            catch
            {
                connection.Close();
                return 3;
            }
        }

        #region LoginForm Event
        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (loginPass == false)
            {
                Process.GetCurrentProcess().Kill();
            }
        }
        #endregion

        #region UI Event 
        // UI EVENT FUCNTION START
                
        private void UserLogin_Button_Click(object sender, EventArgs e)
        {

            if (InputUserPassword_TextBox.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요.");
            }
            if (InputUserPassword_TextBox.Text != "")
            {
                string userAccount = InputUserAccount_TextBox.Text;
                string userPassword = InputUserPassword_TextBox.Text;
                int result = UserLoginConnection(userAccount, userPassword);

                switch (result)
                {
                    case 1:
                            MessageBox.Show("로그인 성공");
                            loginPass = true;
                            MainForm mf = new MainForm();
                            mf.Show();
                            this.Close();
                            break;
                    case 2:
                            MessageBox.Show("로그인 실패");
                            break;
                    case 3:
                            MessageBox.Show("서버 오류");
                            break;
                }                
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
