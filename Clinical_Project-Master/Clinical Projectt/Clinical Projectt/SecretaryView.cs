using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ServiceStack.OrmLite;
using static ServiceStack.Script.Lisp;

namespace Clinical_Projectt
{
    public partial class SecretaryView : Form
    {
        int month, year;
        public SecretaryView()
        {
            InitializeComponent();
            panelMenu.Hide();
            MakeAppointmentPanel.Hide();
            EditPatientInfoPanel.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            label31.Hide();
            label32.Hide();
            label33.Hide();
            label34.Hide();

        }

        private void ruButton1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }
            else {
                panelMenu.Visible = false;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewCalender_Click(object sender, EventArgs e)
        {
            DisplayDays();
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                daycontainer.Controls.Clear();
            }
        }
        private void DisplayDays(){
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year ;

            DateTime startofthemonth = new DateTime(year,month,1);

            int days = DateTime.DaysInMonth(year,month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            for (int i = 1; i < dayoftheweek; i++){
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            
            }
            for (int i=1; i <= days; i++) { 
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                ucdays.DisplayEvents(monthname);

            }

        }

        private void SecretaryView_Load(object sender, EventArgs e)
        {
            
        }

        private void MakeAppointmentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MakeAppointment_Click(object sender, EventArgs e)
        {
            if (MakeAppointmentPanel.Visible == false)
            {
                MakeAppointmentPanel.Visible = true;
            }
            else {
                MakeAppointmentPanel.Visible = false;
            }


        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (EditPatientInfoPanel.Visible == false)
            {
                EditPatientInfoPanel.Visible = true;
            }
            else {
                EditPatientInfoPanel.Visible = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                ucdays.DisplayEvents(monthname);

            }

        }

        private void previous_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                ucdays.DisplayEvents(monthname);

            }

        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void ruButton8_Click(object sender, EventArgs e)
        {
            if (label31.Visible == false)
            {
                label31.Visible = true;
            }
            else
            {
                label31.Visible = false;
            }
        }

        private void ruButton5_Click(object sender, EventArgs e)
        {
            if (label32.Visible == false)
            {
                label32.Visible = true;
            }
            else
            {
                label32.Visible = false;
            }

        }

        private void ruButton6_Click(object sender, EventArgs e)
        {
            if (label33.Visible == false)
            {
                label33.Visible = true;
            }
            else
            {
                label33.Visible = false;
            }

        }

