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
                MessageBox.Show("수정 작업 후 결과 화면 입니다.\r\n 다시 조회 해주세요.");
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Button Click Event
        public void TableLookUpButton_ClickEvent(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            if (InputRowCount_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Row 값을 입력 해주세요.");
                return;
            }
        
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
            if (CheckFillButton() == false)
            {
                return;
            }
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

        private void CellContent_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectPK = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            
            EditForm ef = new EditForm(selectPK, this);
            ef.Show();
        }

        //수정 후 리플레쉬 용도
        public int ResultView(string resultPK)
        {            
            string query = $"SELECT * FROM dbo.Users WHERE PK={resultPK}";
            dataAdapter = new SqlDataAdapter(query, connectionString);
            dataSet = new DataSet();
            try
            {
                label1.Visible = true;
                label2.Visible = true;
                PageState_Label.Text = "1/1";
                maxRec = 0;
                pageSize = 0;
                currentPage = 0;
                recNo = 0;
                dataAdapter.Fill(dataSet, "PK");
                dataTable = dataSet.Tables["PK"];
                dataGridView1.DataSource = dataTable;
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
        }
        
        public void DeleteView()
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

        private void DataAddMenu_ClickEvent(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Show();
        }
    }
}
