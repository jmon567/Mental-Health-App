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

namespace MentalHealth_1
{

    public partial class Form_Journal : Form
    {
        public List<journalentry> journalentries = new List<journalentry>();
        public string currentDirectory = Directory.GetCurrentDirectory();
        public string jsonpath = Directory.GetCurrentDirectory() + "/Journal Data/journal.json";
        public Form_Journal()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {

           
            //richTextBox_journal.Text = json;
            this.journalentries = JsonSerializer.Deserialize<List<journalentry>>(File.ReadAllText (this.jsonpath));
            journalentry currententry = journalentries[0];

            richTextBox_journal.Text = currententry.Content;

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            journalentry pending = new journalentry("June 18th", "John", richTextBox_journal.Text);
            
            this.journalentries.Add(pending);
            //this.journalentries.ToString();
            string json = JsonSerializer.Serialize<List<journalentry>>(journalentries);
            //richTextBox_journal.Text = json;
            File.WriteAllText(this.jsonpath, json);
        }
        //Push element to end of array.(add to end of list) ---Convert to a json string through the json se
        //serializer. --write to textbox
    }
    public class journalentry
    {
        public string DateTime { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
        public journalentry(string datetime, string user, string content) 
        {
            this.DateTime = datetime;
            this.User = user;   
            this.Content = content;
        
        }
    }
}
