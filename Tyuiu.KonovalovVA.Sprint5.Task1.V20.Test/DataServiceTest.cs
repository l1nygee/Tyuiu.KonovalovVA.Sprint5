using Tyuiu.KonovalovVA.Sprint5.Task1.V20.Lib;
using System.IO;
namespace Tyuiu.KonovalovVA.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task1.V20.Lib\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}