using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int ans = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //Разбиваем строку на слова
                    foreach (string word in words)
                    {
                        for (int i = 0; i < word.Length; i++) 
                        {
                            if (word[i] != '.' && word[i] != ',') count++;
                        }
                        if (count == 6) ans++;
                        count = 0;
                    }
                }
            }
            return ans;
        }
    }
}
