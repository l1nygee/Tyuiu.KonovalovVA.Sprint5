using Tyuiu.KonovalovVA.Sprint5.Task2.V15.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] ar = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ar[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ar[i,j]}\t");
                }
                Console.WriteLine();
            }
            string res = ds.SaveToFileTextData(ar);
            Console.WriteLine(res);
        }
    }
}
