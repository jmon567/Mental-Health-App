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
    public partial class JournalTable : Form
    {
        public JournalTable()
        {
            InitializeComponent();
            journalData.DataSource = Form_Journal.datatable;




        }
    }
}
