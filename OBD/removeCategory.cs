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
    public partial class removeCategory : Form
    {
        Category category;
        MyDataBase dataBase = new MyDataBase();
        public removeCategory(int index)
        {
            InitializeComponent();
            category = DataBank.Category[index];
            labelRemove.Text = category.Name;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            category.Name = textBoxRemove.Text;
            string queryString = $"UPDATE dbo.category SET category_name = '{category.Name}' WHERE category_users = {DataBank.UserId} and category_id = {category.Id}";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void removeCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
