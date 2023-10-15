namespace Gestion_Escolar
{
    partial class GestiondeCursos
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
            lstProfesores = new ListBox();
            lstCursosOfrecidos = new ListBox();
            btnAsignarProfesor = new Button();
            txtDescripcionCurso = new TextBox();
            txtCodigoCurso = new TextBox();
            btnRegistrarCurso = new Button();
            txtNombreCurso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstProfesores
            // 
            lstProfesores.FormattingEnabled = true;
            lstProfesores.ItemHeight = 15;
            lstProfesores.Location = new Point(475, 231);
            lstProfesores.Name = "lstProfesores";
            lstProfesores.Size = new Size(252, 109);
            lstProfesores.TabIndex = 15;
            lstProfesores.SelectedIndexChanged += lstProfesores_SelectedIndexChanged;
            // 
            // lstCursosOfrecidos
            // 
            lstCursosOfrecidos.FormattingEnabled = true;
            lstCursosOfrecidos.ItemHeight = 15;
            lstCursosOfrecidos.Location = new Point(74, 231);
            lstCursosOfrecidos.Name = "lstCursosOfrecidos";
            lstCursosOfrecidos.Size = new Size(339, 109);
            lstCursosOfrecidos.TabIndex = 14;
            lstCursosOfrecidos.SelectedIndexChanged += lstCursosOfrecidos_SelectedIndexChanged;
            // 
            // btnAsignarProfesor
            // 
            btnAsignarProfesor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsignarProfesor.Location = new Point(542, 364);
            btnAsignarProfesor.Name = "btnAsignarProfesor";
            btnAsignarProfesor.Size = new Size(134, 48);
            btnAsignarProfesor.TabIndex = 13;
            btnAsignarProfesor.Text = "Agregar Profesor";
            btnAsignarProfesor.UseVisualStyleBackColor = true;
            btnAsignarProfesor.Click += btnAsignarProfesor_Click;
            // 
            // txtDescripcionCurso
            // 
            txtDescripcionCurso.Location = new Point(258, 177);
            txtDescripcionCurso.Name = "txtDescripcionCurso";
            txtDescripcionCurso.Size = new Size(127, 23);
            txtDescripcionCurso.TabIndex = 12;
            // 
            // txtCodigoCurso
            // 
            txtCodigoCurso.Location = new Point(258, 121);
            txtCodigoCurso.Name = "txtCodigoCurso";
            txtCodigoCurso.Size = new Size(127, 23);
            txtCodigoCurso.TabIndex = 11;
            // 
            // btnRegistrarCurso
            // 
            btnRegistrarCurso.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarCurso.Location = new Point(163, 364);
            btnRegistrarCurso.Name = "btnRegistrarCurso";
            btnRegistrarCurso.Size = new Size(129, 48);
            btnRegistrarCurso.TabIndex = 10;
            btnRegistrarCurso.Text = "Agregar Curso";
            btnRegistrarCurso.UseVisualStyleBackColor = true;
            btnRegistrarCurso.Click += btnRegistrarCurso_Click;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(258, 63);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(127, 23);
            txtNombreCurso.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 63);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre del Curso";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 121);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 17;
            label2.Text = "Codigo del Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 177);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 18;
            label3.Text = "Descripcion del Curso";
            // 
            // GestiondeCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstProfesores);
            Controls.Add(lstCursosOfrecidos);
            Controls.Add(btnAsignarProfesor);
            Controls.Add(txtDescripcionCurso);
            Controls.Add(txtCodigoCurso);
            Controls.Add(btnRegistrarCurso);
            Controls.Add(txtNombreCurso);
            Name = "GestiondeCursos";
            Text = "Gestion de Cursos";
            Load += GestiondeCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProfesores;
        private ListBox lstCursosOfrecidos;
        private Button btnAsignarProfesor;
        private TextBox txtDescripcionCurso;
        private TextBox txtCodigoCurso;
        private Button btnRegistrarCurso;
        private TextBox txtNombreCurso;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}