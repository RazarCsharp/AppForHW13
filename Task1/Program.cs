using System.Diagnostics;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            var watch = Stopwatch.StartNew();
            //List
            var list = File.ReadLines("C:\\Users\\RAZAR\\Desktop\\Text1.txt").ToList();
            Console.WriteLine($"List: {watch.Elapsed.TotalMilliseconds} ms");
            //LinkedList
            var lList = new LinkedList<string>();
            lList.AddFirst(File.ReadAllText("C:\\Users\\RAZAR\\Desktop\\Text1.txt"));
            Console.WriteLine($"LinkedList: {watch.Elapsed.TotalMilliseconds} ms");
        }
    }
}