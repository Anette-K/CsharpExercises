using System;

namespace Working_With_Strings1
{
    class Program
    {
        public static string Reverse1(string user_string)
        { //using Array method

            char[] user_array = user_string.ToCharArray();
            Array.Reverse(user_array);
            return new string(user_array);
        }

        public static string Reverse2(string user_string)
        { // using iteration.

            char[] user_array = new char[user_string.Length];
            int counter = 0;
            for (int i = user_string.Length - 1; i >= 0; i--)
            {
                user_array[counter++] = user_string[i];
            }
            return new string(user_array);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Write your input");
            var user_string = Console.ReadLine();
            Console.WriteLine($"Here is your input: {user_string}"); 

            Console.WriteLine($"Input reversed using reverse1: {Reverse1(user_string)}");
            Console.WriteLine($"Input reversed using reverse2: {Reverse2(user_string)}");


        }
    }
}
