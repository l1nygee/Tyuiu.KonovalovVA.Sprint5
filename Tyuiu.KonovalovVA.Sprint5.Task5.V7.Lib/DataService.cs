using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        static double CalculateFactorial(double number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        public double LoadFromDataFile(string path)
        {
            double result = 1;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        string[] numbersStr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                        foreach (string strNumber in numbersStr)
                        {
                            string trimmedStrNumber = strNumber.Trim().Replace('.', ','); 
                            if (double.TryParse(trimmedStrNumber, out double numberDouble))
                            {
                                int n = (int)numberDouble;
                                return CalculateFactorial(n); ; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            return result;
        }
    }
}
