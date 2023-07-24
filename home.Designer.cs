namespace C____BUSQUEDA
{
    partial class Home
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
            welcome = new Label();
            panel1 = new Panel();
            Ingresar = new Button();
            Browse = new Button();
            pathArchivo = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            historial = new LinkLabel();
            label5 = new Label();
            search = new Button();
            algoritmo = new ComboBox();
            label4 = new Label();
            nombreArchivo = new ComboBox();
            archivo = new Label();
            textoBusqueda = new TextBox();
            text = new Label();
            label1 = new Label();
            label3 = new Label();
            exitHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            welcome.Location = new Point(60, 39);
            welcome.Name = "welcome";
            welcome.Size = new Size(278, 65);
            welcome.TabIndex = 0;
            welcome.Text = "Bienvenido, ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(Ingresar);
            panel1.Controls.Add(Browse);
            panel1.Controls.Add(pathArchivo);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(223, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 158);
            panel1.TabIndex = 1;
            // 
            // Ingresar
            // 
            Ingresar.Location = new Point(372, 92);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(150, 46);
            Ingresar.TabIndex = 3;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click_1;
            // 
            // Browse
            // 
            Browse.Location = new Point(693, 19);
            Browse.Name = "Browse";
            Browse.Size = new Size(150, 46);
            Browse.TabIndex = 2;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // pathArchivo
            // 
            pathArchivo.Location = new Point(144, 23);
            pathArchivo.Name = "pathArchivo";
            pathArchivo.Size = new Size(522, 39);
            pathArchivo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 26);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 0;
            label2.Text = "Archivo: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(historial);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(search);
            panel2.Controls.Add(algoritmo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(nombreArchivo);
            panel2.Controls.Add(archivo);
            panel2.Controls.Add(textoBusqueda);
            panel2.Controls.Add(text);
            panel2.Location = new Point(223, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 347);
            panel2.TabIndex = 2;
            // 
            // historial
            // 
            historial.AutoSize = true;
            historial.Location = new Point(485, 295);
            historial.Name = "historial";
            historial.Size = new Size(157, 32);
            historial.TabIndex = 8;
            historial.TabStop = true;
            historial.Text = "Presiona aquí";
            historial.LinkClicked += Historial_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 295);
            label5.Name = "label5";
            label5.Size = new Size(427, 32);
            label5.TabIndex = 7;
            label5.Text = "¿Deseas ver tu historial de busquedas?";
            // 
            // search
            // 
            search.Location = new Point(372, 223);
            search.Name = "search";
            search.Size = new Size(150, 46);
            search.TabIndex = 6;
            search.Text = "Buscar";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // algoritmo
            // 
            algoritmo.FormattingEnabled = true;
            algoritmo.Location = new Point(170, 162);
            algoritmo.Name = "algoritmo";
            algoritmo.Size = new Size(404, 40);
            algoritmo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 165);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 4;
            label4.Text = "Algoritmo: ";
            // 
            // nombreArchivo
            // 
            nombreArchivo.FormattingEnabled = true;
            nombreArchivo.Location = new Point(170, 94);
            nombreArchivo.Name = "nombreArchivo";
            nombreArchivo.Size = new Size(673, 40);
            nombreArchivo.TabIndex = 3;
            // 
            // archivo
            // 
            archivo.AutoSize = true;
            archivo.Location = new Point(32, 97);
            archivo.Name = "archivo";
            archivo.Size = new Size(99, 32);
            archivo.TabIndex = 2;
            archivo.Text = "Archivo:";
            // 
            // textoBusqueda
            // 
            textoBusqueda.Location = new Point(170, 28);
            textoBusqueda.Name = "textoBusqueda";
            textoBusqueda.Size = new Size(673, 39);
            textoBusqueda.TabIndex = 1;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(32, 31);
            text.Name = "text";
            text.Size = new Size(83, 32);
            text.TabIndex = 0;
            text.Text = "Texto: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 123);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 3;
            label1.Text = "Registro de texto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 368);
            label3.Name = "label3";
            label3.Size = new Size(214, 32);
            label3.TabIndex = 4;
            label3.Text = "Busqueda de texto";
            // 
            // exitHome
            // 
            exitHome.Location = new Point(1146, 776);
            exitHome.Name = "exitHome";
            exitHome.Size = new Size(150, 56);
            exitHome.TabIndex = 5;
            exitHome.Text = "Salir";
            exitHome.UseVisualStyleBackColor = true;
            exitHome.Click += ExitHome_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1370, 875);
            Controls.Add(exitHome);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(welcome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Home";
            Text = "Pagina principal";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Panel panel1;
        private Panel panel2;
        private Button Ingresar;
        private Button Browse;
        private TextBox pathArchivo;
        private Label label2;
        private Label label1;
        private Label text;
        private Label label3;
        private Label label4;
        private ComboBox nombreArchivo;
        private Label archivo;
        private TextBox textoBusqueda;
        private ComboBox algoritmo;
        private Button search;
        private Button exitHome;
        private LinkLabel historial;
        private Label label5;
    }
}