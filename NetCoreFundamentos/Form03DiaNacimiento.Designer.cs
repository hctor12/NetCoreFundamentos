namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            lblDia = new Label();
            lblMes = new Label();
            lblAnio = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(39, 44);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(39, 90);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(39, 138);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 2;
            lblAnio.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(95, 39);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(95, 90);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(95, 138);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(39, 186);
            button1.Name = "button1";
            button1.Size = new Size(156, 45);
            button1.TabIndex = 6;
            button1.Text = "Mostrar día";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(39, 263);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(258, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "El día de la semana es LUNES";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 328);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblAnio);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAnio;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Button button1;
        private Label lblResultado;
    }
}