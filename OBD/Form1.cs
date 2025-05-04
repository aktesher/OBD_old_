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
using System.Windows.Forms.DataVisualization.Charting;

namespace OBD
{
    public partial class Form1 : Form
    {
        MyDataBase dataBase = new MyDataBase();
        List<Label> labelCategory = new List<Label>();
        List<Label> labelMoney = new List<Label>();
        List<RadioButton> radio = new List<RadioButton>();
        int sizeRadioButton = 5;
        public Form1()
        {
            InitializeComponent();
            radio.AddRange(new RadioButton[] { radioCategory1, radioCategory2, radioCategory3, radioCategory4, radioCategory5, radioCategory6 });
            labelCategory.AddRange(new Label[] { category1, category2, category3, category4, category5 });
            for (int i = 0; i < sizeRadioButton; i++)
            {
                radio[i].Text = DataBank.Category[i].Name;
                labelCategory[i].Text = DataBank.Category[i].Name;
            }
            labelMoney.AddRange(new Label[] { money1, money2, money3, money4, money5 });

            dataBase.openConnection();
            string queryC6 = $"select isVisible from dbo.category where category_users = {DataBank.UserId} and category_id = {DataBank.Category[5].Id}";
            SqlCommand command = new SqlCommand(queryC6, dataBase.getConnection());
            bool c6 = bool.Parse(command.ExecuteScalar().ToString());
            if (c6)
            {
                category6.Visible = true;
                money6.Visible = true;
                radioCategory6.Visible = true;
                rC6.Visible = true;
                plusCategory.Visible = false;
                radioCategory6.Text = DataBank.Category[5].Name;
                category6.Text = DataBank.Category[5].Name;
            }
            dataBase.closeConnection();

            if (category6.Visible == true && sizeRadioButton <= 5)
            {
                labelMoney.Add(money6);
                labelCategory.Add(category6);
                radio.Add(radioCategory6);
                sizeRadioButton++;
            }

            
        }

        private void radioCategory6_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void radioCategory5_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void radioCategory4_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void radioCategory3_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void radioCategory2_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void radioCategory1_CheckedChanged(object sender, EventArgs e)
        {
            debit.Enabled = true;
        }

        private void debit_Click(object sender, EventArgs e)
        {
            if (category6.Visible == true && sizeRadioButton <= 5)
            {
                labelMoney.Add(money6);
                labelCategory.Add(category6);
                radio.Add(radioCategory6);
                sizeRadioButton++;
            }

            if ((int.Parse(spendingMoney.Text) + int.Parse(textBoxDebit.Text)) > int.Parse(profitMoney.Text))
            {
                MessageBox.Show("No money!");
                textBoxDebit.Clear();
                debit.Enabled = false;
            }
            else
            {
                for (int i = 0; i < sizeRadioButton; i++)
                {
                    if (radio[i].Checked == true)
                    {
                        dataBase.openConnection();
                        labelMoney[i].Text = (int.Parse(labelMoney[i].Text) + int.Parse(textBoxDebit.Text)).ToString();
                        spendingMoney.Text = (int.Parse(spendingMoney.Text) + int.Parse(textBoxDebit.Text)).ToString();

                        DataBank.Category[i].Money = int.Parse(labelMoney[i].Text);
                        DataBank.SpendingUser = spendingMoney.Text;
                        //SqlCommand queryId = new SqlCommand($"select id from dbo.users where user_name='{DataBank.NameUser}'", dataBase.getConnection());
                        //int id = int.Parse(queryId.ExecuteScalar().ToString());
                        string queryString = $"UPDATE dbo.category SET money = '{labelMoney[i].Text}' where category_users = {DataBank.UserId} and category_id = {DataBank.Category[i].Id}";
                        SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

                        command.ExecuteNonQuery();
                        dataBase.closeConnection();
                    }
                }
                string queryStringSpen = $"UPDATE dbo.users SET spending = '{spendingMoney.Text}' WHERE user_name = '{DataBank.NameUser}'";
                SqlCommand commandSpen = new SqlCommand(queryStringSpen, dataBase.getConnection());
                dataBase.openConnection();
                commandSpen.ExecuteNonQuery();
                dataBase.closeConnection();
                DrawChart(int.Parse(money1.Text), int.Parse(money2.Text), int.Parse(money3.Text), int.Parse(money4.Text), int.Parse(money5.Text), int.Parse(money6.Text));
                for (int i = 0; i < labelMoney.Count; i++)
                {
                    if (int.Parse(labelMoney[i].Text) > int.Parse(DataBank.SpendingUser) / 2)
                    {
                        messageMoney.Text = $"50%+ of expenses are spent on {labelCategory[i].Text}!!!";
                        messageMoney.Visible = true;
                        messageMoney.ForeColor = Color.Red;
                        messageMoney.Size = new Size(150, 20);
                        return;
                    }
                    else
                    {
                        messageMoney.Visible = false;
                    }
                }
                textBoxDebit.Clear();
                debit.Enabled = false;
            }            
        }

