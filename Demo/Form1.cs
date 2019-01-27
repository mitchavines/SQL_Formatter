using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        private SQL_Formatter.Formatter formatter = new SQL_Formatter.Formatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cmdFormat_Click(object sender, EventArgs e)
        { txtFormatted.Text = formatter.Format(txtSource.Text, txtOptions.Text); }

        private void txtExit_Click(object sender, EventArgs e)
        { Close(); }

    }
}
