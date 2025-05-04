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

namespace OBD
{
    public partial class SingUp : Form
    {
        MyDataBase dataBase = new MyDataBase();
        public SingUp()
        {
            InitializeComponent();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {
            passwordSUBox.PasswordChar = '*';
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string loginUser = singUpBox.Text;
            string passwordUser = passwordSUBox.Text;

            dataBase.openConnection();
            string queryUsers = $"insert into dbo.users(user_name, password, profit, spending) values('{loginUser}', '{passwordUser}',{0},{0})";

            SqlCommand commandUsers = new SqlCommand(queryUsers, dataBase.getConnection());

            
            if (checkUser() == false) 
            {
                if (commandUsers.ExecuteNonQuery() == 1)
                {
                    DataBank.NameUser = loginUser;

                    SqlCommand queryId = new SqlCommand($"select id from dbo.users where user_name='{loginUser}'", dataBase.getConnection());
                    string id = queryId.ExecuteScalar().ToString();
                    for (int i = 0; i < 6; i++)
                    {
                        bool bebra = i != 5;
                        string queryCategory = $"insert into dbo.category(category_users, category_name, money, isVisible) values({int.Parse(id)}, '{"category" + (i + 1).ToString()}', {0}, '{bebra}')";
                        SqlCommand commandCategory = new SqlCommand(queryCategory, dataBase.getConnection());
                        if(commandCategory.ExecuteNonQuery()==1);
                    }
                    MessageBox.Show("Account is created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogIn frm = new LogIn();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataBase.closeConnection();
            }
        }

        private bool checkUser() 
        {
            string loginUser = singUpBox.Text;
            string passwordUser = passwordSUBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id, user_name, password from dbo.users where user_name='{loginUser}' and password='{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("The user is already registered");
                passwordSUBox.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SingUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
