namespace Login
{
    public partial class Login : Form
    {
        LandingPage welcome;
        Username_lbl signup;
        Database myDatabase;


        public Login()
        {
            InitializeComponent();
            myDatabase = new Database();
            myDatabase.AddUser("labuser", "12345678");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup = new Username_lbl();
            signup.Show();

            this.Hide();
        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            username_txtbox.Text = "";
        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void login_rbtn_Click(object sender, EventArgs e)
        {
            bool result = myDatabase.Query(username_txtbox.Text, password_txtbox.Text);
            bool usernameCheck = myDatabase.CheckUsername(username_txtbox.Text);

            if (result)
            {
                welcome = new LandingPage(this, username_txtbox.Text);
                this.Hide();
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
                if (!usernameCheck)
                {
                    lbl_wronguser.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lbl_wrongpass.ForeColor = System.Drawing.Color.Red;
                }

                if (password_txtbox.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");
                }

                username_txtbox.Text = "";
                password_txtbox.Text = "";

            }

        }

        private void clear_btn2_Click(object sender, EventArgs e)
        {
            password_txtbox.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butler Bulllodgs");
        }

        private void lbl_wronguser_Click(object sender, EventArgs e)
        {

        }

        public void resetUser()
        {
            username_txtbox.Text = "";
        }

        public void resetPassword()
        {
            password_txtbox.Text = "";
        }
        public void reset_wrongUser()
        {
            lbl_wronguser.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        public void reset_wrongPassword()
        {
            lbl_wrongpass.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

    }
}
