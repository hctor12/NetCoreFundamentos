namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            label1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(29, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(29, 98);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label2";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(27, 131);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(102, 51);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(12, 188);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(133, 51);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(27, 245);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(102, 51);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(128, 255, 128);
            lblRaton.Location = new Point(170, 107);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(271, 158);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "label2";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 27);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "Sólo números";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 56);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Sólo letras";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 317);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}