using System.Diagnostics;
using Tyuiu.KonovalovVA.Sprint5.Task5.V7.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("************************************* ***************************************************");

            string path = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task5.V7\bin\Debug\net8.0\InPutDataFileTask5V7.txt";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);


            Console.ReadLine();


        }
    }
}
