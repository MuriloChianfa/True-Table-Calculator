namespace CalculadoraTabelaVerdade
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.rbp = new System.Windows.Forms.RadioButton();
            this.rbq = new System.Windows.Forms.RadioButton();
            this.rbnq = new System.Windows.Forms.RadioButton();
            this.rbnp = new System.Windows.Forms.RadioButton();
            this.GrupoPrimeiraPreposicao = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBicondicional = new System.Windows.Forms.RadioButton();
            this.rbCondicional = new System.Windows.Forms.RadioButton();
            this.rbDisjuncaoExclusiva = new System.Windows.Forms.RadioButton();
            this.rbDisjuncao = new System.Windows.Forms.RadioButton();
            this.rbConjuncao = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.srbp = new System.Windows.Forms.RadioButton();
            this.srbnp = new System.Windows.Forms.RadioButton();
            this.srbq = new System.Windows.Forms.RadioButton();
            this.srbnq = new System.Windows.Forms.RadioButton();
            this.Enviar = new System.Windows.Forms.Button();
            this.GrupoPrimeiraPreposicao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(396, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbp
            // 
            this.rbp.AutoSize = true;
            this.rbp.Location = new System.Drawing.Point(18, 34);
            this.rbp.Name = "rbp";
            this.rbp.Size = new System.Drawing.Size(33, 18);
            this.rbp.TabIndex = 1;
            this.rbp.TabStop = true;
            this.rbp.Text = "p";
            this.rbp.UseVisualStyleBackColor = true;
            // 
            // rbq
            // 
            this.rbq.AutoSize = true;
            this.rbq.Location = new System.Drawing.Point(18, 58);
            this.rbq.Name = "rbq";
            this.rbq.Size = new System.Drawing.Size(33, 18);
            this.rbq.TabIndex = 2;
            this.rbq.TabStop = true;
            this.rbq.Text = "q";
            this.rbq.UseVisualStyleBackColor = true;
            // 
            // rbnq
            // 
            this.rbnq.AutoSize = true;
            this.rbnq.Location = new System.Drawing.Point(55, 57);
            this.rbnq.Name = "rbnq";
            this.rbnq.Size = new System.Drawing.Size(40, 18);
            this.rbnq.TabIndex = 3;
            this.rbnq.TabStop = true;
            this.rbnq.Text = "~q";
            this.rbnq.UseVisualStyleBackColor = true;
            // 
            // rbnp
            // 
            this.rbnp.AutoSize = true;
            this.rbnp.Location = new System.Drawing.Point(55, 34);
            this.rbnp.Name = "rbnp";
            this.rbnp.Size = new System.Drawing.Size(40, 18);
            this.rbnp.TabIndex = 4;
            this.rbnp.TabStop = true;
            this.rbnp.Text = "~p";
            this.rbnp.UseVisualStyleBackColor = true;
            // 
            // GrupoPrimeiraPreposicao
            // 
            this.GrupoPrimeiraPreposicao.Controls.Add(this.rbp);
            this.GrupoPrimeiraPreposicao.Controls.Add(this.rbnp);
            this.GrupoPrimeiraPreposicao.Controls.Add(this.rbq);
            this.GrupoPrimeiraPreposicao.Controls.Add(this.rbnq);
            this.GrupoPrimeiraPreposicao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoPrimeiraPreposicao.Location = new System.Drawing.Point(15, 64);
            this.GrupoPrimeiraPreposicao.Name = "GrupoPrimeiraPreposicao";
            this.GrupoPrimeiraPreposicao.Size = new System.Drawing.Size(130, 100);
            this.GrupoPrimeiraPreposicao.TabIndex = 5;
            this.GrupoPrimeiraPreposicao.TabStop = false;
            this.GrupoPrimeiraPreposicao.Text = "Primeira proposição";
            this.GrupoPrimeiraPreposicao.Enter += new System.EventHandler(this.GrupoPrimeiraPreposicao_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBicondicional);
            this.groupBox2.Controls.Add(this.rbCondicional);
            this.groupBox2.Controls.Add(this.rbDisjuncaoExclusiva);
            this.groupBox2.Controls.Add(this.rbDisjuncao);
            this.groupBox2.Controls.Add(this.rbConjuncao);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(151, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operador Lógico";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbBicondicional
            // 
            this.rbBicondicional.AutoSize = true;
            this.rbBicondicional.Location = new System.Drawing.Point(6, 115);
            this.rbBicondicional.Name = "rbBicondicional";
            this.rbBicondicional.Size = new System.Drawing.Size(122, 18);
            this.rbBicondicional.TabIndex = 5;
            this.rbBicondicional.TabStop = true;
            this.rbBicondicional.Text = "↔ (Bicondicional)";
            this.rbBicondicional.UseVisualStyleBackColor = true;
            // 
            // rbCondicional
            // 
            this.rbCondicional.AutoSize = true;
            this.rbCondicional.Location = new System.Drawing.Point(6, 91);
            this.rbCondicional.Name = "rbCondicional";
            this.rbCondicional.Size = new System.Drawing.Size(112, 18);
            this.rbCondicional.TabIndex = 4;
            this.rbCondicional.TabStop = true;
            this.rbCondicional.Text = "→ (Condicional)";
            this.rbCondicional.UseVisualStyleBackColor = true;
            // 
            // rbDisjuncaoExclusiva
            // 
            this.rbDisjuncaoExclusiva.AutoSize = true;
            this.rbDisjuncaoExclusiva.Location = new System.Drawing.Point(6, 67);
            this.rbDisjuncaoExclusiva.Name = "rbDisjuncaoExclusiva";
            this.rbDisjuncaoExclusiva.Size = new System.Drawing.Size(164, 18);
            this.rbDisjuncaoExclusiva.TabIndex = 3;
            this.rbDisjuncaoExclusiva.TabStop = true;
            this.rbDisjuncaoExclusiva.Text = "v_ (Disjunção Exclusiva)";
            this.rbDisjuncaoExclusiva.UseVisualStyleBackColor = true;
            // 
            // rbDisjuncao
            // 
            this.rbDisjuncao.AutoSize = true;
            this.rbDisjuncao.Location = new System.Drawing.Point(6, 44);
            this.rbDisjuncao.Name = "rbDisjuncao";
            this.rbDisjuncao.Size = new System.Drawing.Size(106, 18);
            this.rbDisjuncao.TabIndex = 2;
            this.rbDisjuncao.TabStop = true;
            this.rbDisjuncao.Text = "v   (Disjunção)";
            this.rbDisjuncao.UseVisualStyleBackColor = true;
            // 
            // rbConjuncao
            // 
            this.rbConjuncao.AutoSize = true;
            this.rbConjuncao.Location = new System.Drawing.Point(6, 20);
            this.rbConjuncao.Name = "rbConjuncao";
            this.rbConjuncao.Size = new System.Drawing.Size(110, 18);
            this.rbConjuncao.TabIndex = 1;
            this.rbConjuncao.TabStop = true;
            this.rbConjuncao.Text = "^   (Conjunção)";
            this.rbConjuncao.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.srbp);
            this.groupBox3.Controls.Add(this.srbnp);
            this.groupBox3.Controls.Add(this.srbq);
            this.groupBox3.Controls.Add(this.srbnq);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(338, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segunda proposição";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // srbp
            // 
            this.srbp.AutoSize = true;
            this.srbp.Location = new System.Drawing.Point(18, 34);
            this.srbp.Name = "srbp";
            this.srbp.Size = new System.Drawing.Size(33, 18);
            this.srbp.TabIndex = 1;
            this.srbp.TabStop = true;
            this.srbp.Text = "p";
            this.srbp.UseVisualStyleBackColor = true;
            this.srbp.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // srbnp
            // 
            this.srbnp.AutoSize = true;
            this.srbnp.Location = new System.Drawing.Point(55, 34);
            this.srbnp.Name = "srbnp";
            this.srbnp.Size = new System.Drawing.Size(40, 18);
            this.srbnp.TabIndex = 4;
            this.srbnp.TabStop = true;
            this.srbnp.Text = "~p";
            this.srbnp.UseVisualStyleBackColor = true;
            // 
            // srbq
            // 
            this.srbq.AutoSize = true;
            this.srbq.Location = new System.Drawing.Point(18, 58);
            this.srbq.Name = "srbq";
            this.srbq.Size = new System.Drawing.Size(33, 18);
            this.srbq.TabIndex = 2;
            this.srbq.TabStop = true;
            this.srbq.Text = "q";
            this.srbq.UseVisualStyleBackColor = true;
            // 
            // srbnq
            // 
            this.srbnq.AutoSize = true;
            this.srbnq.Location = new System.Drawing.Point(55, 57);
            this.srbnq.Name = "srbnq";
            this.srbnq.Size = new System.Drawing.Size(40, 18);
            this.srbnq.TabIndex = 3;
            this.srbnq.TabStop = true;
            this.srbnq.Text = "~q";
            this.srbnq.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enviar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enviar.Location = new System.Drawing.Point(396, 185);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 7;
            this.Enviar.Text = "enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(483, 249);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrupoPrimeiraPreposicao);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora - 2 Variáveis";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GrupoPrimeiraPreposicao.ResumeLayout(false);
            this.GrupoPrimeiraPreposicao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbp;
        private System.Windows.Forms.RadioButton rbq;
        private System.Windows.Forms.RadioButton rbnq;
        private System.Windows.Forms.RadioButton rbnp;
        private System.Windows.Forms.GroupBox GrupoPrimeiraPreposicao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBicondicional;
        private System.Windows.Forms.RadioButton rbCondicional;
        private System.Windows.Forms.RadioButton rbDisjuncaoExclusiva;
        private System.Windows.Forms.RadioButton rbDisjuncao;
        private System.Windows.Forms.RadioButton rbConjuncao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton srbp;
        private System.Windows.Forms.RadioButton srbnp;
        private System.Windows.Forms.RadioButton srbq;
        private System.Windows.Forms.RadioButton srbnq;
        private System.Windows.Forms.Button Enviar;
    }
}