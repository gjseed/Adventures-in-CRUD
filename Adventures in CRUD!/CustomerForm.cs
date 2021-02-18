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

namespace Adventures_in_CRUD_
{
    public partial class CustomerForm : Form
    {
        SqlCommand cmd;

        SqlDataAdapter adapter = new SqlDataAdapter();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand("showCust", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Grid.DataSource = dt;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.SelectCommand = cmd;
            adapter.UpdateCommand = builder.GetUpdateCommand();
            string emptyStr = string.Empty;
            var custID = Grid.SelectedRows[0].Cells[0].Value;
            var addID = Grid.SelectedRows[0].Cells[12].Value;
            var currect = Grid.SelectedRows;
            FNameBox.Text = currect[0].Cells[1].Value.ToString();
            MNameBox.Text = currect[0].Cells[2].Value.ToString();
            LNameBox.Text = currect[0].Cells[3].Value.ToString();
            CName.Text = currect[0].Cells[4].Value.ToString();
            EAddress.Text = currect[0].Cells[5].Value.ToString();
            AddT.Text = currect[0].Cells[6].Value.ToString();
            AddLine1.Text = currect[0].Cells[7].Value.ToString();
            AddLine2.Text = currect[0].Cells[8].Value.ToString();
            cityBox.Text = currect[0].Cells[9].Value.ToString();
            StBox.Text = currect[0].Cells[10].Value.ToString();
            PcBox.Text = currect[0].Cells[11].Value.ToString();
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand("UpdateCust", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@firstName", FNameBox);
                cmd.Parameters.AddWithValue("@middleName", MNameBox);
                cmd.Parameters.AddWithValue("@lastName", LNameBox);
                cmd.Parameters.AddWithValue("@companyName", CName);
                cmd.Parameters.AddWithValue("@emailAddress", EAddress);
                cmd.Parameters.AddWithValue("@AddressT", AddT);
                cmd.Parameters.AddWithValue("@AddL1", AddLine1);
                cmd.Parameters.AddWithValue("@AddL2", AddLine2);
                cmd.Parameters.AddWithValue("@City", cityBox);
                cmd.Parameters.AddWithValue("State", StBox);
                cmd.Parameters.AddWithValue("PostalC", PcBox);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            
        }

        private void LoadProd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand("showProd", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Grid.DataSource = dt;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                DataTable dtData = new DataTable();
                SqlCommand cmd = new SqlCommand("deleteCust", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@CustomerID", CustumerID);
            }
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.SelectCommand = cmd;
            adapter.UpdateCommand = builder.GetUpdateCommand();
            string emptyStr = string.Empty;
            var custID = Grid.SelectedRows[0].Cells[0].Value;
            var addID = Grid.SelectedRows[0].Cells[12].Value;
            var currect = Grid.SelectedRows;
            FNameBox.Text = currect[0].Cells[1].Value.ToString();
            MNameBox.Text = currect[0].Cells[2].Value.ToString();
            LNameBox.Text = currect[0].Cells[3].Value.ToString();
            CName.Text = currect[0].Cells[4].Value.ToString();
            EAddress.Text = currect[0].Cells[5].Value.ToString();
            AddT.Text = currect[0].Cells[6].Value.ToString();
            AddLine1.Text = currect[0].Cells[7].Value.ToString();
            AddLine2.Text = currect[0].Cells[8].Value.ToString();
            cityBox.Text = currect[0].Cells[9].Value.ToString();
            StBox.Text = currect[0].Cells[10].Value.ToString();
            PcBox.Text = currect[0].Cells[11].Value.ToString();
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand("UpdateCust", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@firstName", FNameBox);
                cmd.Parameters.AddWithValue("@middleName", MNameBox);
                cmd.Parameters.AddWithValue("@lastName", LNameBox);
                cmd.Parameters.AddWithValue("@companyName", CName);
                cmd.Parameters.AddWithValue("@emailAddress", EAddress);
                cmd.Parameters.AddWithValue("@AddressT", AddT);
                cmd.Parameters.AddWithValue("@AddL1", AddLine1);
                cmd.Parameters.AddWithValue("@AddL2", AddLine2);
                cmd.Parameters.AddWithValue("@City", cityBox);
                cmd.Parameters.AddWithValue("State", StBox);
                cmd.Parameters.AddWithValue("PostalC", PcBox);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
