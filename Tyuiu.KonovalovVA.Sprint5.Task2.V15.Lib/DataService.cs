using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KonovalovVA.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            File.WriteAllText(path, ""); 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j]%2 != 0) matrix[i, j] = 0;
                }
            }
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    str += matrix[i, j] + ";";
                }
                File.AppendAllText(path, str+Environment.NewLine);
                str = "";
            }
            return path;
        }
        
        
        
    }
}
