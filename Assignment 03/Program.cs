using System.Collections;

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

        //static void AddEmployee(SortedList<int, string> directory, int employeeId, string name)
        //{
        //    if (!directory.ContainsKey(employeeId))
        //    {
        //        directory.Add(employeeId, name);
        //        Console.WriteLine($"Added employee: ID = {employeeId}, Name = {name}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Employee with ID {employeeId} already exists.");
        //    }
        //}

        //static void RemoveEmployee(SortedList<int, string> directory, int employeeId)
        //{
        //    if (directory.ContainsKey(employeeId))
        //    {
        //        directory.Remove(employeeId);
        //        Console.WriteLine($"Removed employee with ID = {employeeId}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Employee with ID {employeeId} not found.");
        //    }
        //}

        //static string GetEmployeeName(SortedList<int, string> directory, int employeeId)
        //{
        //    if (directory.ContainsKey(employeeId))
        //    {
        //        return directory[employeeId];
        //    }
        //    else
        //    {
        //        return $"Employee with ID {employeeId} not found.";
        //    }
        //}

        //static void ListAllEmployees(SortedList<int, string> directory)
        //{
        //    Console.WriteLine("Listing all employees:");
        //    foreach (var employee in directory)
        //    {
        //        Console.WriteLine($"ID = {employee.Key}, Name = {employee.Value}");
        //    }
        //}

        #endregion

        #region 8-

        //public static List<int> FindMissingNumbers(int[] nums, int N)
        //{
        //    HashSet<int> existingNumbers = new HashSet<int>();

        //    foreach (int num in nums)
        //    {
        //        existingNumbers.Add(num);
        //    }

        //    List<int> missingNumbers = new List<int>();

        //    for (int i = 1; i <= N; i++)
        //    {
        //        if (!existingNumbers.Contains(i))
        //        {
        //            missingNumbers.Add(i);
        //        }
        //    }

        //    return missingNumbers;
        //}

        #endregion

        #region 10-

        //public static Hashtable SwapKeysAndValues(Hashtable original)
        //{
        //    Hashtable swapped = new Hashtable();

        //    foreach (DictionaryEntry entry in original)
        //    {
        //        swapped.Add(entry.Value, entry.Key);
        //    }

        //    return swapped;
        //}

        #endregion

        #region 12-

       //public static int CountKeysStartingWith(Dictionary<string, int> dictionary, char targetChar)
       // {
       //     int count = 0;

       //     foreach (var key in dictionary.Keys)
       //     {
       //         if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
       //         {
       //             count++;
       //         }
       //     }
       //     return count;
       // }

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

            //SortedList<int, string> employeeDirectory = new SortedList<int, string>();

            //AddEmployee(employeeDirectory, 1001, "Alice");
            //AddEmployee(employeeDirectory, 1003, "Bob");
            //AddEmployee(employeeDirectory, 1002, "Charlie");

            //Console.WriteLine("Employee with ID 1002: " + GetEmployeeName(employeeDirectory, 1002));

            //RemoveEmployee(employeeDirectory, 1003);

            //Console.WriteLine("Employee with ID 1003: " + GetEmployeeName(employeeDirectory, 1003));

            //ListAllEmployees(employeeDirectory);

            #endregion

            #region 8-

            //int[] nums = { 1, 2, 4, 6, 7, 8, 10 };
            //int N = 10;  

            //List<int> missingNumbers = FindMissingNumbers(nums, N);

            //Console.WriteLine("The missing numbers are:");
            //foreach (var num in missingNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region 9-

            //List<int> numbers = new List<int> { 1, 3, 5, 7, 3, 1, 6, 5, 8, 9 };

            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //Console.WriteLine("Unique numbers:");
            //foreach (var num in uniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region 10-

            //   Hashtable originalHashtable = new Hashtable
            //{
            //   { 1, "A" },
            //   { 2, "B" },
            //   { 3, "C" },
            //   { 4, "D" }
            //};

            //   Hashtable swappedHashtable = SwapKeysAndValues(originalHashtable);

            //   Console.WriteLine("Swapped Hashtable:");
            //   foreach (DictionaryEntry entry in swappedHashtable)
            //   {
            //       Console.WriteLine($"Key = {entry.Key}, Value = {entry.Value}");
            //   }

            #endregion

            #region 12-

        //    Dictionary<string, int> myDictionary = new Dictionary<string, int>
        //{
        //    { "apple", 1 },
        //    { "animal", 2 },
        //    { "airport", 3 },
        //    { "banana", 4 },
        //    { "grape", 5 }
        //};

        //    Console.WriteLine("Enter a character:");
        //    char targetChar = Console.ReadKey().KeyChar;
        //    Console.WriteLine();

        //    int count = CountKeysStartingWith(myDictionary, targetChar);

        //    Console.WriteLine($"Number of keys starting with '{targetChar}': {count}");

            #endregion
        }
    }
}
