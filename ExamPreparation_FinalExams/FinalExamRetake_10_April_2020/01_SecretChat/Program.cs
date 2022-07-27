using System;

namespace _01_SecretChat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Reveal")
            {
                string[] cmds = line
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmds[0];

                if (cmd == "InsertSpace")
                {
                    int index = int.Parse(cmds[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (cmd == "Reverse")
                {
                    string subString = cmds[1];

                    if (message.Contains(subString))
                    {
                        int firstIndex = message.IndexOf(subString[0]);

                        message = message.Remove(firstIndex, subString.Length);

                        string reversed = string.Empty;

                        for (int i = subString.Length - 1; i >= 0; i--)
                        {
                            reversed += subString[i];
                        }

                        message = message.Insert(message.Length, reversed);

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "ChangeAll")
                {
                    string subString = cmds[1];
                    string newString = cmds[2];

                    message = message.Replace(subString, newString);
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
