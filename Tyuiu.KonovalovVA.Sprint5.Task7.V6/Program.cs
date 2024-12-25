using Tyuiu.KonovalovVA.Sprint5.Task7.V6.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task7.V6\bin\Debug\net8.0\InPutDataFileTask7V6.txt";
            string pathSave = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task7.V6\bin\Debug\net8.0\OutPutDataFileTask7V6.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
