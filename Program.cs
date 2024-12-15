namespace LinqGenerationMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var collection = Enumerable.Empty<int>();
            //var collection = Enumerable.Repeat(1, 20);
            var collection = Enumerable.Range(1, 20).ToList();

            collection.Add(52);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
