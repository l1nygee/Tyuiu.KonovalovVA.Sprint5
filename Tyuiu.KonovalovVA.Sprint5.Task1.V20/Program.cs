using Tyuiu.KonovalovVA.Sprint5.Task1.V20.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int st = -5;
            int en = 5;
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(st,en);
            Console.WriteLine("Файл:  "+res);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
