using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Withus
{
    public partial class AddForm : Form
    {
        private static string connectionString = "Server=192.168.219.100;Database=Withus;User ID=user;Password=a123123a";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();

        public AddForm()
        {
            InitializeComponent();
        }        

        private void Create_ClickEvent(object sender, EventArgs e)
        {
            if (UserAccount_TextBox.Text != "" && UserPassword_TextBox.Text != "" && UserName_TextBox.Text != "" && UserPhone_TextBox.Text != "" && UserEmail_TextBox.Text != "")
            {
                command.Parameters.Clear();
                string query = "INSERT INTO dbo.Users (UserAccount, UserPassword, UserName, UserPhone, UserEmail) VALUES(@P1,@P2,@P3,@P4,@P5)";
                command.Parameters.Add("@P1", SqlDbType.VarChar, 50).Value = UserAccount_TextBox.Text;
                command.Parameters.Add("@P2", SqlDbType.VarChar, 50).Value = UserPassword_TextBox.Text;
                command.Parameters.Add("@P3", SqlDbType.VarChar, 50).Value = UserName_TextBox.Text;
                command.Parameters.Add("@P4", SqlDbType.VarChar, 50).Value = UserPhone_TextBox.Text;
                command.Parameters.Add("@P5", SqlDbType.VarChar, 50).Value = UserEmail_TextBox.Text;
                command.CommandText = query;

                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("입력 오류");
            }
        }

        private void InputKeyDown_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {                
                MessageBox.Show("입력 불가능한 키 입니다.");
                UserAccount_TextBox.Clear();
                UserPassword_TextBox.Clear();
                UserName_TextBox.Clear();
                UserPhone_TextBox.Clear();
                UserEmail_TextBox.Clear();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

    }
}
