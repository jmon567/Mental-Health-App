using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalHealth_1
{
    public partial class MoodTracker : Form
    {
        public MoodTracker()
        {
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard form3 = new Dashboard();
            form3.ShowDialog();
        }
    }
}
