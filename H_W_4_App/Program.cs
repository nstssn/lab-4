namespace H_W_4_App
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Start point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Start of app.
        /// </summary>
        /// <param name="args">args added ...</param>
        public static void Main(string[] args)
        {
            Console.Write("Size ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            List<object> even = new List<object>();
            List<object> odd = new List<object>();
            List<char> list = new List<char>();
            int counterEv = 0;
            int counterOdd = 0;
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(1, 26);
                Console.Write($"{nums[i]} ");
                if (nums[i] % 2 == 0)
                {
                    even.Add(alphabet[nums[i]]);
                }
                else
                {
                    odd.Add(alphabet[nums[i]]);
                }
            }

            Console.WriteLine();

            foreach (char c in even)
            {
                if (c == 'a' || c == 'e' || c == 'i')
                {
                    Console.Write($"{char.ToUpper(c)} ");
                    counterEv++;
                }
                else
                {
                    Console.Write($"{c} ");
                }
            }

            Console.WriteLine();
            foreach (char c in odd)
            {
                if (c == 'd' || c == 'h' || c == 'j')
                {
                    Console.Write($"{char.ToUpper(c)} ");
                    counterOdd++;
                }
                else
                {
                    Console.Write($"{c} ");
                }
            }

            Console.WriteLine();

            if (counterOdd < counterEv)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("There are more capital letters in an even list");
                Console.ResetColor();
            }
            else if (counterOdd > counterEv)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("There are more capital letters in an odd list");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Even and odd lists have the same number of capital letters");
            }
        }
    }
}