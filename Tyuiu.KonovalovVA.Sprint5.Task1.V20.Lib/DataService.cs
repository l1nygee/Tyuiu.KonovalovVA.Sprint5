using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);

            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++) {
                y = (5*x + 2.5) / (Math.Sin(x)+3) + 2 * x + Math.Cos(x);
                y = Math.Round(y,2);
                stry = Convert.ToString(y);

                if(x != stopValue) File.AppendAllText(path, stry+Environment.NewLine);
                else File.AppendAllText(path, stry);
            }
            return path;
        }
    }
}
