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
    public partial class Continuar3 : Form
    {
        public static string[] possibility1 = new string[8];
        public static string[] possibility2 = new string[8];
        public static string[] result3Return = new string[8];
        public static string condition1, condition2, stringOperators, condition1value, condition2value, stringPossibility1, stringPossibility2;

        private void Voltar_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        public Continuar3(string[] _result3Return, string _stringPossibility1)
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                possibility1[i] = _result3Return[i];
            }
            stringPossibility1 = _stringPossibility1;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (srbp.Checked)
            {
                stringPossibility2 = "p";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.p3[i];
                }
            }
            else if (srbq.Checked)
            {
                stringPossibility2 = "q";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.q3[i];
                }
            }
            else if (srbnp.Checked)
            {
                stringPossibility2 = "~p";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.np3[i];
                }
            }
            else if (srbnq.Checked)
            {
                stringPossibility2 = "~q";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.nq3[i];
                }
            }
            else if (srbr.Checked)
            {
                stringPossibility2 = "r";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.r3[i];
                }
            }
            else if (srbnr.Checked)
            {
                stringPossibility2 = "~r";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.nr3[i];
                }
            }
            else
            {
                stringPossibility2 = "p";
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.p3[i];
                }
            }

            // Calculando

            if (rbConjuncao.Checked)
            {
                stringOperators = "^";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            else if (rbDisjuncao.Checked)
            {
                stringOperators = "v";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.or(condition1value, condition2value);
                }
            }
            else if (rbDisjuncaoExclusiva.Checked)
            {
                stringOperators = "v_";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.xor(condition1value, condition2value);
                }
            }
            else if (rbCondicional.Checked)
            {
                stringOperators = "->";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.ifthen(condition1value, condition2value);
                }
            }
            else if (rbBicondicional.Checked)
            {
                stringOperators = "<->";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.ifonlyif(condition1value, condition2value);
                }
            }
            else
            {
                stringOperators = "^";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result3Return[k] = Operations.and(condition1value, condition2value);
                }
            }

            //Mostrar result

            var resultado3 = new Resultado3(possibility1, possibility2, result3Return, stringOperators, stringPossibility1, stringPossibility2);
            resultado3.Show();
            this.Hide();
        }
    }
}
