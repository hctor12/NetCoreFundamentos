namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            label1 = new Label();
            lblTiempo = new Label();
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(47, 61);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(547, 270);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 37);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 1;
            label1.Text = "Copie texto para trabajar:";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = Color.Red;
            lblTiempo.Location = new Point(47, 344);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(52, 21);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "label2";
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(83, 389);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(185, 49);
            btnInvertirString.TabIndex = 3;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(334, 389);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(185, 49);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(lblTiempo);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Label lblTiempo;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
    }
}