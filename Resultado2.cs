using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTabelaVerdade
{
    public partial class Resultado2 : Form
    {
        public static string[] possibility1 = new string[4];
        public static string[] possibility2 = new string[4];
        public static string[] result1Return = new string[4];
        public static string stringOperators, stringPossibility1, stringPossibility2, strResult;
        public Resultado2(string[] _possibility1, string[] _possibility2, string[] _result1Return, string _stringOperators, string _stringPossibility1, string _stringPossibility2)
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                possibility1[i] = _possibility1[i];
            }

            for (int i = 0; i < 4; i++)
            {
                possibility2[i] = _possibility2[i];
            }

            for (int i = 0; i < 4; i++)
            {
                result1Return[i] = _result1Return[i];
            }

            stringOperators = _stringOperators;
            stringPossibility1 = _stringPossibility1;
            stringPossibility2 = _stringPossibility2;

            ShowResult();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ShowResult()
        {
            lblP11.Text = possibility1[0];
            lblP12.Text = possibility1[1];
            lblP13.Text = possibility1[2];
            lblP14.Text = possibility1[3];

            lblP21.Text = possibility2[0];
            lblP22.Text = possibility2[1];
            lblP23.Text = possibility2[2];
            lblP24.Text = possibility2[3];

            lblR1.Text = result1Return[0];
            lblR2.Text = result1Return[1];
            lblR3.Text = result1Return[2];
            lblR4.Text = result1Return[3];

            lblNome1.Text = stringPossibility1;
            lblNome2.Text = stringPossibility2;
            strResult = "(" + stringPossibility1 + " " + stringOperators + " " + stringPossibility2 + ")";
            lblNomeResult.Text = strResult;
        }

        private void Resultado2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            var Continuar2 = new Continuar2(result1Return, strResult);
            Continuar2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblNome2_Click(object sender, EventArgs e)
        {

        }
    }
}
