using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        private void comSql(string sql)
        {
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
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
        }
        private async void adapterSql(string sql)
        {
            try
            {
                string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
                MySqlConnection conn = new MySqlConnection(connStr);
                mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
                int rowsGot =-1;
                DataSet DS = new DataSet();
                rowsGot = await mySqlDataAdapter.FillAsync(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        string[] a = new string[20];
        string[] b = new string[20];
        private void Button2_Click(object sender, EventArgs e)//show
        {
            string sql = "";
            switch (listBox1.Text)
            {
                case "component type":
                    sql = "select * from `component type`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    break;//отдыхаем)
                case "components":
                    sql = "select `components`.*,`manufacturer`.`name`,`component type`.`name` from `components` " +
                        "inner join `manufacturer` on `components`.`manufacturer_id` = `manufacturer`.`id`" +
                        "inner join `component type` on `components`.`component type_id` = `component type`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[5].Visible = false; dataGridView1.Columns[6].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    a[1] = dataGridView1.Columns[2].HeaderText;
                    a[2] = dataGridView1.Columns[3].HeaderText;
                    a[3] = dataGridView1.Columns[4].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    b[1] = dataGridView1.Columns[2].HeaderText;
                    b[2] = dataGridView1.Columns[3].HeaderText;
                    b[3] = dataGridView1.Columns[4].HeaderText;
                    break;
                case "components-build":
                    sql = "select `components-build`.*,`components`.`name`,`build`.`name` from `components-build` " +
                        "inner join `components` on `components-build`.`components_id` = `components`.`id`" +
                        "inner join `build` on `components-build`.`build_id` = `build`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[2].Visible = false; dataGridView1.Columns[3].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    break;
                case "manufacturer":
                    sql = "select * from `manufacturer`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    break;
                case "order":
                    sql = "select `order`.*,`customer`.`name`,`customer`.`surname`,`build`.`name` from `order` " +
                        "inner join `customer` on `order`.`customer_id` = `customer`.`id`" +
                        "inner join `build` on `order`.`build_id` = `build`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[3].Visible = false; dataGridView1.Columns[4].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    a[1] = dataGridView1.Columns[2].HeaderText;
                    a[2] = dataGridView1.Columns[3].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    b[1] = dataGridView1.Columns[2].HeaderText;
                    b[2] = dataGridView1.Columns[3].HeaderText;
                    break;
                case "customer":
                    sql = "select * from `customer`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    break;
                case "build":
                    sql = "select * from `build`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    a[0] = dataGridView1.Columns[1].HeaderText;
                    b[0] = dataGridView1.Columns[1].HeaderText;
                    break;
            }
            comboBox1.DataSource = a;
            comboBox5.DataSource = b;

        }
        private MySqlDataAdapter mySqlDataAdapter;
        private void button1_Click(object sender, EventArgs e)//delete
        {
            string sql = $"delete from `{listBox1.SelectedItem}` where `id` = {dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()}";
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(sql);
        }
        private void button3_Click(object sender, EventArgs e)//add
        {
            add add_Form = new add();
            add_Form.Show();
        }
        private void button4_Click(object sender, EventArgs e)//sorting
        {
            if (comboBox1.Text == comboBox5.Text)
            {
                MessageBox.Show("choose different columns for sorting");
                return;
            }
            string sql = $"select * from `{listBox1.SelectedItem}` order by `{comboBox1.SelectedItem}` {comboBox2.SelectedItem}, `{comboBox5.SelectedItem}` {comboBox6.SelectedItem}";
            MessageBox.Show(sql);//мал.окошко
            adapterSql(sql);
        }
        private void button5_Click(object sender, EventArgs e)//search
        {
            string sql = "";
            switch (listBox1.Text)
            {
                case "component type":
                    sql = $"select * from `{listBox1.SelectedItem}` where `name` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "components":
                    sql = "select `components`.*,`manufacturer`.`name`,`component type`.`name` from `components`  " +
                        "inner join `manufacturer` on `components`.`manufacturer_id` = `manufacturer`.`id`" +
                        "inner join `component type` on `components`.`component type_id` = `component type`.`id`" +
                        $"where `specifications` like '%{textBox1.Text}%' or `price` like '%{textBox1.Text}%' or `quantity in stock` like '%{textBox1.Text}%' or `component type`.`name` like '%{textBox1.Text}%' or `manufacturer`.`name` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[5].Visible = false; dataGridView1.Columns[6].Visible = false;
                    break;
                case "components-build":
                    sql = "select `components-build`.*,`components`.`name`,`build`.`name` from `components-build` " +
                        "inner join `components` on `components-build`.`components_id` = `components`.`id`" +
                        "inner join `build` on `components-build`.`build_id` = `build`.`id`" +
                        $"where `quantity` like '%{textBox1.Text}%' or `components`.`name` like '%{textBox1.Text}%' or `build`.`name` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[2].Visible = false; dataGridView1.Columns[3].Visible = false;
                    break;
                case "manufacturer":
                    sql = $"select * from `{listBox1.SelectedItem}` where `name` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "order":
                    sql = "select `order`.*,`customer`.`name`,`customer`.`surname`,`build`.`name` from `order` " +
                        "inner join `customer` on `order`.`customer_id` = `customer`.`id`" +
                        "inner join `build` on `order`.`build_id` = `build`.`id`" +
                        $"where `quantity` like '%{textBox1.Text}%' or `price` like '%{textBox1.Text}%' or `customer`.`name` like '%{textBox1.Text}%' or `customer`.`surname` like '%{textBox1.Text}%' or `build`.`name` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[3].Visible = false; dataGridView1.Columns[4].Visible = false;
                    break;
                case "customer":
                    sql = $"select * from `{listBox1.SelectedItem}` where `surname` like '%{textBox1.Text}%' or `name` like '%{textBox1.Text}%' or `patronymic` like '%{textBox1.Text}%' or `phone number` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "build":
                    sql = $"select * from `{listBox1.SelectedItem}` where `name` like '%{textBox1.Text}%' or `build type` like '%{textBox1.Text}%'";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
            }
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        private void button6_Click(object sender, EventArgs e)//sql
        {
            string sql = $"{textBox2.Text}";
            adapterSql(sql);
            dataGridView1.Columns[0].Visible = false;
            string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }


    }
}
