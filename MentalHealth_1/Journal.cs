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
using System.Data.Entity.Migrations.Model;

namespace MentalHealth_1
{

    public partial class Form_Journal : Form
    {
        public journalentry currententry;
        public static List<journalentry> all_entries = new List<journalentry>();
        public static DataTable datatable = new DataTable();
        public Form_Journal()
        {
            InitializeComponent();
        }

        private void Load_Data ()
        {

            // journalentry test = new journalentry("0","jack","Hiya", 1, 3,3,3,3,3);
            //test.mood.

            using (var connection = new SQLiteConnection("Data Source=\\Users\\jmon4\\OneDrive\\Desktop\\MS539_VSCode\\Mental Health App\\MentalHealth_1\\MentalHealthDatabase.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT *
                    FROM [Journal Entry]
                ";
                //command.Parameters.AddWithValue("$id", 1);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(datatable);
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int happy = reader.GetInt32(1);
                        int depressed = reader.GetInt32(2);
                        int motivation = reader.GetInt32(3);
                        int anxiety = reader.GetInt32(4);
                        int contentment = reader.GetInt32(5);
                        string entry = reader.GetString(6);
                        string time = reader.GetString(7);
                        string name = reader.GetString(8);
                        // var name = reader.GetString(0);
                        //var journaltime = reader.GetString(1);
                        //this.currententry = new journalentry(id, happy, depressed, motivation, anxiety, contentment, entry, time, name);
                        all_entries.Add(new journalentry(id, happy, depressed, motivation, anxiety, contentment, entry, time, name));
                        
                    }

                    MessageBox.Show("Finished");
                }
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string user = textBox_username.Text;
            string content = richTextBox_journal.Text;







            this.currententry = new journalentry(content, user);
            using (var connection = new SQLiteConnection("Data Source=\\Users\\jmon4\\OneDrive\\Desktop\\MS539_VSCode\\Mental Health App\\MentalHealth_1\\MentalHealthDatabase.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO [Journal Entry]
                    (Happy, Depressed, Motivation, Anxiety, Contentment, JournalEntry, User)
                    VALUES ($happy,$depressed, $motivation, $anxiety, $contentment, $journalentry, $user)
                ";
                command.Parameters.AddWithValue("happy", currententry.mood.Happy);
                command.Parameters.AddWithValue("depressed", currententry.mood.Depressed);
                command.Parameters.AddWithValue("motivation", currententry.mood.Motivation);
                command.Parameters.AddWithValue("anxiety", currententry.mood.Anxiety);
                command.Parameters.AddWithValue("contentment", currententry.mood.Contentment);
                command.Parameters.AddWithValue("journalentry", currententry.JournalEntry);
                command.Parameters.AddWithValue("user", currententry.User);
                try
                {
                    command.ExecuteNonQuery();
                    currententry.ID = (int) connection.LastInsertRowId;
                    MessageBox.Show("ID is" + currententry.ID);
                    
                }
                catch (Exception ex) 
                {
                throw new Exception(ex.Message);
                }
                


            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_journal.Text = "";
        }

        private void PriviousEntries_Click(object sender, EventArgs e)
        {
            Load_Data();
            JournalTable journalTable = new JournalTable();
            journalTable.ShowDialog();
            
        }
    }
    public class journalentry
    {
        public string JournalTime { get; set; }
        public string User { get; set; }
        public string JournalEntry { get; set; }
        public int ID { get; set; }

        public Mood mood { get; set; }
        public journalentry(int ID, int happy, int depressed, int motivation,
            int anxiety, int contentment, string journalentry, string journaltime, string user)
        {
            this.ID = ID;
            this.JournalEntry = journalentry;
            this.JournalTime = journaltime;
            this.User = user;
            this.mood = new Mood(contentment, anxiety, motivation, depressed, happy);

        }
        public journalentry(string journalentry, string user) 
        {
            this.ID = -1;
            this.JournalEntry = journalentry;
            this.JournalTime = "";
            this.User = user;
            this.mood = new Mood(0,0,0,0,0);

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
