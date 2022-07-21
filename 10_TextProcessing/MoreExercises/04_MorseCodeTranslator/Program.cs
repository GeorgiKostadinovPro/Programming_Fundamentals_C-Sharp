using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MorseCodeTranslator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char dot = '.';
            char dash = '-';

            Dictionary<string, char> morseCodeMapper = new Dictionary<string, char>()
            {
                { string.Concat(dot, dash), 'A' },
                { string.Concat(dash, dot, dot, dot),'B' },
                { string.Concat(dash, dot, dash, dot),'C' },
                { string.Concat(dash, dot, dot) ,'D' },
                { dot.ToString(), 'E' },
                { string.Concat(dot, dot, dash, dot),'F' },
                { string.Concat(dash, dash, dot) ,'G' },
                { string.Concat(dot, dot, dot, dot) ,'H' },
                { string.Concat(dot, dot) ,'I' },
                { string.Concat(dot, dash, dash, dash)  ,'J' },
                { string.Concat(dash, dot, dash) ,'K' },
                { string.Concat(dot, dash, dot, dot) ,'L' },
                { string.Concat(dash, dash) ,'M' },
                { string.Concat(dash, dot) ,'N' },
                { string.Concat(dash, dash, dash),'O' },
                { string.Concat(dot, dash, dash, dot) ,'P' },
                { string.Concat(dash, dash, dot, dash),'Q' },
                { string.Concat(dot, dash, dot),'R' },
                { string.Concat(dot, dot, dot),'S' },
                { string.Concat(dash),'T' },
                { string.Concat(dot, dot, dash),'U' },
                { string.Concat(dot, dot, dot, dash),'V' },
                { string.Concat(dot, dash, dash),'W' },
                { string.Concat(dash, dot, dot, dash),'X' },
                { string.Concat(dash, dot, dash, dash),'Y' },
                { string.Concat(dash, dash, dot, dot),'Z' },
                { string.Concat(dash, dash, dash, dash, dash),'0' },
                { string.Concat(dot, dash, dash, dash, dash),'1' },
                { string.Concat(dot, dot, dash, dash, dash),'2' },
                { string.Concat(dot, dot, dot, dash, dash),'3' },
                { string.Concat(dot, dot, dot, dot, dash),'4' },
                { string.Concat(dot, dot, dot, dot, dot),'5' },
                { string.Concat(dash, dot, dot, dot, dot),'6' },
                { string.Concat(dash, dash, dot, dot, dot),'7' },
                { string.Concat(dash, dash, dash, dot, dot),'8' },
                { string.Concat(dash, dash, dash, dash, dot),'9' },
            };

            List<string> morseCode = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] decodedMessage = new string[morseCode.Count];

            for (int i = 0; i < morseCode.Count; i++)
            {
                string[] innerCodes = morseCode[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < innerCodes.Length; j++)
                {
                   string currCode = innerCodes[j];

                   if (morseCodeMapper.ContainsKey(currCode))
                   {
                        decodedMessage[i] += morseCodeMapper[currCode];
                   }
                }
            }

            Console.WriteLine(string.Join(" ", decodedMessage));
        }
    }
}
