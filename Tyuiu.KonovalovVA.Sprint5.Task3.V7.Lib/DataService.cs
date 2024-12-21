
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            File.WriteAllText(path, "");
            double ans = 1.6 * x * x * x - 2.1 * x * x + 7 * x;
            ans = Math.Round(ans, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(ans));


            }
            return path;
        }
    }
}