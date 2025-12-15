namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            radioButton1 = new RadioButton();
            rdbAnyos = new RadioButton();
            txtIncremento = new TextBox();
            label2 = new Label();
            btnIncrementar = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(40, 57);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(390, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(40, 95);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(119, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar Formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(40, 120);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Meses";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(40, 170);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(236, 144);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 147);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Incremento";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(162, 173);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(174, 23);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 216);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(40, 244);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(390, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 311);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(label2);
            Controls.Add(txtIncremento);
            Controls.Add(rdbAnyos);
            Controls.Add(radioButton1);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton radioButton1;
        private RadioButton rdbAnyos;
        private TextBox txtIncremento;
        private Label label2;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}