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
    public partial class EditForm : Form
    {
        string pk = string.Empty;

        private static string connectionString = "Server=192.168.219.100;Database=Withus;User ID=user;Password=a123123a";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();

        MainForm mf;

        public EditForm(string selectPK, MainForm mainform)
        {
            InitializeComponent();
            mf = mainform;
            pk = selectPK;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            EditTarget_Label.Text = pk;
            command.Parameters.Clear();
            string query = $"SELECT * FROM Users WHERE PK=@P1";
            command.Parameters.Add("@P1", SqlDbType.Int).Value = pk;

            command.Connection = connection;
            command.CommandText = query;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (pk == reader[0].ToString())
                    {
                        UserAccount_TextBox.Text = reader[1].ToString();
                        UserPassword_TextBox.Text = reader[2].ToString();
                        UserName_TextBox.Text = reader[3].ToString();
                        UserPhone_TextBox.Text = reader[4].ToString();
                        UserEmail_TextBox.Text = reader[5].ToString();
                    }
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCommit_Button_Click(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            string query = $"UPDATE dbo.Users SET UserAccount=@P1, UserPassword=@P2, UserName=@P3, UserPhone=@P4, UserEmail=@p5 WHERE PK={pk}";
            command.Parameters.Add("@P1", SqlDbType.VarChar, 50).Value = UserAccount_TextBox.Text;
            command.Parameters.Add("@P2", SqlDbType.VarChar, 50).Value = UserPassword_TextBox.Text;
            command.Parameters.Add("@P3", SqlDbType.VarChar, 50).Value = UserName_TextBox.Text;
            command.Parameters.Add("@P4", SqlDbType.VarChar, 50).Value = UserPhone_TextBox.Text;
            command.Parameters.Add("@P5", SqlDbType.VarChar, 50).Value = UserEmail_TextBox.Text;

            command.Connection = connection;
            command.CommandText = query;

            connection.Open();
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                mf.ResultView(pk);
                this.Close();
            }
            else
            {
                MessageBox.Show("오류");
            }
        }

        private void DeleteCommit_Button_Click(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            string query = "DELETE FROM dbo.Users WHERE PK=@P1";
            command.Parameters.Add("@P1", SqlDbType.Int).Value = pk;

            command.Connection = connection;
            command.CommandText = query;

            connection.Open();
            int deleteResult = command.ExecuteNonQuery();
            
            if (deleteResult == 1)
            {
                mf.DeleteView();
                this.Close();
            }
            else
            {
                MessageBox.Show("오류");
            }
        }
    }
}
