using System;

namespace _01_TheImitationGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = line
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                if (cmd == "Move")
                {
                    int letters = int.Parse(cmdArgs[1]);

                    string subStr = encryptedMessage.Substring(0, letters);
                    encryptedMessage = encryptedMessage.Remove(0, letters);
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, subStr);
                }
                else if (cmd == "Insert")
                {
                    int idx = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    encryptedMessage = encryptedMessage.Insert(idx, value);
                }
                else if (cmd == "ChangeAll")
                {
                    string subStr = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    encryptedMessage = encryptedMessage.Replace(subStr, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
