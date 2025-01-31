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
        //public static string MaxValue(Dictionary<string, int> hashTable)
        //{
        //    string MaxValue = null;
        //    int maxValue = int.MinValue;


        //    foreach (var entry in hashTable)
        //    {
        //        if (entry.Value > maxValue)
        //        {
        //            maxValue = entry.Value;
        //            MaxValue = entry.Key;
        //        }
        //    }

        //    return MaxValue;
        //}
        #endregion

        #region 4-

        //public static List<List<string>> Group(string[] strs)
        //{
        //   var anagramMap = new Dictionary<string, List<string>>();

        //    foreach (var str in strs)
        //    {
        //        char[] chars = str.ToCharArray();
        //        Array.Sort(chars);
        //        string sortedStr = new string(chars);

        //        if (!anagramMap.ContainsKey(sortedStr))
        //        {
        //            anagramMap[sortedStr] = new List<string>();
        //        }

        //        anagramMap[sortedStr].Add(str);
        //    }

        //    return new List<List<string>>(anagramMap.Values);
        //}

        #endregion

        #region 5-

       public static bool ContainsDuplicates(int[] nums)
        {
            
            HashSet<int> seen = new HashSet<int>();

            
            foreach (var num in nums)
            {
                
                if (!seen.Add(num))
                {
                    return true;  
                }
            }

            return false;
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


            //    Dictionary<string, int> hashTable = new Dictionary<string, int>
            //{
            //    { "a", 1 },
            //    { "b", 2 },
            //    { "c", 3 },
            //    { "d", 2 }
            //};


            //    string keyWithMaxValue = MaxValue(hashTable);
            //    Console.WriteLine($"Key with highest value: {keyWithMaxValue}");

            #endregion

            #region 4-

            //string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            //var groupedAnagrams = Group(strs);

            //foreach (var group in groupedAnagrams)
            //{
            //    Console.WriteLine(string.Join(", ", group));
            //}

            #endregion


            #region 5-

            int[] nums = { 1, 2, 3, 4, 5, 6};

            bool hasDuplicates = ContainsDuplicates(nums);

            Console.WriteLine(hasDuplicates ? "Array contains duplicates." : "Array does not contain duplicates.");

            #endregion
        }
    }
}
