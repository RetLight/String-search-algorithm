using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace C____BUSQUEDA
{
    public partial class Home : Form
    {
        public void IniciarHome(string user)
        {
            InitializeComponent();
            welcome.Text += user;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            algoritmo.Items.Add("Fuerza Bruta");
            algoritmo.Items.Add("Knuth-Morris-Pratt");
            algoritmo.Items.Add("Boyer-Moore");
            string PATH = Directory.GetCurrentDirectory();
            PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
            PATH = PATH.Replace("\\", "/");
            PATH = PATH + "/data/Archives/" + welcome.Text.Replace("Bienvenido, ", "");
            string[] nombresArchivos = Directory.GetFiles(PATH);
            foreach (string Archivo in nombresArchivos)
            {
                string nombre = Path.GetFileName(Archivo);
                if (nombre.Contains(".txt") || nombre.Contains(".pdf") || nombre.Contains(".docx"))
                {
                    nombre = Path.GetFileNameWithoutExtension(Archivo);
                    nombreArchivo.Items.Add(nombre);
                }
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asegurese que sus archivos sean de solo texto.");
            OpenFileDialog dialogoArchivo = new OpenFileDialog();
            dialogoArchivo.Filter = "Archivos PDF, TXT, DOCX|*.pdf;*.txt;*.docx";
            DialogResult resultadoArchivo = dialogoArchivo.ShowDialog();

            if (resultadoArchivo == DialogResult.OK)
            {
                // Obtener la ruta completa del archivo seleccionado
                string rutaArchivo = dialogoArchivo.FileName;

                // Obtener la carpeta del archivo seleccionado
                string carpetaArchivo = Path.GetDirectoryName(rutaArchivo);

                // Mostrar la ruta completa del archivo en el TextBox
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                pathArchivo.Text = Path.Combine(carpetaArchivo, nombreArchivo);
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string path = pathArchivo.Text;
            if (path == "")
            {
                MessageBox.Show("Tiene que ingresar una dirección valida.");
            }
            else
            {
                bool ok = Functions.Functions.Register(path, welcome.Text.Replace("Bienvenido, ", ""));
                if (ok)
                {
                    MessageBox.Show("Archivo subido satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("Error: Verifique su archivo sea del tipo admitido.\nLos archivos permitidos son .pdf, .docx y .txt.");
                }
            }
            pathArchivo.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            string archivo = nombreArchivo.Text;
            string algorit = algoritmo.Text;
            string texto = textoBusqueda.Text;

            if (archivo == "" || algorit == "" || texto == "")
            {
                MessageBox.Show("Ingrese los datos correctamente.");
            }
            else
            {
                string ans = Functions.Functions.Search(texto, archivo, welcome.Text.Replace("Bienvenido, ", ""), algorit);
                MessageBox.Show(ans);
            }
            nombreArchivo.Text = "";
            algoritmo.Text = "";
            textoBusqueda.Text = "";
        }

        private void Historial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            pathArchivo.Text = string.Empty;
            textoBusqueda.Text= string.Empty;
            nombreArchivo.Text= string.Empty;
            algoritmo.Text= string.Empty;
            Historial his = new();
            his.IniciarHistorial(welcome.Text.Replace("Bienvenido, ", ""));
            his.ShowDialog();
            this.Show();
        }

        private void ExitHome_Click(object sender, EventArgs e)
        {
            welcome.Text = "Bienvenido, ";
            pathArchivo.Text = "";
            nombreArchivo.Text = "";
            algoritmo.Text = "";
            textoBusqueda.Text = "";
            this.Close();
        }

        private void Ingresar_Click_1(object sender, EventArgs e)
        {
            string PATH = pathArchivo.Text;
            if (PATH == "")
            {
                MessageBox.Show("Tiene que ingresar una dirección valida.");
            }
            else
            {
                bool ok = Functions.Functions.Register(PATH, welcome.Text.Replace("Bienvenido, ", ""));
                if (ok)
                {
                    MessageBox.Show("Archivo subido satisfactoriamente.");
                    this.Hide();
                    Home p = new Home();
                    p.IniciarHome(welcome.Text.Replace("Bienvenido, ", ""));
                    p.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error: Verifique su archivo sea del tipo admitido.\nLos archivos permitidos son .pdf, .docx y .txt.");
                }
            }
            pathArchivo.Text = "";
        }
    }
}
