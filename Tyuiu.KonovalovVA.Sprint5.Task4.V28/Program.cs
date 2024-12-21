using Tyuiu.KonovalovVA.Sprint5.Task4.V28.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task4.V28\bin\Debug\net8.0\InPutDataFileTask4V28.txt";

            Console.WriteLine("* Путь файла: " + path);
            Console.WriteLine("* X = " + File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y = ds.LoadFromDataFile(path);

            Console.WriteLine("* Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
