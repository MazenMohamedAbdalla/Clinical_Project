using iTextSharp.text.pdf.parser;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Clinical_Projectt
{
    public partial class DoctorView : Form
    {
        int month, year;
        public DoctorView()
        {
            InitializeComponent();
        }
        private void DoctorView_Load(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            ViewPatientHistorypanel.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            panel16.Hide();
            panel17.Hide();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }
            else
            {
                panelMenu.Visible = false;
            }
        }

        private void ViewCalender_Click(object sender, EventArgs e)
        {
            if (ViewPatientHistorypanel.Visible == false)
            {
                ViewPatientHistorypanel.Visible = true;
            }
            else
            {
                ViewPatientHistorypanel.Visible = false;
            }

        }
        private void ViewUpcomingVisits_Click(object sender, EventArgs e)
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
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
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

        private void previous_Click(object sender, EventArgs e)
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

        private void ViewMedicalRecordspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewMedicalRecords_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
            dataGridView1.DataSource = GetdataGridView1();

        }
        private DataTable GetdataGridView1()
        {
            DataTable dt1 = new DataTable();
            string MyConnection1 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection1);
            string que = "select patient_ID , prescription, diagnosis , notes ,  \n(select concat(patientFirstName , ' ' , patientMiddleName, ' ', patientLastName)  from clinic.patient where patientID = clinic.examination.Patient_ID ) as PatientName\n from clinic.examination";
            MySqlCommand MyCommand2 = new MySqlCommand(que, MyConn2);
            MyConn2.Open();
            MySqlDataReader reader = MyCommand2.ExecuteReader();
            dt1.Load(reader);
            return dt1;
        }
    


        private void NewAppointment_Click(object sender, EventArgs e)
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


        private void ViewMedicalReport_Click(object sender, EventArgs e)
        {
            if (panel9.Visible == false)
            {
                panel9.Visible = true;
            }
            else
            {
                panel9.Visible = false;
            }
            dataGridView2.DataSource = GetdataGridView2();

        }
        private DataTable GetdataGridView2()
        {
            DataTable dt = new DataTable();
            string MyConnection = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);

            string Query = "select *,\n(select count(Distinct(Patient_ID)) from clinic.examination where diagnosis = clinic.ontology.diagnosis ) as Count_Patients,\n(select avg(year(curdate())-  year(patientDateOfBirth)) from clinic.patient where (PatientID in (select distinct (Patient_ID) from clinic.examination where diagnosis = clinic.ontology.diagnosis))) as Avg_Age\nfrom clinic.ontology";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataReader reader = MyCommand2.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

            private void ViewPatientHistorypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton6_Click(object sender, EventArgs e)
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

        private void ruButton10_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
        }

        private void ruButton11_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == false)
            {
                panel6.Visible = true;
            }
            else
            {
                panel6.Visible = false;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton5_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
            int IDsearch = Int32.Parse(textBox2.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT diagnosis FROM clinic.examination WHERE Patient_ID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Dia = "";
            while (MyReader2.Read())
            {
                Dia = MyReader2.GetString("diagnosis");
            }
            textBox6.Text = Dia;
            MyReader2.Close();


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton9_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
            {
                panel8.Visible = true;
            }
            else
            {
                panel8.Visible = false;
            }
            int IDsearch = Int32.Parse(textBox2.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT prescription FROM clinic.examination WHERE Patient_ID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Pre = "";
            while (MyReader2.Read())
            {
                Pre = MyReader2.GetString("prescription");
            }
            textBox7.Text = Pre;
            MyReader2.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton12_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM clinic.patient WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Name = "";
            String Mstatus = "";
            String PHnumber = "";
            String Address = "";
            String Age = "";
            int Day = 0;
            int Month = 0;
            int Year = 0;
            while (MyReader2.Read())
            {
                Name = MyReader2.GetString("patientFirstName") + " " + MyReader2.GetString("patientMiddleName") + " " + MyReader2.GetString("patientLastName");
                Mstatus = MyReader2.GetString("patientMaritalStatus");
                PHnumber = MyReader2.GetString("patientPhoneNum");
                Address = MyReader2.GetString("patientAddress");
                Age = MyReader2.GetString("patientDateOfBirth");
                string[] tokens = Age.Split();
                Age = tokens[0];
                string[] token = Age.Split('/');
                Day = Int32.Parse(token[0]);
                Month = Int32.Parse(token[1]);
                Year = Int32.Parse(token[2]);
                var birthday = new DateTime(Year,Month,Day);
                int age =  DateTime.Now.Year - birthday.Year;
                Age = age.ToString();

            }
            label10.Text = Name;
            label20.Text = Mstatus;
            label21.Text = PHnumber;   
            label22.Text = Age;
            label23.Text = Address;
            MyReader2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void ruButton2_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
            }
            else
            {
                panel10.Visible = false;
            }

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton14_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
            }
            else
            {
                panel10.Visible = false;
            }

        }

        private void ruButton15_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Reason = "";
            String HName = "";
            String HAge = "";
            String FPA = "";
            String PR = "";
            String PIR = "";
            String PD = "";
            String PtoPBleeding = "";
            String BAfterSex = "";
            String NoDPBleeding4 = "";
            String NoDPBleeding47 = "";
            String NoDPBleeding7 = "";
            while (MyReader2.Read())
            {
                Reason = MyReader2.GetString("Visit_Reason");
                HName = MyReader2.GetString("Husband_Name");
                HAge = MyReader2.GetString("Husband_Age");
                FPA = MyReader2.GetString("FirstPeriod_Age");
                PR = MyReader2.GetString("Period_Regular");
                int pr = Int32.Parse(PR);
                if (pr == 0) {
                    PR = "Fasle";
                }
                else {
                    PR = "True";
                        }
                PIR = MyReader2.GetString("Period_IRegular");
                int pir = Int32.Parse(PIR);
                if (pir == 0)
                {
                    PIR = "Fasle";
                }
                else
                {
                    PIR = "True";
                }
                PD = MyReader2.GetString("Period_Duration");
                PtoPBleeding = MyReader2.GetString("PeriodtoPeriod_bleeding");
                int ptopbleeding = Int32.Parse(PtoPBleeding);
                if (ptopbleeding == 0)
                {
                    PtoPBleeding = "Fasle";
                }
                else
                {
                    PtoPBleeding = "True";
                }
                BAfterSex = MyReader2.GetString("Bleeding_AfterSex");
                int baf = Int32.Parse(BAfterSex);
                if (baf == 0)
                {
                    BAfterSex = "Fasle";
                }
                else
                {
                    BAfterSex = "True";
                }
                NoDPBleeding4 = MyReader2.GetString("Period_Duration_4d");
                int nodp4 = Int32.Parse(NoDPBleeding4);
                if (nodp4 == 0)
                {
                    NoDPBleeding4 = "Fasle";
                }
                else
                {
                    NoDPBleeding4 = "True";
                }
                NoDPBleeding47 = MyReader2.GetString("Period_Duration_7d");
                int nodp47 = Int32.Parse(NoDPBleeding47);
                if (nodp47 == 0)
                {
                    NoDPBleeding47 = "Fasle";
                }
                else
                {
                    NoDPBleeding47 = "True";
                }
                NoDPBleeding7 = MyReader2.GetString("Period_Duration_MoreThan7d");
                int nodp7 = Int32.Parse(NoDPBleeding7);
                if (nodp7 == 0)
                {
                    NoDPBleeding7 = "Fasle";
                }
                else
                {
                    NoDPBleeding7 = "True";
                }

            }
            label38.Text = Reason;
            label39.Text = HName;
            label40.Text = HAge;
            label41.Text = FPA;
            label42.Text = PR;
            label43.Text = PIR;
            label44.Text = PD;
            label45.Text = PtoPBleeding;
            label46.Text = BAfterSex;
            label47.Text = NoDPBleeding4;
            label48.Text = NoDPBleeding47;
            label49.Text = NoDPBleeding7;
            MyReader2.Close();

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton16_Click(object sender, EventArgs e)
        {
            if (panel11.Visible == false)
            {
                panel10.Visible = false;
                panel11.Visible = true;
            }
            else
            {
                panel11.Visible = false;
                panel10.Visible = true;
            }
        }

        private void ruButton19_Click(object sender, EventArgs e)
        {
            if (panel11.Visible == false)
            {
                panel11.Visible = true;
            }
            else
            {
                panel11.Visible = false;
            }

        }

        private void ruButton20_Click(object sender, EventArgs e)
        {
            if (panel11.Visible == false)
            {
                panel10.Visible = false;
                panel11.Visible = true;
            }
            else
            {
                panel11.Visible = false;
                panel10.Visible = true;
            }
        }

        private void ruButton18_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String LPDate = "";
            String PPain = "";
            String PNoPain = "";
            String PSometimesPain = "";
            String PainBeforeP = "";
            String PainDuringP = "";
            String PainBandDP = "";
            String HadPregnant = "";
            String HadAbortion = "";
            String PregnancyAbortion_Year = "";
            String PregnancyAbortion_Place = "";
            String Pregnancy_Duration = "";
            String HoursOfLabor = "";
            String TTypeofDelivery = "";
            String Baby_Gender = "";
            String Baby_BirthWeight = "";
            String Baby_PresentHealth = "";
            while (MyReader2.Read())
            {
                LPDate = MyReader2.GetString("Last_PeriodDate");
                string[] tokens = LPDate.Split();
                LPDate = tokens[0];
                PPain = MyReader2.GetString("Period_Pain_Yes");
                int ppain = Int32.Parse(PPain);
                if (ppain == 0)
                {
                    PPain = "Fasle";
                }
                else
                {
                    PPain = "True";
                }
                PNoPain = MyReader2.GetString("Period_Pain_No");
                int pnopain = Int32.Parse(PNoPain);
                if (pnopain == 0)
                {
                    PNoPain = "Fasle";
                }
                else
                {
                    PNoPain = "True";
                }
                PSometimesPain = MyReader2.GetString("Period_Pain_Sometimes");
                int psometimespin = Int32.Parse(PSometimesPain);
                if (psometimespin == 0)
                {
                    PSometimesPain = "Fasle";
                }
                else
                {
                    PSometimesPain = "True";
                }
                PainBeforeP = MyReader2.GetString("Pain_Before_Period");
                int painbeforep = Int32.Parse(PainBeforeP);
                if (painbeforep == 0)
                {
                    PainBeforeP = "False";
                }
                else { 
                    PainBeforeP= "True";
                }
                PainDuringP = MyReader2.GetString("Pain_During_Period");
                int painduringp = Int32.Parse(PainDuringP);
                if (painduringp == 0)
                {
                    PainDuringP = "False";
                }
                else
                {
                    PainDuringP = "True";
                }
                PainBandDP = MyReader2.GetString("Pain_BeforeandDuring_Period");
                int painbanddp = Int32.Parse(PainBandDP);
                if (painbanddp == 0)
                {
                    PainBandDP = "False";
                }
                else
                {
                    PainBandDP = "True";
                }
                HadPregnant = MyReader2.GetString("Had_Pregnant");
                int hadpregnant = Int32.Parse(HadPregnant);
                if (hadpregnant == 0)
                {
                    HadPregnant = "False";
                }
                else
                {
                    HadPregnant = "True";
                }
                HadAbortion = MyReader2.GetString("Had_Abortion");
                int hadabortion = Int32.Parse(HadAbortion);
                if (hadabortion == 0)
                {
                    HadAbortion = "False";
                }
                else
                {
                    HadAbortion = "True";
                }
                PregnancyAbortion_Year = MyReader2.GetString("PregnancyorAbortion_Year");
                PregnancyAbortion_Place = MyReader2.GetString("Pregnancyorbortion_Place");
                Pregnancy_Duration = MyReader2.GetString("Pregnancy_Duration");
                HoursOfLabor = MyReader2.GetString("HoursOfLabor");
                TTypeofDelivery = MyReader2.GetString("TypeofDelivery");
                Baby_Gender = MyReader2.GetString("Baby_Gender");
                Baby_BirthWeight = MyReader2.GetString("Baby_BirthWeight");
                Baby_PresentHealth = MyReader2.GetString("Baby_PresentHealth");
            }
            label61.Text = LPDate;
            label60.Text = PPain;
            label59.Text = PNoPain;
            label58.Text = PSometimesPain;
            label84.Text = PainBeforeP;
            label85.Text = PainDuringP;
            label86.Text = PainBandDP;
            label57.Text = HadPregnant;
            label56.Text = HadAbortion;
            label55.Text = PregnancyAbortion_Year;
            label11.Text = PregnancyAbortion_Place;
            label53.Text = Pregnancy_Duration;
            label52.Text = HoursOfLabor;
            label51.Text = TTypeofDelivery;
            label50.Text = Baby_Gender;
            label79.Text = Baby_BirthWeight;
            label78.Text = Baby_PresentHealth;
            MyReader2.Close();
            }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton17_Click(object sender, EventArgs e)
        {
            if (panel12.Visible == false)
            {
                panel11.Visible = false;
                panel12.Visible = true;
            }
            else
            {
                panel12.Visible = false;
                panel11.Visible = true;
            }
        }

        private void ruButton21_Click(object sender, EventArgs e)
        {
            if (panel12.Visible == false)
            {
                panel11.Visible = false;
                panel12.Visible = true;
            }
            else
            {
                panel12.Visible = false;
                panel11.Visible = true;
            }
        }

        private void ruButton22_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ruButton21_Click_1(object sender, EventArgs e)
        {
            if (panel12.Visible == false)
            {
                panel11.Visible = false;
                panel12.Visible = true;
            }
            else
            {
                panel12.Visible = false;
                panel11.Visible = true;
            }

        }

        private void ruButton24_Click(object sender, EventArgs e)
        {
            if (panel12.Visible == false)
            {
                panel12.Visible = true;
            }
            else
            {
                panel12.Visible = false;
            }
        }

        private void ruButton23_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String SexualIn = "";
            String HadGynSurgery = "";
            String Infertility_Surgery = "";
            String Ovarian_Surgery = "";
            String Cesarean_Surgery = "";
            String Tubal_Ligation_Surgery = "";
            String Hysterectomy_Surgery = "";
            String Laparoscopy_Surgery = "";
            String Infertility_Surgery_Year = "";
            String Ovarian_Surgery_Year = "";
            String Cesarean_Surgery_Year = "";
            String Tubal_Ligation_Surgery_Year = "";
            String Hysterectomy_Surgery_Year = "";
            String Laparoscopy_Surgery_Year = "";
            String Other_Gyn_Surgeries = "";
            String Other_Gyn_Surgeries_Year = "";
            while (MyReader2.Read())
            {
                SexualIn = MyReader2.GetString("SexualActivity_Iquiries");
                int sexualin = Int32.Parse(SexualIn);
                if (sexualin == 0)
                {
                    SexualIn = "No";
                }
                else
                {
                    SexualIn = "Yes";
                }
                HadGynSurgery = MyReader2.GetString("Had_Gyn_Surgries");
                int hadgynsurgery = Int32.Parse(HadGynSurgery);
                if (hadgynsurgery == 0)
                {
                    HadGynSurgery = "No";
                }
                else
                {
                    HadGynSurgery = "Yes";
                }
                Infertility_Surgery = MyReader2.GetString("Infertility_Surgery");
                int infer = Int32.Parse(Infertility_Surgery);
                if (infer == 0)
                {
                    Infertility_Surgery = "No";
                }
                else
                {
                    Infertility_Surgery = "Yes";
                }
                Ovarian_Surgery = MyReader2.GetString("Ovarian_Surgery");
                int Ovar = Int32.Parse(Ovarian_Surgery);
                if (Ovar == 0)
                {
                    Ovarian_Surgery = "No";
                }
                else
                {
                    Ovarian_Surgery = "Yes";
                }
                Cesarean_Surgery = MyReader2.GetString("Cesarean_Surgery");
                int Ces = Int32.Parse(Cesarean_Surgery);
                if (Ces == 0)
                {
                    Cesarean_Surgery = "No";
                }
                else
                {
                    Cesarean_Surgery = "Yes";
                }
                Tubal_Ligation_Surgery = MyReader2.GetString("Tubal_Ligation_Surgery");
                int tubal = Int32.Parse(Tubal_Ligation_Surgery);
                if (tubal == 0)
                {
                    Tubal_Ligation_Surgery = "No";
                }
                else
                {
                    Tubal_Ligation_Surgery = "Yes";
                }
                Hysterectomy_Surgery = MyReader2.GetString("Hysterectomy_Surgery");
                int Hys = Int32.Parse(Hysterectomy_Surgery);
                if (Hys == 0)
                {
                    Hysterectomy_Surgery = "No";
                }
                else
                {
                    Hysterectomy_Surgery = "Yes";
                }
                Laparoscopy_Surgery = MyReader2.GetString("Laparoscopy_Surgery");
                int Lap = Int32.Parse(Laparoscopy_Surgery);
                if (Lap == 0)
                {
                    Laparoscopy_Surgery = "No";
                }
                else
                {
                    Laparoscopy_Surgery = "Yes";
                }
                Infertility_Surgery_Year = MyReader2.GetString("Infertility_Surgery_Year");
                Ovarian_Surgery_Year = MyReader2.GetString("Ovarian_Surgery_Year");
                Cesarean_Surgery_Year = MyReader2.GetString("Cesarean_Surgery_Year");
                Tubal_Ligation_Surgery_Year = MyReader2.GetString("Tubal_Ligation_Surgery_Year");
                Hysterectomy_Surgery_Year = MyReader2.GetString("Hysterectomy_Surgery_Year");
                Laparoscopy_Surgery_Year = MyReader2.GetString("Laparoscopy_Surgery_Year");
                Other_Gyn_Surgeries = MyReader2.GetString("Other_Gyn_Surgeries");
                Other_Gyn_Surgeries_Year = MyReader2.GetString("Other_Gyn_Surgeries_Year");

            }
            label111.Text = SexualIn;
            label110.Text = HadGynSurgery;
            label109.Text = Infertility_Surgery;
            label108.Text = Infertility_Surgery_Year;
            label87.Text = Ovarian_Surgery;
            label107.Text = Ovarian_Surgery_Year;
            label106.Text = Cesarean_Surgery;
            label105.Text = Cesarean_Surgery_Year;
            label99.Text = Tubal_Ligation_Surgery;
            label104.Text = Tubal_Ligation_Surgery_Year;
            label103.Text = Hysterectomy_Surgery;
            label102.Text = Hysterectomy_Surgery_Year;
            label95.Text = Laparoscopy_Surgery;
            label94.Text = Laparoscopy_Surgery_Year;
            label101.Text = Other_Gyn_Surgeries;
            label88.Text = Other_Gyn_Surgeries_Year;
            MyReader2.Close();

            }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton25_Click(object sender, EventArgs e)
        {
            if (panel13.Visible == false)
            {
                panel12.Visible = false;
                panel13.Visible = true;
            }
            else
            {
                panel13.Visible = false;
                panel12.Visible = true;
            }
        }

        private void ruButton22_Click_1(object sender, EventArgs e)
        {
            if (panel13.Visible == false)
            {
                panel12.Visible = false;
                panel13.Visible = true;
            }
            else
            {
                panel13.Visible = false;
                panel12.Visible = true;
            }
        }

        private void ruButton28_Click(object sender, EventArgs e)
        {
            if (panel13.Visible == false)
            {
                panel13.Visible = true;
            }
            else
            {
                panel13.Visible = false;
            }
        }

        private void ruButton27_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Another_Surgeries = "";
            String Surgery_Type = "";
            String Surgery_Year = "";
            String Date_last_PapSmear = "";
            String Have_Arthritis = "";
            String Have_HighBloodPresaure = "";
            String Have_HeartDiseases = "";
            String Have_KidneyDiseases = "";
            String Have_Emphysema = "";
            String Have_EatingDisorder = "";
            String Have_BloodTransfustions = "";
            String Have_ThyroidDiseases = "";
            String Have_Epileps = "";
            String Have_AnotherDiseases = "";
            while (MyReader2.Read())
            {
                Another_Surgeries = MyReader2.GetString("Another_Surgeries");
                int another = Int32.Parse(Another_Surgeries);
                if (another == 0)
                {
                    Another_Surgeries = "No";
                }
                else
                {
                    Another_Surgeries = "Yes";
                }
                Surgery_Type = MyReader2.GetString("Surgery_Type");
                Surgery_Year = MyReader2.GetString("Surgery_Year");
                Date_last_PapSmear = MyReader2.GetString("Date_last_PapSmear");
                string[] tokens = Date_last_PapSmear.Split();
                Date_last_PapSmear = tokens[0];
                Have_Arthritis = MyReader2.GetString("Have_Arthritis");
                int arth = Int32.Parse(Have_Arthritis);
                if (arth == 0)
                {
                    Have_Arthritis = "No";
                }
                else
                {
                    Have_Arthritis = "Yes";
                }
                Have_HighBloodPresaure = MyReader2.GetString("Have_HighBloodPresaure");
                int Hbp = Int32.Parse(Have_HighBloodPresaure);
                if (Hbp == 0)
                {
                    Have_HighBloodPresaure = "No";
                }
                else
                {
                    Have_HighBloodPresaure = "Yes";
                }
                Have_HeartDiseases = MyReader2.GetString("Have_HeartDiseases");
                int heart = Int32.Parse(Have_HeartDiseases);
                if (heart == 0)
                {
                    Have_HeartDiseases = "No";
                }
                else
                {
                    Have_HeartDiseases = "Yes";
                }
                Have_KidneyDiseases = MyReader2.GetString("Have_KidneyDiseases");
                int kidney = Int32.Parse(Have_KidneyDiseases);
                if (kidney == 0)
                {
                    Have_KidneyDiseases = "No";
                }
                else
                {
                    Have_KidneyDiseases = "Yes";
                }
                Have_Emphysema = MyReader2.GetString("Have_Emphysema");
                int emphysema = Int32.Parse(Have_Emphysema);
                if (emphysema == 0)
                {
                    Have_Emphysema = "No";
                }
                else
                {
                    Have_Emphysema = "Yes";
                }
                Have_EatingDisorder = MyReader2.GetString("Have_EatingDisorder");
                int eatingdisorder = Int32.Parse(Have_EatingDisorder);
                if (eatingdisorder == 0)
                {
                    Have_EatingDisorder = "No";
                }
                else
                {
                    Have_EatingDisorder = "Yes";
                }
                Have_BloodTransfustions = MyReader2.GetString("Have_BloodTransfustions");
                int bloodtransfust = Int32.Parse(Have_BloodTransfustions);
                if (bloodtransfust == 0)
                {
                    Have_BloodTransfustions = "No";
                }
                else
                {
                    Have_BloodTransfustions = "Yes";
                }
                Have_ThyroidDiseases = MyReader2.GetString("Have_ThyroidDiseases");
                int thyroidd = Int32.Parse(Have_ThyroidDiseases);
                if (thyroidd == 0)
                {
                    Have_ThyroidDiseases = "No";
                }
                else
                {
                    Have_ThyroidDiseases = "Yes";
                }
                Have_Epileps = MyReader2.GetString("Have_Epileps");
                int epileps = Int32.Parse(Have_Epileps);
                if (epileps == 0)
                {
                    Have_Epileps = "No";
                }
                else
                {
                    Have_Epileps = "Yes";
                }
                Have_AnotherDiseases = MyReader2.GetString("Have_AnotherDiseases");

            }
            label200.Text = Another_Surgeries;
            label201.Text = Surgery_Type;
            label202.Text = Surgery_Year;
            label203.Text = Date_last_PapSmear;
            label204.Text = Have_Arthritis;
            label205.Text = Have_HighBloodPresaure;
            label206.Text = Have_HeartDiseases;
            label207.Text = Have_KidneyDiseases;
            label208.Text = Have_Emphysema;
            label209.Text = Have_EatingDisorder;
            label210.Text = Have_BloodTransfustions;
            label211.Text = Have_ThyroidDiseases;
            label212.Text = Have_Epileps;
            label213.Text = Have_AnotherDiseases;
            MyReader2.Close();
            }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton26_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == false)
            {
                panel13.Visible = false;
                panel14.Visible = true;
            }
            else
            {
                panel14.Visible = false;
                panel13.Visible = true;
            }
        }

        private void ruButton29_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == false)
            {
                panel13.Visible = false;
                panel14.Visible = true;
            }
            else
            {
                panel14.Visible = false;
                panel13.Visible = true;
            }
        }

        private void ruButton32_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == false)
            {
                panel14.Visible = true;
            }
            else
            {
                panel14.Visible = false;
            }
        }

        private void ruButton31_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Medicine_Taken = "";
            String Medicine_Doses = "";
            String Medicine_Pill_PerDay = "";
            String Have_Drug_Allergies = "";
            String Drug_Allergies_Names = "";
            String FamiliyMember_Diabetes = "";
            String FamiliyMember_OvarianCnacer = "";
            String FamiliyMember_BreastCancer = "";
            String FamiliyMember_ColonCancer = "";
            String Another_FamiliyMember_Diseases = "";
            String No_FamiliyMember_Diseases = "";
            String Names_FamiliyMember_Diseases = "";
            while (MyReader2.Read())
            {
                Medicine_Taken = MyReader2.GetString("Medicine_Taken");
                Medicine_Doses = MyReader2.GetString("Medicine_Doses");
                Medicine_Pill_PerDay = MyReader2.GetString("Medicine_Pill_PerDay");
                Have_Drug_Allergies = MyReader2.GetString("Have_Drug_Allergies");
                int allergeis = Int32.Parse(Have_Drug_Allergies);
                if (allergeis == 0)
                {
                    Have_Drug_Allergies = "No";
                }
                else
                {
                    Have_Drug_Allergies = "Yes";
                }
                Drug_Allergies_Names = MyReader2.GetString("Drug_Allergies_Names");
                FamiliyMember_Diabetes = MyReader2.GetString("FamiliyMember_Diabetes");
                int diab = Int32.Parse(FamiliyMember_Diabetes);
                if (diab == 0)
                {
                    FamiliyMember_Diabetes = "No";
                }
                else
                {
                    FamiliyMember_Diabetes = "Yes";
                }
                FamiliyMember_OvarianCnacer = MyReader2.GetString("FamiliyMember_OvarianCnacer");
                int ovar = Int32.Parse(FamiliyMember_OvarianCnacer);
                if (ovar == 0)
                {
                    FamiliyMember_OvarianCnacer = "No";
                }
                else
                {
                    FamiliyMember_OvarianCnacer = "Yes";
                }
                FamiliyMember_BreastCancer = MyReader2.GetString("FamiliyMember_BreastCancer");
                int breast = Int32.Parse(FamiliyMember_BreastCancer);
                if (breast == 0)
                {
                    FamiliyMember_BreastCancer = "No";
                }
                else
                {
                    FamiliyMember_BreastCancer = "Yes";
                }
                FamiliyMember_ColonCancer = MyReader2.GetString("FamiliyMember_ColonCancer");
                int colon = Int32.Parse(FamiliyMember_ColonCancer);
                if (colon == 0)
                {
                    FamiliyMember_ColonCancer = "No";
                }
                else
                {
                    FamiliyMember_ColonCancer = "Yes";
                }
                Another_FamiliyMember_Diseases = MyReader2.GetString("Another_FamiliyMember_Diseases");
                No_FamiliyMember_Diseases = MyReader2.GetString("No_FamiliyMember_Diseases");
                int no = Int32.Parse(No_FamiliyMember_Diseases);
                if (no == 0)
                {
                    No_FamiliyMember_Diseases = "No";
                }
                else
                {
                    No_FamiliyMember_Diseases = "Yes";
                }
                Names_FamiliyMember_Diseases = MyReader2.GetString("Names_FamiliyMember_Diseases");


            }
            label140.Text = Medicine_Taken;
            label139.Text = Medicine_Doses;
            label138.Text = Medicine_Pill_PerDay;
            label137.Text = Have_Drug_Allergies;
            label90.Text = Drug_Allergies_Names;
            label136.Text = FamiliyMember_Diabetes;
            label135.Text = FamiliyMember_OvarianCnacer;
            label134.Text = FamiliyMember_BreastCancer;
            label126.Text = FamiliyMember_ColonCancer;
            label133.Text = Another_FamiliyMember_Diseases;
            label132.Text = No_FamiliyMember_Diseases;
            label131.Text = Names_FamiliyMember_Diseases;
            MyReader2.Close();
            }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton33_Click(object sender, EventArgs e)
        {
            if (panel15.Visible == false)
            {
                panel14.Visible = false;
                panel15.Visible = true;
            }
            else
            {
                panel15.Visible = false;
                panel14.Visible = true;
            }
        }

        private void ruButton36_Click(object sender, EventArgs e)
        {
            if (panel15.Visible == false)
            {
                panel15.Visible = true;
            }
            else
            {
                panel15.Visible = false;
            }
        }

        private void ruButton30_Click(object sender, EventArgs e)
        {
            if (panel15.Visible == false)
            {
                panel14.Visible = false;
                panel15.Visible = true;
            }
            else
            {
                panel15.Visible = false;
                panel14.Visible = true;
            }
        }

        private void ruButton35_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT * FROM patient_history WHERE patientID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Weight_Loss_Recently = "";
            String Weight_Gain_Recently = "";
            String Hair_Growth_Recently = "";
            String Hair_Loss_Recently = "";
            String ChangeInEnergy_Recently = "";
            String BreastDischarge_Recently = "";
            String AnotherSymptoms_Recently = "";
            String NoSymptoms_Recently = "";
            while (MyReader2.Read())
            {
                Weight_Loss_Recently = MyReader2.GetString("Weight_Loss_Recently");
                int loss = Int32.Parse(Weight_Loss_Recently);
                if (loss == 0)
                {
                    Weight_Loss_Recently = "No";
                }
                else
                {
                    Weight_Loss_Recently = "Yes";
                }
                Weight_Gain_Recently = MyReader2.GetString("Weight_Gain_Recently");
                int gain = Int32.Parse(Weight_Gain_Recently);
                if (gain == 0)
                {
                    Weight_Gain_Recently = "No";
                }
                else
                {
                    Weight_Gain_Recently = "Yes";
                }
                Hair_Growth_Recently = MyReader2.GetString("Hair_Growth_Recently");
                int growth = Int32.Parse(Hair_Growth_Recently);
                if (growth == 0)
                {
                    Hair_Growth_Recently = "No";
                }
                else
                {
                    Hair_Growth_Recently = "Yes";
                }
                Hair_Loss_Recently = MyReader2.GetString("Hair_Loss_Recently");
                int Hloss = Int32.Parse(Hair_Loss_Recently);
                if (Hloss == 0)
                {
                    Hair_Loss_Recently = "No";
                }
                else
                {
                    Hair_Loss_Recently = "Yes";
                }
                ChangeInEnergy_Recently = MyReader2.GetString("ChangeInEnergy_Recently");
                int change = Int32.Parse(ChangeInEnergy_Recently);
                if (change == 0)
                {
                    ChangeInEnergy_Recently = "No";
                }
                else
                {
                    ChangeInEnergy_Recently = "Yes";
                }
                BreastDischarge_Recently = MyReader2.GetString("BreastDischarge_Recently");
                int breast = Int32.Parse(BreastDischarge_Recently);
                if (breast == 0)
                {
                    BreastDischarge_Recently = "No";
                }
                else
                {
                    BreastDischarge_Recently = "Yes";
                }
                AnotherSymptoms_Recently = MyReader2.GetString("AnotherSymptoms_Recently");
                NoSymptoms_Recently = MyReader2.GetString("NoSymptoms_Recently");
                int no = Int32.Parse(NoSymptoms_Recently);
                if (no == 0)
                {
                    NoSymptoms_Recently = "No";
                }
                else
                {
                    NoSymptoms_Recently = "Yes";
                }
            }
            label178.Text = Weight_Loss_Recently;
            label177.Text = Weight_Gain_Recently;
            label176.Text = Hair_Growth_Recently;
            label175.Text = Hair_Loss_Recently;
            label174.Text = ChangeInEnergy_Recently;
            label173.Text = BreastDischarge_Recently;
            label172.Text = AnotherSymptoms_Recently;
            label171.Text = NoSymptoms_Recently;
            MyReader2.Close();

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton7_Click(object sender, EventArgs e)
        {
            String NewDia = comboBox1.Text;
            textBox3.Text += NewDia + " - ";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton8_Click(object sender, EventArgs e)
        {
            String NewPre = comboBox2.Text;
            textBox4.Text += NewPre + " - ";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void ruButton37_Click(object sender, EventArgs e)
        {
            int IDsearch = Int32.Parse(textBox2.Text);
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
            label93.Text = Name;
            MyReader2.Close();

        }

        private void ruButton34_Click(object sender, EventArgs e)
        {


            try
            {
                int IDsearch = Int32.Parse(textBox2.Text);
                String pre = textBox4.Text;
                String Dia = textBox3.Text;
                String Not = textBox5.Text;
                string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
                string Query = "insert into clinic.examination(prescription,diagnosis,notes,Patient_ID) values('" + pre + "','" + Dia + "','" + Not + "','" + IDsearch + "');";
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ruButton38_Click(object sender, EventArgs e)
        {
           
        }

        private void ruButton3_Click(object sender, EventArgs e)
        {
            if (panel16.Visible == false)
            {
                panel16.Visible = true;
            }
            else
            {
                panel16.Visible = false;
            }
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT Lab_Test FROM clinic.labtest WHERE Patient_ID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Test = "";
            while (MyReader2.Read())
            {
                Test = MyReader2.GetString("Lab_Test");
                comboBox3.Items.Add(Test);
                comboBox4.Items.Add(Test);
            }
            MyReader2.Close();



        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void ruButton38_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String LabLoc = comboBox3.Text;
            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader("D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Lab tests\\"+ LabLoc);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= reader.NumberOfPages; i++) {
                sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton39_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String LabLoc = comboBox4.Text;
            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader("D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Lab tests\\"+ LabLoc);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }
            richTextBox2.Text = sb.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ruButton40_Click(object sender, EventArgs e)
        {
            if (panel16.Visible == false)
            {
                panel16.Visible = true;
            }
            else
            {
                panel16.Visible = false;
            }
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruButton4_Click(object sender, EventArgs e)
        {
            if (panel17.Visible == false)
            {
                panel17.Visible = true;
            }
            else
            {
                panel17.Visible = false;
            }
            int IDsearch = Int32.Parse(textBox1.Text);
            string MyConnection2 = "server=localhost;uid=root;pwd=$tr0ngPa$$w0rd;database=clinic";
            string Query = "SELECT Medical_Image FROM clinic.medicalimage WHERE Patient_ID = " + IDsearch;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            String Image = "";
            while (MyReader2.Read())
            {
                Image = MyReader2.GetString("Medical_Image");
                comboBox6.Items.Add(Image);
                comboBox5.Items.Add(Image);
            }
            MyReader2.Close();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruButton43_Click(object sender, EventArgs e)
        {
            String Scan = comboBox6.Text;
            pictureBox6.BackgroundImage = new Bitmap("D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Medical image\\"+Scan);
        }

        private void ruButton42_Click(object sender, EventArgs e)
        {
            String Scan = comboBox5.Text;
            pictureBox10.BackgroundImage = new Bitmap("D:\\Uni\\Clinical_Project-Master\\Clinical Projectt\\Medical image\\" + Scan);
        }

        private void ruButton41_Click(object sender, EventArgs e)
        {
            if (panel17.Visible == false)
            {
                panel17.Visible = true;
            }
            else
            {
                panel17.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            UserControlDays ucday = new UserControlDays();
            ucday.DisplayEvents(monthname);
  
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
    }
}
