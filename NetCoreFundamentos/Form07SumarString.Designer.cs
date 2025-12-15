namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            button1 = new Button();
            label1 = new Label();
            txtInput = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 75);
            button1.Name = "button1";
            button1.Size = new Size(177, 39);
            button1.TabIndex = 0;
            button1.Text = "Sumar números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 1;
            label1.Text = "Introduzca números";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(41, 46);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(177, 23);
            txtInput.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(41, 129);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 3;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 165);
            Controls.Add(lblResultado);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtInput;
        private Label lblResultado;
    }
}