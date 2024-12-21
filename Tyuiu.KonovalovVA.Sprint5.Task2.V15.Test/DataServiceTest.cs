using Tyuiu.KonovalovVA.Sprint5.Task2.V15.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task2.V15.Lib\bin\Debug\net8.0\OutPutFileTask2.csv";
            FileInfo file = new FileInfo(path);
            bool fileex = file.Exists;
            Assert.AreEqual(true, fileex);
        }
    }
}