        private void proifitButton_Click(object sender, EventArgs e)
        {
            profitMoney.Text = (int.Parse(profitMoney.Text) + int.Parse(textBoxProfit.Text)).ToString();
            DataBank.ProfitUser = profitMoney.Text;
            string queryString = $"UPDATE dbo.users SET profit = '{profitMoney.Text}' WHERE user_name = '{DataBank.NameUser}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
            textBoxProfit.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thisName.Text = DataBank.NameUser;
            profitMoney.Text = DataBank.ProfitUser;
            spendingMoney.Text = DataBank.SpendingUser;
            money1.Text = DataBank.Category[0].Money.ToString();
            money2.Text = DataBank.Category[1].Money.ToString();
            money3.Text = DataBank.Category[2].Money.ToString();
            money4.Text = DataBank.Category[3].Money.ToString();
            money5.Text = DataBank.Category[4].Money.ToString();
            money6.Text = DataBank.Category[5].Money.ToString();
            DrawChart(int.Parse(money1.Text), int.Parse(money2.Text), int.Parse(money3.Text), int.Parse(money4.Text), int.Parse(money5.Text), int.Parse(money6.Text));
            for (int i = 0; i < labelMoney.Count; i++)
            {
                if (int.Parse(labelMoney[i].Text) > int.Parse(DataBank.SpendingUser) / 2)
                {
                    messageMoney.Text = $"50%+ of expenses are spent on {labelCategory[i].Text}!!!";
                    messageMoney.Visible = true;
                    messageMoney.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    messageMoney.Visible = false;
                }
            }
        }

        public void DrawChart(int value1, int value2, int value3, int value4, int value5, int value6)
        {
            stats.Series.Clear();
            stats.Legends.Clear();
            stats.Legends.Add("spend");
            stats.Legends[0].BackColor = Color.Purple;
            stats.Legends[0].LegendStyle = LegendStyle.Table;
            stats.Legends[0].Docking = Docking.Bottom;
            stats.Legends[0].Alignment = StringAlignment.Center;
            stats.Legends[0].Title = "Витрати";
            stats.Legends[0].BorderColor = Color.Black;
            stats.BackColor = Color.Purple;

            string seriesname = "Spending";
            stats.Series.Add(seriesname);
            stats.Series[seriesname].ChartType = SeriesChartType.Pie;
            
            //stats.Series[seriesname]. = Color.Purple;
            stats.Series[seriesname].Points.AddXY(category1.Text, value1);
            stats.Series[seriesname].Points.AddXY(category2.Text, value2);
            stats.Series[seriesname].Points.AddXY(category3.Text, value3);
            stats.Series[seriesname].Points.AddXY(category4.Text, value4);
            stats.Series[seriesname].Points.AddXY(category5.Text, value5);
            stats.Series[seriesname].Points.AddXY(category6.Text, value6);
            foreach (var point in stats.Series[seriesname].Points)
            {
                point.SetCustomProperty("PieLabelStyle", "Disabled");
            }      
        }

        private void plusCategory_Click(object sender, EventArgs e)
        {
            string queryC6 = $"update dbo.category SET isVisible = 1 where category_users = {DataBank.UserId} and category_id = {DataBank.Category[5].Id}";
            SqlCommand command = new SqlCommand(queryC6, dataBase.getConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();

            category6.Visible = true;
            money6.Visible = true;
            radioCategory6.Visible = true;
            rC6.Visible = true;
            plusCategory.Visible = false;
        }

        private void rC1_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(0);
            frm.Show();
            this.Hide();
        }

        private void rC5_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(4);
            frm.Show();
            this.Hide();
        }

        private void rC6_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(5);
            frm.Show();
            this.Hide();
        }

        private void rC4_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(3);
            frm.Show();
            this.Hide();
        }

        private void rC3_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(2);
            frm.Show();
            this.Hide();
        }

        private void rC2_Click(object sender, EventArgs e)
        {
            removeCategory frm = new removeCategory(1);
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxProfit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProfit.Text.Length > 0)
            {
                proifitButton.Enabled = true;
            }
            else
            {
                proifitButton.Enabled = false;
            }
        }

        private void textBoxDebit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDebit.Text.Length > 0)
            {
                debit.Enabled = true;
            }
            else
            {
                debit.Enabled = false;
            }
        }
    }
}
