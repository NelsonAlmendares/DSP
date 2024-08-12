namespace Catedra1
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private const string CsvFilePath = "C:\\Users\\nelso\\OneDrive\\Escritorio\\Universidad Don Bosco\\DSP\\Catedra1\\Catedra1\\users.csv";

        private bool ValidateCredentials(string username, string password)
        {
            try
            {
                var lines = File.ReadAllLines(CsvFilePath);

                foreach (var line in lines.Skip(1)) // Skip header line
                {
                    var values = line.Split(',');

                    if (values.Length == 2)
                    {
                        string csvUsername = values[0];
                        string csvPassword = values[1];

                        if (csvUsername.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                            csvPassword.Equals(password))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }

            return false;
        }

        void Registro()
        {
            string username = txt_user.Text;
            string password = mskTxtContra.Text;

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Login successful!");
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btn_registerUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
        }
    }
}
