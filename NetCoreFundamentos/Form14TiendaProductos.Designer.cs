namespace NetCoreFundamentos
{
    partial class Form14TiendaProductos
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
            label2 = new Label();
            label3 = new Label();
            txtProducto = new TextBox();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(379, 31);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Almacén";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(28, 55);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(127, 23);
            txtProducto.TabIndex = 3;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(172, 55);
            lstTienda.Name = "lstTienda";
            lstTienda.SelectionMode = SelectionMode.MultiExtended;
            lstTienda.Size = new Size(120, 154);
            lstTienda.TabIndex = 4;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(379, 55);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 154);
            lstAlmacen.TabIndex = 5;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F);
            btnNuevo.Location = new Point(28, 94);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(127, 34);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(28, 134);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 12F);
            btnBorrarTodo.Location = new Point(28, 175);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(127, 34);
            btnBorrarTodo.TabIndex = 8;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Font = new Font("Segoe UI", 9F);
            btnSeleccion.Location = new Point(298, 83);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI", 12F);
            btnTodos.Location = new Point(298, 124);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 44);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Font = new Font("Segoe UI", 12F);
            btnSubir.Location = new Point(505, 94);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 34);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Font = new Font("Segoe UI", 12F);
            btnBajar.Location = new Point(505, 134);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 34);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 238);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
    }
}