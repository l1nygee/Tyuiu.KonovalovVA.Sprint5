using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string cur;
            string ans = "";
            try
            {
                cur = File.ReadAllText(path);
                ans = Regex.Replace(cur, "[a-zA-Z]", "#");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при работе с файлами: {ex.Message}");
            }

            return ans;
        }
    }
}
