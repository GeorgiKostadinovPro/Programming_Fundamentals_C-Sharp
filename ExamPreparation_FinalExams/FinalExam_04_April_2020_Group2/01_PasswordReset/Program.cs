using System;

namespace _01_PasswordReset
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string line = string.Empty;



            while ((line = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                if (cmd == "TakeOdd")
                {
                    string strOdd = string.Empty;

                    for (int i = 1; i < str.Length; i += 2)
                    {
                        strOdd += str[i];
                    }

                    str = strOdd;

                    Console.WriteLine(str);
                }
                else if (cmd == "Cut")
                {
                    int idx = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    str = str.Remove(idx, length);
                    Console.WriteLine(str);
                }
                else if (cmd == "Substitute")
                {
                    string subStr = cmdArgs[1];
                    string strSubstitute = cmdArgs[2];

                    if (str.Contains(subStr))
                    {
                        str = str.Replace(subStr, strSubstitute);
                        Console.WriteLine(str);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {str}");
        }
    }
}
