﻿using System;
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
    public partial class Continuar2 : Form
    {
        public static string[] possibility1 = new string[4];
        public static string[] possibility2 = new string[4];
        public static string[] result1Return = new string[4];
        public static string condition1, condition2, stringOperators, condition1value, condition2value, stringPossibility1, stringPossibility2;

        private void Voltar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Continuar2_Load(object sender, EventArgs e)
        {

        }

        public Continuar2(string[] _result1Return, string _stringPossibility1)
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                possibility1[i] = _result1Return[i];
            }
            stringPossibility1 = _stringPossibility1;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            
            //Possibilidade dois

            if (srbp.Checked)
            {
                stringPossibility2 = "p";
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.p2[i];
                }
            }
            else if (srbq.Checked)
            {
                stringPossibility2 = "q";
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.q2[i];
                }
            }
            else if (srbnp.Checked)
            {
                stringPossibility2 = "~p";
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.np2[i];
                }
            }
            else if (srbnq.Checked)
            {
                stringPossibility2 = "~q";
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.nq2[i];
                }
            }
            else
            {
                stringPossibility2 = "p";
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.p2[i];
                }
            }

            //Calculando Resultados


            if (rbConjuncao.Checked)
            {
                stringOperators = "^";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            else if (rbDisjuncao.Checked)
            {
                stringOperators = "v";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.or(condition1value, condition2value);
                }
            }
            else if (rbDisjuncaoExclusiva.Checked)
            {
                stringOperators = "v_";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.xor(condition1value, condition2value);
                }
            }
            else if (rbCondicional.Checked)
            {
                stringOperators = "->";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.ifthen(condition1value, condition2value);
                }
            }
            else if (rbBicondicional.Checked)
            {
                stringOperators = "<->";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.ifonlyif(condition1value, condition2value);
                }
            }
            else
            {
                stringOperators = "^";
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            var resultado2 = new Resultado2(possibility1, possibility2, result1Return, stringOperators, stringPossibility1, stringPossibility2);
            resultado2.Show();
            this.Hide();
        }
    }
}
