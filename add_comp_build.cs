using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class add_comp_build : Form
    {
        public add_comp_build()
        {
            InitializeComponent();
        }
        string[] id = new string[20];
        string[] name = new string[20];
        string[] id2 = new string[20];
        string[] name2 = new string[20];
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_comp_build_Load_1(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = $"SELECT* from components";
            string sql2 = $"SELECT* from build";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                id[x] += reader[0].ToString();
                name[x] += reader[1].ToString();
                x++;
            }
            reader.Close();
            comboBox1.DataSource = name;
            MySqlCommand command2 = new MySqlCommand(sql2, conn);
            MySqlDataReader reader2 = command2.ExecuteReader();
            int y = 0;
            while (reader2.Read())
            {
                id2[y] += reader2[0].ToString();
                name2[y] += reader2[1].ToString();
                y++;
            }
            reader2.Close();
            conn.Close();
            comboBox2.DataSource = name2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            string sql = $"insert into `components-build` (components_id,build_id, quantity) values ('{id[comboBox1.SelectedIndex]}','{id2[comboBox2.SelectedIndex]}', {textBox1.Text})";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show(sql, "ok");
        }
    }
}
