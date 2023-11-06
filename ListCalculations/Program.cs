namespace ListCalculations
{
    public class Program
    {
        // Get the sum of the 4 smallest values in a user-submitted list
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, separated by a comma:");
            var input = Console.ReadLine();

            string[] splitInput = SplitByComma(input); // turn input into array of strings

            var nums = ParseStringArrayToIntList(splitInput); // for each piece of input split by commas, convert to Int32 & add to nums list

            var smallNums = GetSmallestNums(nums, 4);

            Console.WriteLine(SumNumbers(smallNums)); // sum numbers in nums(0,4)
        }

        //public int WriteLineWithSumOfNumbers

        static public string[] SplitByComma(string input) // convert string input into array of strings split by ","
        {
            return input.Split(",");
        }

        static List<int> ParseStringArrayToIntList(string[] stringNumbers) // for each piece of input split by commas, convert to Int32 & add to nums list of integers
        {
            List<int> nums = new List<int>();

            foreach (string number in stringNumbers)
            {
                nums.Add(Convert.ToInt32(number));
            }
            return nums;
        }

        static List<int> GetSmallestNums(List<int> allNums, int count) // retrieve smallest numbers from list
        {
            allNums.Sort();
            return allNums.GetRange(0, 4);
        }

        static int SumNumbers(List<int> nums) // get sum of numbers; reusable method - doesn't make existing code more concise, but could come in handy if we continue building this out.
        {
            return nums.Sum();
        }
    }
}

// CONSOLE APP RESPONSIBILITIES
// Outputting and getting information

/*// Get the sum of the 4 smallest values in a user-submitted list
static void Main(string[] args)
// if this is the Main method, can we split into other methods?
{
    Console.WriteLine("Enter a list of numbers, separated by a comma:"); // instruct user for input of list of numbers
    var input = Console.ReadLine(); // read input

    string[] splitInput = input.Split(','); // split input values

    List<int> nums = new List<int>(); // create empty list

    foreach (var item in splitInput) // for each of the split input values
    {
        nums.Add(Convert.ToInt32(item)); // convert to int and add to nums list
    }

    nums.Sort(); // sort by smallest to greatest with library function

    var smallNums = nums.GetRange(0, 4); // get and store in a list?  the nums in nums at index/position 0-4

    Console.WriteLine(smallNums.Sum()); // output to console the contents of smallNums
*/