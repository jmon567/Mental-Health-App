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

namespace MentalHealth_1
{
    public class journalentry
    {
        public string DateTime { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
    }
    public partial class Form_Journal : Form
    {
        public Form_Journal()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
           
            string currentDirectory = Directory.GetCurrentDirectory();
            string json = File.ReadAllText(currentDirectory + "/Journal Data/journal.json");
            //richTextBox_journal.Text = json;
            List<journalentry> journalentries = JsonSerializer.Deserialize<List<journalentry>>(json);
            journalentry currententry = journalentries[0];

            richTextBox_journal.Text = currententry.Content;

        }
        //Push element to end of array.(add to end of list) ---Convert to a json string through the json se
        //serializer. --write to textbox
    }
}
