using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Clinical_Projectt
{
    public partial class UserControlDays : UserControl
    {
        String GMonth;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }
        public void days(int numday) {
            Ibdays.Text = numday + "";

        }
        public void DisplayEvents(string Month) {
            Dictionary<string, int> month = new Dictionary<string, int>(){{"January",01}, {"February",02},{"March",03}, {"April",04}, {"May",05}, {"June",06},
            {"July",07}, {"August",08},{"September",09},{"October",10}, {"November",11},{"December",12}};
            String connstring = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            String MMonth = month[Month].ToString();
            GMonth = MMonth;
            String AppMonth = "";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "select * from appointment";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> AuthorList = new List<string>();
            while (reader.Read())
            {
                AppMonth = reader.GetString("appointmentDate");
                AppMonth = AppMonth.Substring(0, 5);
                AuthorList.Add(AppMonth);
            }

            var q = from x in AuthorList
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                string day = x.Value;
                day = day.Substring(0, 2);
                string mon = x.Value;
                mon = mon.Substring(3, 2);
                int co = x.Count;
                String cou = co.ToString();
                Console.WriteLine("Day: " + day + " " + mon + " Count: " + x.Count);
                if (MMonth.Equals(mon))
                {
                    if (Ibdays.Text == day)
                    {
                        lbevent.Text = cou;
                    }
                }
            }

            
            reader.Dispose();
            cmd.Dispose();
            con.Dispose();

        }


        private void Ibdays_Click(object sender, EventArgs e)
        {

        }

        private void lbevent_Click(object sender, EventArgs e)
        {
            String connstring = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "select * from appointment";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String ApMonth;
                ApMonth = reader.GetString("appointmentDate");
                String Com = reader.GetString("appointmentDate");
                String Mon = reader.GetString("appointmentDate");
                Com = Com.Substring(0, 2);
                Mon = Mon.Substring(3, 2);
                String CurrentM = GMonth;
                if (CurrentM.Equals(Mon))
                {
                    if (Ibdays.Text == Com)
                    {

                     MessageBox.Show("Appintment ID: " + reader["appointmentNum"] + "\t Time: " + reader["appointmentTime"] + "\t Type: " + reader["appointmentType"] + "\t Patient ID: " + reader["patientID"]);
                        
                    }
                }
            }

            reader.Dispose();
            cmd.Dispose();
            con.Dispose();
          
        }
    }
}
