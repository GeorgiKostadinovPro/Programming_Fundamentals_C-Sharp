using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CompanyUsers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] info = line
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = info[0];
                string employeeId = info[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                companies[company].Add(employeeId);
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                company.Value
                    .Distinct()
                    .ToList()
                    .ForEach(e => Console.WriteLine($"-- {e}"));
            }
        }
    }
}