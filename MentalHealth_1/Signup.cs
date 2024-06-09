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
           Dashboard form3 = new Dashboard();
            form3.ShowDialog();
        }
    }
}
