using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        //Error checing of numericUpDowns//
        private void numericUpDown_Happiness_Validating(object sender, CancelEventArgs e)
        {
            int happiness = (int)numericUpDown_Happiness.Value;
            if (numericUpDown_Happiness.Value > 5)
            {
                errorProvider1.SetError(numericUpDown_Happiness, "Max input of 5");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(numericUpDown_Happiness, "");
                int happinessValidated = (int)numericUpDown_Happiness.Value;
            }
        }

        private void numericUpDown_motivation_Validating(object sender, CancelEventArgs e)
        {
            int motivation = (int)numericUpDown_motivation.Value;
            if (numericUpDown_motivation.Value > 5)
            {
                errorProvider1.SetError(numericUpDown_motivation, "Max input of 5");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(numericUpDown_motivation, "");
                int motivationValidated = (int)numericUpDown_motivation.Value;
            }
        }

        private void numericUpDown_depression_Validating(object sender, CancelEventArgs e)
        {
            int depression = (int)numericUpDown_depression.Value;
            if (numericUpDown_depression.Value > 5)
            {
                errorProvider1.SetError(numericUpDown_depression, "Max input of 5");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(numericUpDown_depression, "");
                int depressionValidated = (int)numericUpDown_depression.Value;
            }
        }

        private void numericUpDown_anxiety_Validating(object sender, CancelEventArgs e)
        {
            int anxiety = (int)numericUpDown_anxiety.Value;
            if (numericUpDown_anxiety.Value > 5)
            {
                errorProvider1.SetError(numericUpDown_anxiety, "Max input of 5");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(numericUpDown_anxiety, "");
                int anxietyValidated = (int)numericUpDown_anxiety.Value;
            }
        }

        private void numericUpDown_peace_Validating(object sender, CancelEventArgs e)
        {
            int peace = (int)numericUpDown_peace.Value;
            if (numericUpDown_peace.Value > 5)
            {
                errorProvider1.SetError(numericUpDown_peace, "Max input of 5");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(numericUpDown_peace, "");
                int peaceValidated = (int)numericUpDown_peace.Value;
            }
            //end of checking numeric upDowns//
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int happinessValidated = (int)numericUpDown_Happiness.Value;
            int motivationValidated = (int)numericUpDown_motivation.Value;
            int depressionValidated = (int)numericUpDown_depression.Value;
            int anxietyValidated = (int)numericUpDown_anxiety.Value;
            int peaceValidated = (int)numericUpDown_peace.Value;

            //-----Connect to the SQL database------//
            //string connectionString = "" 

            //------Prepare the SQL statement------//
            //string sql = "INSERT INTO mood (Happiness, Motivation, Depression, Anxiety, Contentment) VALUES (@Happiness, @Motivation, @Depression, @Anxiety, @Contentment)";
            // SqlCommand command = new SqlCommand(sql, connection);

            //------Add parameters to prevent SQL injection-----//
           /* command.Parameters.AddWithValue("@Happiness", happiness);
            command.Parameters.AddWithValue("@Motivation", motivation);
            command.Parameters.AddWithValue("@Depression", depression);
            command.Parameters.AddWithValue("@Anxiety", anxiety);
            command.Parameters.AddWithValue("@Contentment", contentment);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Mood data saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data:");
            } 
           */

        }
    }
}
