using System;

namespace LogicalPrograms_v2
{
    class Program
    {
        static void Main(string[] args)
        {
        reapeat:
            Console.WriteLine("1: ReverseStinrg");
            Console.WriteLine("2: Palidrome String");
            Console.WriteLine("3: Word Reverse in String");
            Console.WriteLine("Please Enter Option Number");
            var option = Console.ReadLine();
            Console.WriteLine("Enter text.");
            var val = Console.ReadLine();
            var exit = true;


            switch (option)
            {
                case "1":
                    PrintResult(LogicalPrograms.ReverseSting(val));
                    if (WantToRepeat())
                    {
                        goto reapeat;
                    }
                    break;
                case "2":
                    var isPalidrome = LogicalPrograms.PalidromeString(val);
                    PrintResult(isPalidrome ? $"Entered string {val} is Palidrome" : $"Entered string {val} is NOT Palidrome");
                    if (WantToRepeat())
                    {
                        goto reapeat;
                    }
                    break;
                case "3":
                    PrintResult(LogicalPrograms.ReverseWordInString(val));
                    if (WantToRepeat())
                    {
                        goto reapeat;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Option..........!");
                    break;

            }

        }

        public static bool WantToRepeat()
        {
            Console.WriteLine("Do you want to to run again(Y/N) ?");
            var val = Console.ReadLine();
            return val == "Y" ? true : false;

        }

        public static void PrintResult(string result)
        {
            Console.WriteLine("+++++++++++++++<<<<<  OUTPUT  >>>>>+++++++++++++++++");
            Console.WriteLine(result);
            Console.WriteLine("+++++++++++++++<<<<<  END OF OUTPUT  >>>>>+++++++++++++++++");
        }
    }


    class LogicalPrograms
    {

        public static string ReverseSting(string str)
        {

            var numberOfLoop = str.Length / 2;
            var strChrArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < numberOfLoop; i++, j--)
            {
                var temp = strChrArray[i];
                strChrArray[i] = strChrArray[j];
                strChrArray[j] = temp;
            }

            var reverseString = new String(strChrArray);
            return reverseString;
        }

        public static bool PalidromeString(string str)
        {
            var numOfLoop = str.Length / 2;
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }

            return true;
        }

        public static string ReverseWordInString(string str)
        {
            var wordArray = str.Split(" ");
            //Length of loop 
            var loopLength = wordArray.Length / 2;
            for (int i = 0, j = wordArray.Length - 1;
                i < loopLength;
                i++, j--)
            {
                var temp = wordArray[i];
                wordArray[i] = wordArray[j];
                wordArray[j] = temp;
            }
            return string.Join(" ", wordArray);
        }

    }
}
