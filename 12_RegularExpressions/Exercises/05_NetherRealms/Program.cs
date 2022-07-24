using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05_NetherRealms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *");

            Regex healthRegex = new Regex(@"[^+\-*/.\d]");

            Regex damageRegex = new Regex(@"((|-)\d+\.\d+|(|-)\d+)");

            Dictionary<string, List<double>> demonData = new Dictionary<string, List<double>>();
               
            foreach (var demon in demons.OrderBy(x => x))
            {
                int health = 0;

                var sumChar = healthRegex.Matches(demon).ToArray();

                foreach (var ch in sumChar)
                {
                    health += char.Parse(ch.Value);
                }

                double damage = 0;

                var dmg = damageRegex.Matches(demon).ToArray();

                foreach (var number in dmg)
                {
                    damage += double.Parse(number.Value);
                }

                var mathSymbols = Regex.Matches(demon, @"[\*\/]").ToArray();

                foreach (var symbol in mathSymbols)
                {
                    var mathOperation = symbol.Value == "*" ? damage *= 2 : damage /= 2;
                }

                demonData[demon] = new List<double>() { health, damage };
            }

            foreach (var demon in demonData)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:F2} damage");
            }
        }
    }
}