        private void ruButton7_Click(object sender, EventArgs e)
        {
            if (label34.Visible == false)
            {
                label34.Visible = true;
            }
            else
            {
                label34.Visible = false;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label39.Text = openFileDialog1.FileName;
                String soource = openFileDialog1.FileName;
                String fileNAme = "";
                String Status = "";
                String Loc = "";
                String Lab_Test = "";
                String Medical_Image = "";
                String ID = textBox18.Text;
                String Name = textBox17.Text;
                for (int i = soource.Length-1; i > 0 ; i--)
                {
                    if (soource[i].Equals('.'))
                        break;
                    else
                        fileNAme += soource[i];
                }
                    
                string reverseString = string.Empty;
                for (int i = fileNAme.Length - 1; i >= 0; i--)
                {
                    reverseString += fileNAme[i];
                }
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                string newfilename,labname;
                labname = comboBox5.Text;
                newfilename = comboBox3.Text;
                if (checkBox3.Checked == true){
                    Status = "Lab test";
                    Lab_Test = "$ " + ID + " " + Name + " " + date +" "+ labname + " Lab Test" + "." + reverseString;
                    Loc = "D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Lab tests\\" + Lab_Test;
                    try
                    {
                        int IDsearch = Int32.Parse(textBox18.Text);
                        string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
                        string Query = "insert into clinic.labtest(Lab_Test,Patient_ID) values('" + Lab_Test + "','" + IDsearch + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Saved Successfuly");
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                if (checkBox4.Checked == true)
                {
                    Status = "Mdical image";
                    Medical_Image = "$ " + ID + " " + Name + " " + date + " " + newfilename + "." + reverseString;
                    Loc = "D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Medical image\\" + Medical_Image;
                    checkBox3.Checked = false;
                    try
                    {
                        int IDsearch = Int32.Parse(textBox18.Text);
                        string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
                        string Query = "insert into clinic.medicalimage(Medical_Image,Patient_ID) values('" + Medical_Image + "','" + IDsearch + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Saved Successfuly");
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                label40.Text = Loc;
                String So = openFileDialog1.FileName;
                String Source = @So;
                String Dist = @Loc;
                File.Move(Source, Dist);
                MessageBox.Show(Status + " Added Successfully");
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void ruButton10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) {
                if (panel6.Visible == false)
                {
                    panel6.Visible = true;
                }
                else
                {
                    panel6.Visible = false;
                }
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (panel5.Visible == false)
                {
                    panel5.Visible = true;
                }
                else
                {
                    panel5.Visible = false;
                }
                checkBox3.Checked = false;
            }

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ruButton3_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> month = new Dictionary<string, int>(){{"January",01}, {"February",02},{"March",03}, {"April",04}, {"May",05}, {"June",06},
            {"July",07}, {"August",08},{"September",09},{"October",10}, {"November",11},{"December",12}};
            String AppTime = comboBox4.Text;
            int PatientID = Int32.Parse(textBox2.Text);
            String AppDate = dateTimePicker1.Text;
            string str_split_comma = AppDate;
            string[] broken_str_comma = str_split_comma.Split(',');
            List<string> AuthorList = new List<string>();
            List<string> Author = new List<string>();
            foreach (var sub_str_comma in broken_str_comma)
            {
                AuthorList.Add(sub_str_comma);
            }
            String Date = AuthorList[1];
            string[] broken_str = Date.Split(' ');
            foreach (var sub_str_comm in broken_str)
            {
                Author.Add(sub_str_comm);
            }
            String Month = month[Author[2]].ToString();
            if (Month.Length == 1)
            {
                Month = "0" + Month;
            }
            String Day = Author[1];
            if (Day.Length == 1)
            {
                Day = "0" + Day;
            }
            String FullDate = Author[3] + "-" + Month + "-" + Day;
            String AppType ="";
            if (checkBox1.Checked == true)
            {
                AppType = "New appointment";
            }
            if (checkBox2.Checked == true)
            {
                AppType = "check up";
            }
            try
            {
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "insert into clinic.appointment(appointmentTime,appointmentDate,appointmentType,patientID) values('" + AppTime + "','" + FullDate + "','" + AppType + "','" + PatientID+"');";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Save Data");
            MyConn2.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
      }

}

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }

        }

        private void textBox13_TextChanged_2(object sender, EventArgs e)
        {

        }
        public void ConnTime(String FullDate)
        {
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT appointmentTime FROM clinic.appointment where appointmentDate ='" + FullDate + "';";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            List<string> AuthorLi = new List<string>();
            List<String> slot = new List<String>() { "06:00:00","06:40:00","07:20:00","08:00:00","08:40:00","09:20:00"};
            while (MyReader2.Read())
            {
                AuthorLi.Add(MyReader2.GetString("appointmentTime"));
            }
            MyReader2.Close();
            IEnumerable<String> firstDiffSecond = slot.Except(AuthorLi);
            comboBox4.Items.Clear();
            foreach (string DiffSecond in firstDiffSecond)
            {
                comboBox4.Items.Add(DiffSecond);
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Dictionary<string, int> month = new Dictionary<string, int>(){{"January",01}, {"February",02},{"March",03}, {"April",04}, {"May",05}, {"June",06},
            {"July",07}, {"August",08},{"September",09},{"October",10}, {"November",11},{"December",12}};
            String AppDate = dateTimePicker1.Text;
            string str_split_comma = AppDate;
            string[] broken_str_comma = str_split_comma.Split(',');
            List<string> AuthorList = new List<string>();
            List<string> Author = new List<string>();
            foreach (var sub_str_comma in broken_str_comma)
            {
                AuthorList.Add(sub_str_comma);
            }
            String Date = AuthorList[1];
            string[] broken_str = Date.Split(' ');
            foreach (var sub_str_comm in broken_str)
            {
                Author.Add(sub_str_comm);
            }
            String Month = month[Author[2]].ToString();
            if (Month.Length == 1)
            {
                Month = "0" + Month;
            }
            String Day = Author[1];
            if (Day.Length == 1)
            {
                Day = "0" + Day;
            }
            String FullDate = "";
            FullDate = Author[3] + "-" + Month + "-" + Day;
            ConnTime(FullDate);
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton10_Click_1(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox2.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT patientFirstName,patientMiddleName,patientLastName, patientPhoneNum FROM clinic.patient WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Name = "";
            String PHnumber = "";
            while (MyReader2.Read())
            {
                Name = MyReader2.GetString("patientFirstName") + " " + MyReader2.GetString("patientMiddleName") + " " + MyReader2.GetString("patientLastName");
                PHnumber = MyReader2.GetString("patientPhoneNum");
            }
            textBox1.Text = Name;
            textBox12.Text = PHnumber;
            MyReader2.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ruButton11_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox11.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT patientFirstName,patientMiddleName,patientLastName FROM clinic.patient WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Name = "";
            while (MyReader2.Read())
            {
                Name = MyReader2.GetString("patientFirstName") + " " + MyReader2.GetString("patientMiddleName") + " " + MyReader2.GetString("patientLastName");
            }
            textBox6.Text = Name;
            MyReader2.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton2_Click(object sender, EventArgs e)
        {

            try
            {
                String NewAdd = textBox3.Text;
                String NewPH = textBox5.Text;
                String NewMS = comboBox1.Text;
                int PateintID = Int32.Parse(textBox11.Text);
                string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
                string Query = "Update clinic.patient set patientAddress ='" + NewAdd + "', patientPhoneNum ='" + NewPH + "', patientMaritalStatus ='" + NewMS + "' WHERE patientID = " + PateintID+";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data updated");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ruButton4_Click(object sender, EventArgs e)
        {
            String Fname = textBox10.Text;
            String Mname = textBox14.Text;
            String Lname = textBox15.Text;
            String DOP = textBox7.Text;
            String NID = textBox16.Text;
            String Address = textBox8.Text;
            String PHnumber = textBox9.Text;
            String Mstatus = comboBox2.Text;
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
                string Query = "insert into clinic.patient(patientFirstName,patientMiddleName,patientLastName,patientDateOfBirth,patientNationalID,patientPhoneNum,patientAddress,patientMaritalStatus) values('" + Fname + "','" + Mname + "','" + Lname + "','" + DOP +"','"+ NID +"','"+ PHnumber +"','"+ Address +"','"+ Mstatus +"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Saved");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ruButton12_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox18.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT patientFirstName,patientMiddleName,patientLastName FROM clinic.patient WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Name = "";
            while (MyReader2.Read())
            {
                Name = MyReader2.GetString("patientFirstName") + " " + MyReader2.GetString("patientMiddleName") + " " + MyReader2.GetString("patientLastName");
            }
            textBox17.Text = Name;
            MyReader2.Close();
        

    }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBDATE_Click_1(object sender, EventArgs e)
        {

        }

    }
}
