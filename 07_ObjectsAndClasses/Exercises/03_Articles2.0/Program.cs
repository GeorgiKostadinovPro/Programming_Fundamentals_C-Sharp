using System;
using System.Linq;

namespace _03_Articles02
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Article[] articles = new Article[n];

            for (int i = 0; i < n; i++)
            {
                string[] articleInfo = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articleInfo[0];
                string content = articleInfo[1];
                string author = articleInfo[2];

                Article article = new Article(title, content, author);
                articles[i] = article;
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToArray();
            }
            else if (orderCriteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToArray();
            }
            else if (orderCriteria == "author")
            { 
                articles = articles.OrderBy(a => a.Author).ToArray();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}