using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adofai.gg_level
{
    public partial class Form1 : Form
    {
        Random level = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void levelBtn_Click(object sender, EventArgs e)
        {
            int level2 = level.Next(1, 4734);
            levelcur.Text = "adofai.gg/" + level2;
        }
    }
}
