namespace Assignment_03
{
    internal class Program
    {
        #region 1-
        //public static void Count(int[] arr)
        //{
        //    Dictionary<int, int> frequency = new Dictionary<int, int>();

        //    foreach (int num in arr)
        //    {
        //        if (frequency.ContainsKey(num))

        //            frequency[num]++;

        //        else frequency[num] = 1;

        //    }

        //    foreach (var entry in frequency)
        //    {
        //        Console.WriteLine($"Element {entry.Key} appears {entry.Value} times.");
        //    }
        //} 

        #endregion

        #region 2-
        public static string MaxValue(Dictionary<string, int> hashTable)
        {
            string MaxValue = null;
            int maxValue = int.MinValue;

            
            foreach (var entry in hashTable)
            {
                if (entry.Value > maxValue)
                {
                    maxValue = entry.Value;
                    MaxValue = entry.Key;
                }
            }

            return MaxValue;
        }
        #endregion

        static void Main(string[] args)
        {
            #region 1-
            //{
            //    int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            //    Count(arr);
            //}
            #endregion

            #region 2-

            
            Dictionary<string, int> hashTable = new Dictionary<string, int>
        {
            { "a", 1 },
            { "b", 2 },
            { "c", 3 },
            { "d", 2 }
        };

            
            string keyWithMaxValue = MaxValue(hashTable);
            Console.WriteLine($"Key with highest value: {keyWithMaxValue}");

            #endregion
        }
    }
}
