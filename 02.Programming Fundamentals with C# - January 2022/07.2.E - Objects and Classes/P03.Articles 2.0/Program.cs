using System;
using System.Collections.Generic;

namespace P03.Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = article[0];
                string content = article[1];
                string author = article[2];

                Article newArticle = new Article(title, content, author);

                articles.Add(newArticle);
            }

            string command = Console.ReadLine();

            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}
