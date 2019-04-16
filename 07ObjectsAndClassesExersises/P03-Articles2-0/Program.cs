using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Articles2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            List<Article> sortedArticles = new List<Article>();
            string sortingMethod = Console.ReadLine();
            if (sortingMethod == "title")
            {
                sortedArticles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (sortingMethod == "content")
            {
                sortedArticles = articles.OrderBy(a => a.Content).ToList();
            }
            else if (sortingMethod == "author")
            {
                sortedArticles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (var article in sortedArticles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article()
        {

        }

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
            return $"{Title} - {Content}: {Author}";
        }
    }
}
