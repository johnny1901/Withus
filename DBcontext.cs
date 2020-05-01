using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Withus
{
    class DBcontext
    {
        private static string connectionString = "Server=192.168.219.100;Database=Withus;User ID=user;Password=a123123a";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();

        public int InsertUserData()
        {   //테스트 목적 코드
            string query = "INSERT INTO USERS (UserAccount,UserPassword,UserName,UserPhone,UserEmail) VALUES('admin','a123123a','호','010-1234-1004','admin@admin.com')";
            command.Connection = connection;
            command.CommandText = query;

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show($"{result}개의 정보가 등록 되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 55;
        }

        public int TryUserLogin(string userAccount, string userPassword)
        {
            string query = $"SELECT UserAccount, UserPassword FROM Users " +
                $"WHERE UserAccount=@P1 AND UserPassword=@P2";
                        
            command.Parameters.Add("@P1", SqlDbType.VarChar, 50).Value = userAccount;
            command.Parameters.Add("@P2", SqlDbType.VarChar, 50).Value = userPassword;

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
                        if (userAccount == reader.GetString(0) && userPassword == reader.GetString(1))
                        {                            
                            //MessageBox.Show($"{userAccount} == {reader.GetString(0)}\r\n{userPassword} == {reader.GetString(1)}");
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
    }
}
