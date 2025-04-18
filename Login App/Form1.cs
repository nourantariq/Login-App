using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_App
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(""); // enter the connection string 
            con.Open();
            string query = "SELECT COUNT (*) FROM login WHERE username=@username AND password=@password ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", userText.Text);
            cmd.Parameters.AddWithValue("@password", passText.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Successful", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed");



            }
        }

       

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


