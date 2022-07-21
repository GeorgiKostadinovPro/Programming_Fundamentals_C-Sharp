using System;
using System.Text;

namespace _05_HTML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder sb  = new StringBuilder();    
            sb.AppendLine("<h1>");
            sb.AppendLine($"    {title}");
            sb.AppendLine("</h1>");

            sb.AppendLine("<article>");
            sb.AppendLine($"    {content}");
            sb.AppendLine("</article>");

            string line = string.Empty;

            while((line = Console.ReadLine()) != "end of comments")
            {
                string comment = line;

                sb.AppendLine("<div>");
                sb.AppendLine($"    {comment}");
                sb.AppendLine("</div>");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}