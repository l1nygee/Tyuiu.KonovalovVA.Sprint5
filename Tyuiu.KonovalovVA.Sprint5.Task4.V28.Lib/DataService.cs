using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            double y;

            string temp = File.ReadAllText(path);
            temp = temp.Replace('.', ',');
            double x = Convert.ToDouble(temp);

            if (x == 0) y = 0;
            else y = Math.Round((3*x*x*x / Math.Sin(x)), 3);

            return y;
        }
    }
}
