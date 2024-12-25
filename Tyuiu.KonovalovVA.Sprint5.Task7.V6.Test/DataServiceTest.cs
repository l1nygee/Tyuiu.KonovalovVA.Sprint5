using System.IO;
using Tyuiu.KonovalovVA.Sprint5.Task7.V6.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task7.V6\bin\Debug\net8.0\InPutDataFileTask7V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
        }
    }
    
}