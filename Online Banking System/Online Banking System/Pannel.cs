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
    public partial class Pannel : Form
    {
        public Pannel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recharged obj = new Recharged();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing bill = new Billing();
            bill.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Panel ad = new Admin_Panel();
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction tr = new Transaction();
            tr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Details ad = new Account_Details();
            ad.Show();
        }

        private void Pannel_Load(object sender, EventArgs e)
        {

        }
    }
}
