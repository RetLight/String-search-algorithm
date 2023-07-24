namespace C____BUSQUEDA
{
    partial class Historial
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            volver = new Button();
            label3 = new Label();
            borrarHistorial = new LinkLabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(73, 34);
            label1.Name = "label1";
            label1.Size = new Size(573, 59);
            label1.TabIndex = 0;
            label1.Text = "Historial de busquedas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1132, 469);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(115, 130);
            label2.Name = "label2";
            label2.Size = new Size(1035, 32);
            label2.TabIndex = 2;
            label2.Text = "Aquí se pueden visualizar todas las busquedas realizadas por el usuario e información adicional.";
            // 
            // volver
            // 
            volver.Location = new Point(1146, 762);
            volver.Name = "volver";
            volver.Size = new Size(155, 61);
            volver.TabIndex = 3;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 725);
            label3.Name = "label3";
            label3.Size = new Size(568, 32);
            label3.TabIndex = 4;
            label3.Text = "¿Deseas borrar alguna busqueda o todo el historial?";
            // 
            // borrarHistorial
            // 
            borrarHistorial.AutoSize = true;
            borrarHistorial.Location = new Point(689, 725);
            borrarHistorial.Name = "borrarHistorial";
            borrarHistorial.Size = new Size(157, 32);
            borrarHistorial.TabIndex = 5;
            borrarHistorial.TabStop = true;
            borrarHistorial.Text = "Presiona aquí";
            borrarHistorial.LinkClicked += borrarHistorial_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 180);
            label4.Name = "label4";
            label4.Size = new Size(272, 32);
            label4.TabIndex = 6;
            label4.Text = "Datos de busquedas de ";
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1374, 879);
            Controls.Add(label4);
            Controls.Add(borrarHistorial);
            Controls.Add(label3);
            Controls.Add(volver);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Historial";
            Text = "Historial de busquedas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button volver;
        private Label label3;
        private LinkLabel borrarHistorial;
        private Label label4;
    }
}