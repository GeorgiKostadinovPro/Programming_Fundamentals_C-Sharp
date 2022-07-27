using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ThePianist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pieceInfo = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieces.Add(piece, new List<string>() { composer, key });
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = line
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];
                string piece = cmdArgs[1];

                if (cmd == "Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (cmd == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmd == "ChangeKey")
                {
                    string newKey = cmdArgs[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
