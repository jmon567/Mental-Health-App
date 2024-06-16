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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox_meditation_Click(object sender, EventArgs e)
        {
            Meditation meditation = new Meditation();
            meditation.ShowDialog();
        }

        private void pictureBox_mood_Click(object sender, EventArgs e)
        {
            MoodTracker moodTracker = new MoodTracker();
            moodTracker.ShowDialog();
        }

        private void pictureBox_journal_Click(object sender, EventArgs e)
        {
            Form journal = new Form_Journal();
            journal.ShowDialog();
        }
    }
}
