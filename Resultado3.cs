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
    public partial class Resultado3 : Form
    {
        public static string[] possibility1 = new string[8];
        public static string[] possibility2 = new string[8];
        public static string[] result3Return = new string[8];
        public static string stringOperators, stringPossibility1, stringPossibility2, strResult;

        public Resultado3(string[] _possibility1, string[] _possibility2, string[] _result3Return, string _stringOperators, string _stringPossibility1, string _stringPossibility2)
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                possibility1[i] = _possibility1[i];
            }

            for (int i = 0; i < 8; i++)
            {
                possibility2[i] = _possibility2[i];
            }

            for (int i = 0; i < 8; i++)
            {
                result3Return[i] = _result3Return[i];
            }

            stringOperators = _stringOperators;
            stringPossibility1 = _stringPossibility1;
            stringPossibility2 = _stringPossibility2;

            ShowResult();
        }

        public void ShowResult()
        {
            lblP11.Text = possibility1[0];
            lblP12.Text = possibility1[1];
            lblP13.Text = possibility1[2];
            lblP14.Text = possibility1[3];
            lblP15.Text = possibility1[4];
            lblP16.Text = possibility1[5];
            lblP17.Text = possibility1[6];
            lblP18.Text = possibility1[7];

            lblP21.Text = possibility2[0];
            lblP22.Text = possibility2[1];
            lblP23.Text = possibility2[2];
            lblP24.Text = possibility2[3];
            lblP25.Text = possibility2[4];
            lblP26.Text = possibility2[5];
            lblP27.Text = possibility2[6];
            lblP28.Text = possibility2[7];

            lblR1.Text = result3Return[0];
            lblR2.Text = result3Return[1];
            lblR3.Text = result3Return[2];
            lblR4.Text = result3Return[3];
            lblR5.Text = result3Return[4];
            lblR6.Text = result3Return[5];
            lblR7.Text = result3Return[6];
            lblR8.Text = result3Return[7];

            lblNome1.Text = stringPossibility1;
            lblNome2.Text = stringPossibility2;
            strResult = "(" + stringPossibility1 + " " + stringOperators + " " + stringPossibility2 + ")";
            lblNomeResult.Text = strResult;
        }

        private void Resultado3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblR5_Click(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            var Continuar3 = new Continuar3(result3Return, strResult);
            Continuar3.Show();
            this.Hide();
        }
    }
}
