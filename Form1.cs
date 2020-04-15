using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOfRandom_Click(object sender, EventArgs e)
        {
            number = rnd.Next(0, 100);
            textBox1.Text = number.ToString();
        }
    }
}
