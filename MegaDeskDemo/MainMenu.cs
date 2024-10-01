using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenViewQuotes(object sender, EventArgs e)
        {
            AddQuote viewQuotes = new AddQuote();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }
    }
}
