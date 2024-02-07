namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var customArray = new NotifyingCustomArray<int>();
            customArray.ArrayExpanded += (sender, e) => Console.WriteLine("Array expanded.");

            customArray.Add(5);
            customArray.Add(3);
            customArray.Add(23);
            customArray.Add(-11);
            customArray.Add(8);
            customArray.Add(1);

            // Using LINQ for sorting
            var sorted = customArray.OrderBy(x => x).ToArray();
            Console.WriteLine("Sorted:");
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            // Using LINQ for filtering
            var filtered = customArray.Where(x => x > 5).ToArray();
            Console.WriteLine("\nFiltered (greater than 5):");
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
