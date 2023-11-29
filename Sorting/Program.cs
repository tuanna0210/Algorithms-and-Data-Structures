namespace Sorting
{
    internal class Program
    {
        private static Random _rng = new Random();
        static void Main(string[] args)
        {
            BubbleSort buble = new BubbleSort();
            int[] testdata = RandomArray(10);
            var sorted = buble.Sort(new[] { 4,7,2,8,54,8 });

            foreach (int i in sorted)
            {
                Console.WriteLine(i);
            }
        }
        private static int[] RandomArray(int length)
        {
            int[] data = new int[length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = _rng.Next();
            }

            return data;
        }
    }
}