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
    public partial class Form2 : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        private async void adapterSql(string sql)
        {
            try
            {
                string connStr = "server=127.0.0.1; port=3306; username=root; password=root; database=mydb;";
                MySqlConnection conn = new MySqlConnection(connStr);
                mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
                int rowsGot = -1;
                DataSet DS = new DataSet();
                rowsGot = await mySqlDataAdapter.FillAsync(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            switch (listBox1.Text)
            {
                case "component type":
                    sql = "select * from `component type`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "components":
                    sql = "select `components`.*,`manufacturer`.`name`,`component type`.`name` from `components` " +
                        "inner join `manufacturer` on `components`.`manufacturer_id` = `manufacturer`.`id`" +
                        "inner join `component type` on `components`.`component type_id` = `component type`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[5].Visible = false; dataGridView1.Columns[6].Visible = false;
                    break;
                case "components-build":
                    sql = "select `components-build`.*,`components`.`name`,`build`.`name` from `components-build` " +
                        "inner join `components` on `components-build`.`components_id` = `components`.`id`" +
                        "inner join `build` on `components-build`.`build_id` = `build`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[2].Visible = false; dataGridView1.Columns[3].Visible = false;
                    break;
                case "manufacturer":
                    sql = "select * from `manufacturer`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "order":
                    sql = "select `order`.*,`customer`.`name`,`customer`.`surname`,`build`.`name` from `order` " +
                        "inner join `customer` on `order`.`customer_id` = `customer`.`id`" +
                        "inner join `build` on `order`.`build_id` = `build`.`id`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false; dataGridView1.Columns[3].Visible = false; dataGridView1.Columns[4].Visible = false;
                    break;
                case "customer":
                    sql = "select * from `customer`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case "build":
                    sql = "select * from `build`";
                    adapterSql(sql);
                    dataGridView1.Columns[0].Visible = false;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
