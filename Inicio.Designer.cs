namespace C____BUSQUEDA
{
    partial class Inicio
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
            label2 = new Label();
            label3 = new Label();
            codigo = new TextBox();
            password = new TextBox();
            login = new Button();
            EXIT = new Button();
            signin = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 118);
            label1.Name = "label1";
            label1.Size = new Size(924, 53);
            label1.TabIndex = 0;
            label1.Text = "ALGORITMOS DE BUSQUEDA DE CADENAS EN C#";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 241);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 363);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // codigo
            // 
            codigo.Location = new Point(478, 300);
            codigo.Name = "codigo";
            codigo.Size = new Size(428, 39);
            codigo.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(478, 416);
            password.Name = "password";
            password.Size = new Size(428, 39);
            password.TabIndex = 4;
            // 
            // login
            // 
            login.Location = new Point(574, 510);
            login.Name = "login";
            login.Size = new Size(243, 55);
            login.TabIndex = 5;
            login.Text = "Iniciar Sesión";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // EXIT
            // 
            EXIT.Location = new Point(1023, 768);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(246, 46);
            EXIT.TabIndex = 6;
            EXIT.Text = "Cerrar programa";
            EXIT.UseVisualStyleBackColor = true;
            EXIT.Click += label1_Click;
            // 
            // signin
            // 
            signin.AutoSize = true;
            signin.Location = new Point(607, 642);
            signin.Name = "signin";
            signin.Size = new Size(172, 32);
            signin.TabIndex = 8;
            signin.TabStop = true;
            signin.Text = "Registrate aquí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 593);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 9;
            label4.Text = "¿No tienes cuenta?";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1370, 875);
            Controls.Add(label4);
            Controls.Add(signin);
            Controls.Add(EXIT);
            Controls.Add(login);
            Controls.Add(password);
            Controls.Add(codigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox codigo;
        private TextBox password;
        private Button login;
        private Button EXIT;
        private LinkLabel signin;
        private Label label4;
    }
}