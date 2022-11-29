namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\RAZAR\\Desktop\\Text1.txt");
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray())
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x)
                .Select(x => new { Word = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .Take(10);
            foreach (var word in noPunctuationText)
            {
                Console.WriteLine(word);
            }
        }
    }
}