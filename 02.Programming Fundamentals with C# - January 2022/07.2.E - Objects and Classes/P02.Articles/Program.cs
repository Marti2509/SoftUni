using System;

namespace P02.Articles
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string originalArticle = Console.ReadLine();

            string title = originalArticle.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
            string content = originalArticle.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
            string author = originalArticle.Split(", ", StringSplitOptions.RemoveEmptyEntries)[2];

            Article newArticle = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];

                if (command == "Edit:")
                {
                    string newContent = string.Empty;

                    for (int j = 1; j < line.Length; j++)
                    {
                        newContent += line[j] + " ";
                    }

                    newContent = newContent.TrimEnd();

                    newArticle.Edit(newContent);
                }
                else if (command == "ChangeAuthor:")
                {
                    string newAuthor = string.Empty;

                    for (int j = 1; j < line.Length; j++)
                    {
                        newAuthor += line[j] + " ";
                    }

                    newAuthor = newAuthor.TrimEnd();

                    newArticle.ChangeAuthor(newAuthor);
                }
                else
                {
                    string newName = string.Empty;

                    for (int j = 1; j < line.Length; j++)
                    {
                        newName += line[j] + " ";
                    }

                    newName = newName.TrimEnd();

                    newArticle.Rename(newName);
                }
            }

            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
    }
}
