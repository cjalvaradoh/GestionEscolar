namespace Gestion_Escolar
{
    partial class ActualizarLista
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
            ListarProfesores = new Button();
            dataGridViewProfesores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            NumeroId = new DataGridViewTextBoxColumn();
            Actualizar = new Button();
            Volver = new Button();
            button2 = new Button();
            campoNumeroId = new TextBox();
            button12 = new Button();
            campoFechaNacimiento = new TextBox();
            campoDireccion = new TextBox();
            campoCorreo = new TextBox();
            campoTelefono = new TextBox();
            campoEspecialidad = new TextBox();
            campoApellido = new TextBox();
            campoNombre = new TextBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesores).BeginInit();
            SuspendLayout();
            // 
            // ListarProfesores
            // 
            ListarProfesores.Location = new Point(619, 107);
            ListarProfesores.Name = "ListarProfesores";
            ListarProfesores.Size = new Size(124, 44);
            ListarProfesores.TabIndex = 87;
            ListarProfesores.Text = "Listar los profesores guardados";
            ListarProfesores.UseVisualStyleBackColor = true;
            ListarProfesores.Click += ListarProfesores_Click;
            // 
            // dataGridViewProfesores
            // 
            dataGridViewProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfesores.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Especialidad, Telefono, Correo, Direccion, Fecha, NumeroId });
            dataGridViewProfesores.Location = new Point(127, 280);
            dataGridViewProfesores.Name = "dataGridViewProfesores";
            dataGridViewProfesores.RowTemplate.Height = 25;
            dataGridViewProfesores.Size = new Size(637, 150);
            dataGridViewProfesores.TabIndex = 86;
            dataGridViewProfesores.CellClick += dataGridViewProfesores_CellClick;
            dataGridViewProfesores.CellContentClick += dataGridViewProfesores_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Profesor";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido Profesor";
            Apellido.Name = "Apellido";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad Profesor";
            Especialidad.Name = "Especialidad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono Profesor";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo Electronico Profesor";
            Correo.Name = "Correo";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección Residencia Profesor";
            Direccion.Name = "Direccion";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha Nacimiento Profesor";
            Fecha.Name = "Fecha";
            // 
            // NumeroId
            // 
            NumeroId.HeaderText = "Numero Identificación Profesor";
            NumeroId.Name = "NumeroId";
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(619, 50);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(124, 23);
            Actualizar.TabIndex = 85;
            Actualizar.Text = "Guardar Edición";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(36, 357);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 23);
            Volver.TabIndex = 84;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 407);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 83;
            button2.Text = "salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoNumeroId
            // 
            campoNumeroId.Location = new Point(195, 236);
            campoNumeroId.Name = "campoNumeroId";
            campoNumeroId.Size = new Size(221, 23);
            campoNumeroId.TabIndex = 82;
            // 
            // button12
            // 
            button12.Location = new Point(36, 171);
            button12.Name = "button12";
            button12.Size = new Size(140, 28);
            button12.TabIndex = 81;
            button12.Text = "Dirección de Residencia";
            button12.UseVisualStyleBackColor = true;
            // 
            // campoFechaNacimiento
            // 
            campoFechaNacimiento.Location = new Point(195, 208);
            campoFechaNacimiento.Name = "campoFechaNacimiento";
            campoFechaNacimiento.Size = new Size(221, 23);
            campoFechaNacimiento.TabIndex = 80;
            // 
            // campoDireccion
            // 
            campoDireccion.Location = new Point(195, 171);
            campoDireccion.Name = "campoDireccion";
            campoDireccion.Size = new Size(221, 23);
            campoDireccion.TabIndex = 79;
            // 
            // campoCorreo
            // 
            campoCorreo.Location = new Point(193, 142);
            campoCorreo.Name = "campoCorreo";
            campoCorreo.Size = new Size(223, 23);
            campoCorreo.TabIndex = 78;
            // 
            // campoTelefono
            // 
            campoTelefono.Location = new Point(127, 107);
            campoTelefono.Name = "campoTelefono";
            campoTelefono.Size = new Size(224, 23);
            campoTelefono.TabIndex = 77;
            // 
            // campoEspecialidad
            // 
            campoEspecialidad.Location = new Point(127, 78);
            campoEspecialidad.Name = "campoEspecialidad";
            campoEspecialidad.Size = new Size(224, 23);
            campoEspecialidad.TabIndex = 76;
            // 
            // campoApellido
            // 
            campoApellido.Location = new Point(127, 49);
            campoApellido.Name = "campoApellido";
            campoApellido.Size = new Size(224, 23);
            campoApellido.TabIndex = 75;
            // 
            // campoNombre
            // 
            campoNombre.Location = new Point(127, 20);
            campoNombre.Name = "campoNombre";
            campoNombre.Size = new Size(224, 23);
            campoNombre.TabIndex = 74;
            // 
            // button11
            // 
            button11.Location = new Point(36, 236);
            button11.Name = "button11";
            button11.Size = new Size(151, 23);
            button11.TabIndex = 73;
            button11.Text = "Numero Identificación";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(36, 207);
            button10.Name = "button10";
            button10.Size = new Size(128, 23);
            button10.TabIndex = 72;
            button10.Text = "Fecha Nacimiento";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(36, 137);
            button9.Name = "button9";
            button9.Size = new Size(128, 23);
            button9.TabIndex = 71;
            button9.Text = "Correo Electronico";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(36, 108);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 70;
            button8.Text = "Telefono";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(36, 79);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 69;
            button7.Text = "Especialidad";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(36, 50);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 68;
            button6.Text = "Apellido";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 21);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 67;
            button5.Text = "Nombre";
            button5.UseVisualStyleBackColor = true;
            // 
            // ActualizarLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.yellow_halftone_texture_background_vector;
            ClientSize = new Size(800, 450);
            Controls.Add(ListarProfesores);
            Controls.Add(dataGridViewProfesores);
            Controls.Add(Actualizar);
            Controls.Add(Volver);
            Controls.Add(button2);
            Controls.Add(campoNumeroId);
            Controls.Add(button12);
            Controls.Add(campoFechaNacimiento);
            Controls.Add(campoDireccion);
            Controls.Add(campoCorreo);
            Controls.Add(campoTelefono);
            Controls.Add(campoEspecialidad);
            Controls.Add(campoApellido);
            Controls.Add(campoNombre);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Name = "ActualizarLista";
            Text = "ActualizarLista";
            Load += ActualizarLista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ListarProfesores;
        private DataGridView dataGridViewProfesores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn NumeroId;
        private Button Actualizar;
        private Button Volver;
        private Button button2;
        private TextBox campoNumeroId;
        private Button button12;
        private TextBox campoFechaNacimiento;
        private TextBox campoDireccion;
        private TextBox campoCorreo;
        private TextBox campoTelefono;
        private TextBox campoEspecialidad;
        private TextBox campoApellido;
        private TextBox campoNombre;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}