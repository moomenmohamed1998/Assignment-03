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

        //public static bool ContainsDuplicates(int[] nums)
        // {

        //     HashSet<int> seen = new HashSet<int>();


        //     foreach (var num in nums)
        //     {

        //         if (!seen.Add(num))
        //         {
        //             return true;  
        //         }
        //     }

        //     return false;
        // }

        #endregion

        #region 7-

        static void AddEmployee(SortedList<int, string> directory, int employeeId, string name)
        {
            if (!directory.ContainsKey(employeeId))
            {
                directory.Add(employeeId, name);
                Console.WriteLine($"Added employee: ID = {employeeId}, Name = {name}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {employeeId} already exists.");
            }
        }

        static void RemoveEmployee(SortedList<int, string> directory, int employeeId)
        {
            if (directory.ContainsKey(employeeId))
            {
                directory.Remove(employeeId);
                Console.WriteLine($"Removed employee with ID = {employeeId}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {employeeId} not found.");
            }
        }

        static string GetEmployeeName(SortedList<int, string> directory, int employeeId)
        {
            if (directory.ContainsKey(employeeId))
            {
                return directory[employeeId];
            }
            else
            {
                return $"Employee with ID {employeeId} not found.";
            }
        }

        static void ListAllEmployees(SortedList<int, string> directory)
        {
            Console.WriteLine("Listing all employees:");
            foreach (var employee in directory)
            {
                Console.WriteLine($"ID = {employee.Key}, Name = {employee.Value}");
            }
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

            //int[] nums = { 1, 2, 3, 4, 5, 6};

            //bool hasDuplicates = ContainsDuplicates(nums);

            //Console.WriteLine(hasDuplicates ? "Array contains duplicates." : "Array does not contain duplicates.");

            #endregion

            #region 7-

            SortedList<int, string> employeeDirectory = new SortedList<int, string>();

            AddEmployee(employeeDirectory, 1001, "Alice");
            AddEmployee(employeeDirectory, 1003, "Bob");
            AddEmployee(employeeDirectory, 1002, "Charlie");

            Console.WriteLine("Employee with ID 1002: " + GetEmployeeName(employeeDirectory, 1002));

            RemoveEmployee(employeeDirectory, 1003);

            Console.WriteLine("Employee with ID 1003: " + GetEmployeeName(employeeDirectory, 1003));

            ListAllEmployees(employeeDirectory);

            #endregion
        }
    }
}
