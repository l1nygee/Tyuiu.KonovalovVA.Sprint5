using Tyuiu.KonovalovVA.Sprint5.Task5.V7.Lib;
namespace Tyuiu.KonovalovVA.Sprint5.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\volod\source\repos\Tyuiu.KonovalovVA.Sprint5\Tyuiu.KonovalovVA.Sprint5.Task5.V7\bin\Debug\net8.0\InPutDataFileTask5V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileex = fileInfo.Exists;
            Assert.AreEqual(true, fileex );
        }
    }
}