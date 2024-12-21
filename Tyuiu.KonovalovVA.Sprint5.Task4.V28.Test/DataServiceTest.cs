using System.Diagnostics;
using Tyuiu.KonovalovVA.Sprint5.Task4.V28.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task4.V28\bin\Debug\net8.0\InPutDataFileTask4V28.txt";

            FileInfo fileinfo = new(path);
            bool fileExists = fileinfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}