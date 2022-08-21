using System.Data;
using SortingAlgorithms.src;

namespace SortingAlgorithms.PerformanceTests
{
    public class PerformanceTests
    {
        public void GetAlgrithmsPerformance()
        {
            var type = typeof(SortingAlgorithm);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

            List<KeyValuePair<string, double>> results = new List<KeyValuePair<string, double>>();

            Parallel.ForEach(types, t =>
            {
                Console.WriteLine($"Now sorting with: {t.Name}.");

                if (t.FullName != typeof(SortingAlgorithm).FullName)
                {
                    SortingAlgorithm? algorithm = Activator.CreateInstance(t) as SortingAlgorithm;
                    results.Add(new KeyValuePair<string, double>(t.Name, LoadTest(algorithm)));

                }
                Console.WriteLine($"Ended sorting with: {t.Name}.");
            });

            PlotResults(results);
        }

        private static double LoadTest(SortingAlgorithm? algorithm)
        {
            double time = 0;
            int iterations = 100;
            for (int i = 0; i < iterations; ++i)
            {

                var watch = System.Diagnostics.Stopwatch.StartNew();
                algorithm?.Sort(Utils.GetRandomArray(10000));
                watch.Stop();
                time += watch.ElapsedMilliseconds;

            }

            return time / iterations;
        }
        public static void PlotResults(List<KeyValuePair<string, double>> list)
        {
            var max = list.Max(x => x.Value);

            foreach (var item in list)
            {
                Console.Write(item.Key);

                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.DarkBlue;

                int numberpads = (int)(item.Value / max * 100);
                for (var i = 0; i < numberpads; i++)
                    Console.Write("#");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write(" ");
                Console.WriteLine(item.Value);
            }
        }
    }
}
