using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string pathOutput = $@"{Directory.GetCurrentDirectory()}\OutOutFileTask7V6.txt";
            FileInfo fileInfo = new FileInfo(pathOutput);
            bool fileExists = fileInfo.Exists;
            if (fileExists) { File.Delete(pathOutput); }
            string stroka = File.ReadAllText(path);
            string result = Regex.Replace(stroka, "[a-zA-Z]", "#");
            File.WriteAllText(pathOutput, result.ToString()+Environment.NewLine);
            return pathOutput;
        }
    }
}
