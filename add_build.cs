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
    public partial class add_build : Form
    {
        public add_build()
        {
            InitializeComponent();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            string sql = $"insert into `build` (name,`build type`) values('{textBox1.Text}', '{textBox2.Text}')";
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
