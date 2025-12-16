namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            label1 = new Label();
            btnGenerarNumeros = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtSumaPares = new TextBox();
            txtSumaImpares = new TextBox();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(23, 55);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.SelectionMode = SelectionMode.MultiExtended;
            lstNumeros.Size = new Size(137, 169);
            lstNumeros.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 11;
            label1.Text = "Números";
            // 
            // btnGenerarNumeros
            // 
            btnGenerarNumeros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarNumeros.Location = new Point(202, 28);
            btnGenerarNumeros.Name = "btnGenerarNumeros";
            btnGenerarNumeros.Size = new Size(148, 36);
            btnGenerarNumeros.TabIndex = 13;
            btnGenerarNumeros.Text = "Generar números";
            btnGenerarNumeros.UseVisualStyleBackColor = true;
            btnGenerarNumeros.Click += btnGenerarNumeros_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarDatos.Location = new Point(202, 70);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(148, 32);
            btnMostrarDatos.TabIndex = 14;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(182, 119);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 15;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(182, 161);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 16;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(182, 203);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 17;
            label4.Text = "Impares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(250, 121);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 18;
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(250, 161);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(100, 23);
            txtSumaPares.TabIndex = 19;
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(250, 205);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(100, 23);
            txtSumaImpares.TabIndex = 20;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 259);
            Controls.Add(txtSumaImpares);
            Controls.Add(txtSumaPares);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarNumeros);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Label label1;
        private Button btnGenerarNumeros;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtSumaPares;
        private TextBox txtSumaImpares;
    }
}