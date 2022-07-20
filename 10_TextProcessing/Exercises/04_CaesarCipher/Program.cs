using System;

namespace _04_CaesarCipher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string encryptedMessage = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                int asciiCode = message[i];
                asciiCode += 3;

                encryptedMessage += Convert.ToChar(asciiCode);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}