using Tyuiu.KonovalovVA.Sprint5.Task3.V7.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("x = 2");
            int x = 2;

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Файл: " + ds.SaveToFileTextData(x));
            Console.WriteLine("Создан");

        }
    }
}
