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

namespace Clinical_Projectt.Properties
{
    public partial class ReceptionistLogin : Form
    {
        public ReceptionistLogin()
        {
            InitializeComponent();
        }

        private void ReceptionistLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void ruButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            String MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * from clinic.receptionist";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            string user_name = "";
            string Password = "";
            while (MyReader2.Read())
            {
                user_name = MyReader2.GetString("receptionistUsername");
                Password = MyReader2.GetString("receptionistPassword");
            }

            MyReader2.Close();

            if (String.IsNullOrEmpty(username) || username.Equals("Username"))
            {
                label1.Text = "mising username";

            }
            else
            {
                label1.Text = "";
                if (username.Equals(user_name))
                {
                    if (String.IsNullOrEmpty(pass) || pass.Equals("Password")) { label2.Text = "mising password"; }
                    else
                    {
                        label2.Text = "";
                        if (pass.Equals(Password))
                        {
                            SecretaryView obj = new SecretaryView();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            label2.Text = "wrong password";
                        }
                    }

                }
                else
                {
                    label1.Text = "wrong username";
                }
            }
        }
    }
}
