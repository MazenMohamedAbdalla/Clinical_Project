using Clinical_Projectt.Properties;

namespace Clinical_Projectt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ruButton1_Click(object sender, EventArgs e)
        {
            DoctorLogin obj = new DoctorLogin();
            obj.Show();
            this.Hide();

        }

        private void ruButton2_Click(object sender, EventArgs e)
        {
            ReceptionistLogin obj = new ReceptionistLogin();
            obj.Show();
            this.Hide();
        }
    }
}