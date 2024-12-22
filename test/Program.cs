namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "16", "-10", "-6", "-3", "15", "7", "8", "-5", "-4", "16", "-19" };
            List<string> list = new List<string>();
            foreach (string str in strings) {
                if (int.TryParse(str.Trim(), out int n) && n % 2 == 0)
                {
                    list.Add(str);
                }
            }
            Console.WriteLine(String.Join("\n", list));
  
        }
        
    }
}
