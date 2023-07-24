namespace Functions;
using System;
using utils;
using FoS;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.Words;

class Functions
{
    public static Boolean Signin(string code, string user, string contraseña){
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH.Replace("\\", "/");
        Console.WriteLine("xd: " + PATH);
        if(code == "" || user == "" || contraseña == ""){
            return false;
        }
        else{
            string nuevoUsuario = code + "," + user + "," + contraseña;
            File.AppendAllText(PATH, nuevoUsuario + Environment.NewLine);
            return true;
        }
    }
    public static string Login(string code, string password){
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH.Replace("\\", "/");
        PATH = PATH + "/data/Users/users.txt";
        List<Dictionary<string, string>> users = Utils.TXT2LIST(PATH);
        foreach (var diccionario in users){
            if(diccionario["codigo"] == code){
                if(diccionario["contraseña"] == password){
                    return diccionario["usuario"];
                }
                else{
                    return "";
                }
            }
        }
        return "";
    }
    public static Boolean Register(string FilePATH, string user){
        string filename = Path.GetFileName(FilePATH);
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH.Replace("\\", "/");
        PATH = PATH + "/data/Archives/"+ user + "/" + filename;
        if(FilePATH.Contains(".pdf")){
            var PDF = new Document(FilePATH);
            PDF.Save(PATH);
            if(Utils.DeleteLines(PATH)){
                return true;
            }
            else{
                return false;
            }
        }
        else if(filename.Contains(".txt")){
            string content = Utils.ReadTXT(FilePATH);
            Utils.CreateTXT(filename,content,user);
            return true;
        }
        else if(FilePATH.Contains(".docx")){
            var doc = new Document(FilePATH);
            doc.Save(PATH);
            if(Utils.DeleteLines(PATH)){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return false;
        }
    }
    public static string Search(string pattern, string NameFile, string user, string algoritmo){
        Stopwatch timeMeasure = new Stopwatch();
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH.Replace("\\", "/");
        string filePATH = PATH + "/data/Archives/"+ user + "/" + NameFile + ".txt";
        string PATHhistory = PATH + "/data/History/History.txt";
        string content = Utils.ReadTXT(filePATH);
        string ans;
        if(algoritmo == "Fuerza Bruta"){
            timeMeasure.Start();
            ans = FoS.BruteForce(pattern, content);
            timeMeasure.Stop();
        }
        else if(algoritmo == "Knuth-Morris-Pratt"){
            timeMeasure.Start();
            ans = FoS.SearchKMP(pattern, content);
            timeMeasure.Stop();
        }
        else{
            timeMeasure.Start();
            ans = FoS.BoyerMoore(pattern, content);
            timeMeasure.Stop();
        }
        string nuevaLinea = user + "," + NameFile + "," + pattern + "," + algoritmo + "," + "(" + ans.Replace(",","-") + ")" + "," + timeMeasure.Elapsed.TotalMilliseconds;
        File.AppendAllText(PATHhistory, nuevaLinea + Environment.NewLine);
        return ans;
    }
    public static List<Dictionary<string, string>> Record(string user){
        string PATH = Directory.GetCurrentDirectory();
        PATH = PATH.Replace("\\bin\\Debug\\net7.0-windows", "");
        PATH = PATH + "/data/History/History.txt";
        List<Dictionary<string, string>> record = Utils.getRecord(PATH);
        List<Dictionary<string, string>> userRecord = new List<Dictionary<string, string>>();
        foreach (var diccionario in record){
            if(diccionario["usuario"] == user){
                userRecord.Add(diccionario);
            }
        }
        return userRecord;
    }
}