using System;

namespace _01_AdvertisementMessage
{
    public class Message
    {
        public Message(string phrase, string @event, string author, string city)
        {
            this.Phrase = phrase;
            this.Event = @event;
            this.Author = author;
            this.City = city;
        }
        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{this.Phrase} {this.Event} {this.Author} – {this.City}.";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            Message[] messages = new Message[n];

            Random random = new Random();
           
            for (int i = 0; i < n; i++)
            {
                int phraseIdx = random.Next(0, phrases.Length - 1);
                int eventIdx = random.Next(0, events.Length - 1);
                int authorIdx = random.Next(0, authors.Length - 1);
                int cityIdx = random.Next(0, cities.Length - 1);

                string phrase = phrases[phraseIdx];
                string @event = events[eventIdx];
                string author = authors[authorIdx];
                string city = cities[cityIdx];

                Message message = new Message(phrase, @event, author, city);
                messages[i] = message;
            }

            foreach (var message in messages)
            {
                Console.WriteLine(message.ToString());
            }
        }
    }
}