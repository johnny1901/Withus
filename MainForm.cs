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
    public partial class MainForm : Form
    {
        private static string connectionString = "Server=192.168.219.100;Database=Withus;User ID=user;Password=a123123a";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        DataTable dataTable;

        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;        

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void LoadPage()
        {
            int i;
            int startRec;
            int endRec;
            DataTable dtTemp;
            //Clone the source table to create a temporary table.
            dtTemp = dataTable.Clone();
            if (currentPage == PageCount)
            {
                endRec = maxRec;
            }
            else
            {
                endRec = pageSize * currentPage;
            }
            startRec = recNo;
            //Copy rows from the source table to fill the temporary table.
            for (i = startRec; i < endRec; i++)
            {
                dtTemp.ImportRow(dataTable.Rows[i]);
                recNo += 1;
            }
            dataGridView1.DataSource = dtTemp;            
            DisplayPageInfo();
        }
        private void DisplayPageInfo()
        {
            PageState_Label.Text = currentPage.ToString() + "/ " + PageCount.ToString();
        }
        private bool CheckFillButton()
        {
            if (pageSize == 0)
            {
                MessageBox.Show("Row값을 입력하세요.");
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Button Click Event
        private void TableLookUpButton_ClickEvent(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Users";
            dataAdapter = new SqlDataAdapter(query, connectionString);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "PK");
            dataTable = dataSet.Tables["PK"];

            pageSize = Convert.ToInt32(InputRowCount_TextBox.Text);
            maxRec = dataTable.Rows.Count;
            PageCount = maxRec / pageSize;

            if ((maxRec % pageSize) > 0)
            {
                PageCount += 1;
            }

            currentPage = 1;
            recNo = 0;
            LoadPage();
        }
        private void FirstPageButton_ClickEvent(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }
            if (currentPage == 1)
            {
                MessageBox.Show("첫 페이지 입니다.");
                return;
            }
            currentPage = 1;
            recNo = 0;
            LoadPage();
        }
        private void PrePageButton_ClickEvent(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }
            if (currentPage == PageCount)
            {
                recNo = pageSize * (currentPage - 2);
            }
            currentPage -= 1;
            if (currentPage < 1)
            {
                MessageBox.Show("첫 페이지 입니다.");
                currentPage = 1;
                return;
            }
            else
            {
                recNo = pageSize * (currentPage - 1);
            }
            LoadPage();
        }
        private void NextPageButton_ClickEvent(object sender, EventArgs e)
        {
            //If the user did not click the "Fill Grid" button, then return.
            if (CheckFillButton() == false)
            {
                return;
            }
            //Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("ROW값을 입력 하세요.");
                return;
            }
            currentPage += 1;
            if (currentPage > PageCount)
            {
                currentPage = PageCount;
                if (recNo == maxRec)
                {
                    MessageBox.Show("마지막 페이지 입니다.");
                    return;
                }
            }
            LoadPage();
        }
        private void LastPageButton_ClickEvent(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }
            //Check if you are already at the last page.
            if (recNo == maxRec)
            {
                MessageBox.Show("마지막 페이지 입니다.");
                return;
            }
            currentPage = PageCount;
            recNo = pageSize * (currentPage - 1);
            LoadPage();
        }
        #endregion
    }
}
