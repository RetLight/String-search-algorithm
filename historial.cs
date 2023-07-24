using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C____BUSQUEDA
{
    public partial class Historial : Form
    {
        public void IniciarHistorial(string user)
        {
            InitializeComponent();
            label4.Text += user;
            List<Dictionary<string, string>> datos = Functions.Functions.Record(user);

            dataGridView1.AutoGenerateColumns = false;

            // Columna "id"
            DataGridViewTextBoxColumn columnaId = new DataGridViewTextBoxColumn();
            columnaId.HeaderText = "ID";
            columnaId.DataPropertyName = "Item0";
            dataGridView1.Columns.Add(columnaId);

            // Columna "Archivo"
            DataGridViewTextBoxColumn columnaArchivo = new DataGridViewTextBoxColumn();
            columnaArchivo.HeaderText = "Archivo";
            columnaArchivo.DataPropertyName = "Item1";
            dataGridView1.Columns.Add(columnaArchivo);

            // Columna "texto"
            DataGridViewTextBoxColumn columnaTexto = new DataGridViewTextBoxColumn();
            columnaTexto.HeaderText = "Texto";
            columnaTexto.DataPropertyName = "Item2";
            dataGridView1.Columns.Add(columnaTexto);

            // Columna "algoritmo"
            DataGridViewTextBoxColumn columnaAlgoritmo = new DataGridViewTextBoxColumn();
            columnaAlgoritmo.HeaderText = "Algoritmo";
            columnaAlgoritmo.DataPropertyName = "Item3";
            dataGridView1.Columns.Add(columnaAlgoritmo);

            // Columna "resultado"
            DataGridViewTextBoxColumn columnaResultado = new DataGridViewTextBoxColumn();
            columnaResultado.HeaderText = "Resultado";
            columnaResultado.DataPropertyName = "Item4";
            dataGridView1.Columns.Add(columnaResultado);

            // Columna "tiempo"
            DataGridViewTextBoxColumn columnaTiempo = new DataGridViewTextBoxColumn();
            columnaTiempo.HeaderText = "Tiempo (ms)";
            columnaTiempo.DataPropertyName = "Item5";
            dataGridView1.Columns.Add(columnaTiempo);

            List<Dictionary<string, string>> tabla = new List<Dictionary<string, string>>();
            int i = 0;
            Console.WriteLine("AQUI SE MUESTRA EL HISTORIAL DEL USUARIO");
            Console.WriteLine("ID || Nombre del archivo || Texto buscado || Algoritmo || Resultado || Tiempo");
            foreach (var diccionario in datos)
            {
                Dictionary<string, string> fila = new Dictionary<string, string>();
                fila["Item0"] = i.ToString();
                fila["Item1"] = diccionario["nombreArchivo"];
                string rec = i.ToString() + " || " + diccionario["nombreArchivo"] + 
                    " || " + diccionario["textoBuscado"] + " || " + diccionario["algoritmo"] + 
                    " || " + diccionario["resultado"] + " || " + diccionario["tiempoEjecucion"];
                Console.WriteLine(rec);
                //Console.WriteLine(diccionario["nombreArchivo"]);
                fila["Item2"] = diccionario["textoBuscado"];
                //Console.WriteLine(diccionario["textoBuscado"]);
                fila["Item3"] = diccionario["algoritmo"];
                //Console.WriteLine(diccionario["algoritmo"]);
                fila["Item4"] = diccionario["resultado"];
                //Console.WriteLine(diccionario["resultado"]);
                fila["Item5"] = diccionario["tiempoEjecucion"];
                //Console.WriteLine(diccionario["tiempoEjecucion"]);
                tabla.Add(fila);
                i++;

                int id = 0;
                
                
            }
            dataGridView1.DataSource = tabla;
            this.Controls.Add(dataGridView1);
            dataGridView1.Visible = true;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
