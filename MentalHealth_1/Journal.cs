using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using System.Data.SQLite;

namespace MentalHealth_1
{

    public partial class Form_Journal : Form
    {

        public Form_Journal()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {

            // journalentry test = new journalentry("0","jack","Hiya", 1, 3,3,3,3,3);
            //test.mood.

            using (var connection = new SQLiteConnection("Data Source=MentalHealthDatabase.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT User
                    FROM [Journal Entry]
                    WHERE ID = $id
                ";
                command.Parameters.AddWithValue("$id", 1);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);

                        Console.WriteLine($"Hello, {name}!");
                    }
                }
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

    }
    public class journalentry
    {
        public string JournalTime { get; set; }
        public string User { get; set; }
        public string JournalEntry { get; set; }
        public int ID { get; set; }

        public Mood mood { get; set; }
        public journalentry(string journaltime, string user, string journalentry, int ID,
            int contentment, int anxiety, int motivation, int depressed, int happy)
        {
            this.ID = ID;
            this.JournalEntry = journalentry;
            this.JournalTime = journaltime;
            this.User = user;
            this.mood = new Mood(contentment, anxiety, motivation, depressed, happy);

        }
    }

    public class Mood
    {
        public int Contentment { get; set; }
        public int Anxiety { get; set; }
        public int Motivation { get; set; }
        public int Depressed { get; set; }
        public int Happy { get; set; }

        public Mood(int contentment, int anxiety, int motivation, int depressed, int happy)
        {
            this.Contentment = contentment;
            this.Anxiety = anxiety;
            this.Motivation = motivation;
            this.Depressed = depressed;
            this.Happy = happy;
        }




    } 

}
