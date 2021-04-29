using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace True_Table_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Visiting The Owners Of Project
            System.Diagnostics.Process.Start("https://github.com/MuriloChianfa");
            System.Diagnostics.Process.Start("https://github.com/Kamikzr");
            //Debug.Logger("Github Of Owners Opened");
        }

        private void LabelVersions_Click(object sender, EventArgs e)
        {
            //Visiting The Versions Of Project
            System.Diagnostics.Process.Start("https://github.com/MuriloChianfa/True_Table_Calculator");
            //Debug.Logger("Versions Of The Project Opened");
        }
    }
}
