namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            btnGuardarMascotas = new Button();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            btnLeerMascotas = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(308, 112);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(97, 50);
            btnGuardarMascotas.TabIndex = 15;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(22, 150);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(49, 23);
            txtEdad.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 132);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(22, 103);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(124, 23);
            txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "Raza";
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(308, 63);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(97, 37);
            btnLeerMascotas.TabIndex = 10;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 36);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 16;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(171, 63);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(120, 154);
            lstMascotas.TabIndex = 17;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(22, 189);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(124, 28);
            btnNuevaMascota.TabIndex = 19;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(429, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(308, 178);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(97, 39);
            btnExaminar.TabIndex = 21;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 250);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(btnLeerMascotas);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarMascotas;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private Button btnLeerMascotas;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}