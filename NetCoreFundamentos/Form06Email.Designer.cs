namespace NetCoreFundamentos
{
    partial class Form06Email
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
            txtEmail = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca email";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(56, 122);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(56, 85);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(80, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Comprobar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form06Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 183);
            Controls.Add(btnValidar);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "Form06Email";
            Text = "Form06Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Label lblResultado;
        private Button btnValidar;
    }
}