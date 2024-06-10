namespace MentalHealth_1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            //If username and password exist in current db
          Dashboard form3 = new Dashboard();
            form3.ShowDialog();
            this.Close();

            //else> error message "account not found". please enter a username and password


        }
    }
}
