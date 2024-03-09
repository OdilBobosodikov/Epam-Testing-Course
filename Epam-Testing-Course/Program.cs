
namespace Epam_Testing_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                string[] userLineInput = args.Skip(1).ToArray();

                int[] unequalCharLengths = MaxUnequalConsecutive(userLineInput);


                for (int i = 0; i < unequalCharLengths.Length; i++)
                {
                    Console.WriteLine($"{i} line: word is {userLineInput[i]},  number of unequal consecutive characters is {unequalCharLengths[i]}");
                }
                
            }
            else
            {
                Console.WriteLine("There are no argument lines!");
            }
        }

        private static int[] MaxUnequalConsecutive(string[] userLineInput)
        {
            List<int> maximumChars = new();

            int maxCharCount = 1;
            int curCharCount = 1;

            foreach (var str in userLineInput)
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] != str[i - 1])
                    {
                        curCharCount++;
                        maxCharCount = Math.Max(maxCharCount, curCharCount);
                        continue;
                    }
                    curCharCount = 1;
                }
                maximumChars.Add(maxCharCount);
                maxCharCount = 1;
                curCharCount = 1;
            }

            return maximumChars.ToArray();
        }
    }
}
