using System;

namespace _02_Articles
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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string changeInfo = cmdArgs[1];

                if (command == "Edit")
                {
                    article.Edit(changeInfo);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(changeInfo);
                }
                else if (command == "Rename")
                {
                    article.Rename(changeInfo);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}