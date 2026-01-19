namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtNombre = new TextBox();
            btnLeerClase = new Button();
            txtRaza = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            btnGuardarClase = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(194, 46);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(97, 37);
            btnLeerClase.TabIndex = 2;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(36, 103);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(124, 23);
            txtRaza.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(36, 150);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(49, 23);
            txtEdad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 132);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(194, 95);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(97, 37);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "Guardar clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 200);
            Controls.Add(btnGuardarClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(btnLeerClase);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnLeerClase;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Button btnGuardarClase;
    }
}