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
namespace Online_Banking_System
{
    public partial class Admin_Panel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\3rd Semester\Software Development\New folder\Online Banking System\DataBase\Admin.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         con.Open();
         SqlCommand cmd = con.CreateCommand();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = "insert into [Table] values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"')";
         cmd.ExecuteNonQuery();
         con.Close();
         textBox1.Text = "";
         textBox2.Text = "";
         textBox3.Text = "";
         textBox4.Text = "";
         textBox5.Text = "";
         comboBox1.Text = "";
         MessageBox.Show("Insert Successfully !!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Table] where ID = '"+textBox1.Text+"' and Name = '"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("The Entry Was Deleted Successfully !!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Table] set ID = '" + textBox6.Text + "'where ID = '" + textBox1.Text + "'update [Table] set Name = '" + textBox7.Text + "' where Name = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("The information is update know !!!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pannel pa = new Pannel();
            pa.Show();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] where Name = '"+textBox8.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
