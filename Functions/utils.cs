namespace utils;
using System;
using System.IO;
using System.Collections.Generic;
using Aspose.Words;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;

class Utils{
    public static void CreateTXT(string nombreArchivo, string contenido, string user){
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH.Replace("\\", "/");
        PATH = PATH + "/data/Archives/"+ user + "/" + nombreArchivo;
        using(StreamWriter archivo = File.CreateText(PATH)){
            archivo.Write(contenido);
        }
    }

    public static string ReadTXT(string txtPATH){
        string content = File.ReadAllText(txtPATH);
        return content;
    }

    public static List<Dictionary<string, string>> TXT2LIST(string rutaArchivo)
    {
        List<Dictionary<string, string>> listaDiccionarios = new List<Dictionary<string, string>>();
        Console.WriteLine("llega: " + rutaArchivo);
        string[] lineas = File.ReadAllLines(rutaArchivo);
        foreach (string linea in lineas)
        {
            string[] elementos = linea.Split(',');
            if (elementos.Length == 3)
            {
                Dictionary<string, string> diccionario = new Dictionary<string, string>();
                diccionario["codigo"] = elementos[0];
                diccionario["usuario"] = elementos[1];
                diccionario["contraseña"] = elementos[2];
                listaDiccionarios.Add(diccionario);
            }
        }

        return listaDiccionarios;
    }
    
    public static Boolean DeleteLines(string rutaArchivo)
    {
        string[] lineas = File.ReadAllLines(rutaArchivo);

        if (lineas.Length >= 2)
        {
            string[] nuevasLineas = new string[lineas.Length - 2];
            Array.Copy(lineas, 1, nuevasLineas, 0, lineas.Length - 2);
            File.WriteAllLines(rutaArchivo, nuevasLineas);
            return true;
        }
        else
        {
            return false;
        }
    }

    public static List<Dictionary<string, string>> getRecord(string PATH)
    {
        List<Dictionary<string, string>> record = new List<Dictionary<string, string>>();

        string[] lineas = File.ReadAllLines(PATH);
        foreach (string linea in lineas)
        {
            string[] elementos = linea.Split(',');
            if (elementos.Length == 6){
                Dictionary<string, string> diccionario = new Dictionary<string, string>();
                diccionario["usuario"] = elementos[0];
                diccionario["nombreArchivo"] = elementos[1];
                diccionario["textoBuscado"] = elementos[2];
                diccionario["algoritmo"] = elementos[3];
                diccionario["resultado"] = elementos[4];
                diccionario["tiempoEjecucion"] = elementos[5];
                record.Add(diccionario);
            }
        }
        return record;
    }
}