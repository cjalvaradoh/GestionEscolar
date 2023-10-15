namespace Gestion_Escolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 122);
            label1.Name = "label1";
            label1.Size = new Size(96, 29);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(305, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(162, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 208);
            label2.Name = "label2";
            label2.Size = new Size(136, 29);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(305, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 23);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 21);
            label3.Name = "label3";
            label3.Size = new Size(444, 55);
            label3.TabIndex = 4;
            label3.Text = "INICIO DE SESION";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(320, 312);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(131, 38);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(334, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 38);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnIngresar;
        private Button btnSalir;
    }
}