using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OBD
{
    public partial class LogIn : Form
    {
        MyDataBase dataBase = new MyDataBase();
        public LogIn()
        {
            InitializeComponent();
    }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string loginUser = LogInBox.Text;
            string passwordUser = passwordLIBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id, user_name, password from dbo.users where user_name='{loginUser}' and password='{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                dataBase.openConnection();
                
                DataBank.NameUser = loginUser;
                SqlCommand queryId = new SqlCommand($"select id from dbo.users where user_name='{loginUser}'", dataBase.getConnection());
                int id = int.Parse(queryId.ExecuteScalar().ToString());
                DataBank.UserId = id;

                SqlCommand commandProfit = new SqlCommand($"select profit from dbo.users where user_name='{loginUser}'", dataBase.getConnection());
                SqlCommand commandSpending = new SqlCommand($"select spending from dbo.users where user_name='{loginUser}'", dataBase.getConnection());
                DataBank.ProfitUser = commandProfit.ExecuteScalar().ToString();
                DataBank.SpendingUser = commandSpending.ExecuteScalar().ToString();

                //SqlCommand commandCategory = new SqlCommand($"select * from dbo.category where category_users={DataBank.UserId};", dataBase.getConnection());
                string query = "SELECT * FROM category WHERE category_users = @UserId";
                using (SqlConnection connection = dataBase.getConnection()) 
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", DataBank.UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                int categoryId = reader.GetInt32(reader.GetOrdinal("category_id"));
                                string categoryName = reader.GetString(reader.GetOrdinal("category_name"));
                                int categoryValue = reader.GetInt32(reader.GetOrdinal("money"));
                                bool categoryVisible = reader.GetBoolean(reader.GetOrdinal("isVisible"));
                                DataBank.Category[i].Id = categoryId;
                                DataBank.Category[i].Name = categoryName;
                                DataBank.Category[i].Money = categoryValue;
                                DataBank.Category[i].IsVisible = categoryVisible;
                                //MessageBox.Show($"Category ID: {categoryId}, Name: {categoryName}, Value: {categoryValue}");
                                i++;
                            }
                        }
                    }
                }
                //SqlCommand commandCategory6 = new SqlCommand($"select category6 from dbo.category where userName='{loginUser}'", dataBase.getConnection());


                MessageBox.Show("Successfully");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("this account is not registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordLIBox.Clear();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            passwordLIBox.PasswordChar = '*';
        }

        private void linkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp frm = new SingUp();
            frm.Show();
            this.Hide();
        }
    }
}
