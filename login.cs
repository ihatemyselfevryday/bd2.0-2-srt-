using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForms
{
    public partial class login : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            string sql = "SELECT * FROM `users` WHERE `name` = @un and `pass`= @up";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
            command.Parameters["@un"].Value = textBox1.Text;
            command.Parameters["@up"].Value = textBox2.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Logged in as admin");
                userRole();
            }
            else
            {
                MessageBox.Show("Logged in as guest");
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            conn.Close();
        }
        private void userRole()
        {
            string UserName = textBox1.Text;
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            string sql = "SELECT role FROM `users` WHERE `name` = @un";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlParameter nameParam = new MySqlParameter("@un", UserName);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(nameParam);
            string Form_Role = command.ExecuteScalar().ToString();
            switch (Form_Role)
            {
                case "admin":
                    Form1 Form1 = new Form1();
                    Form1.Show();
                    break;
            }
            conn.Close();
        }
    }
}
