namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            List<string> words = new List<string>();
            Dictionary<string, uint> dic = new Dictionary<string, uint>();

            using (var inputWords = new StreamReader(wordsFilePath))
            {
                while (true)
                {
                    string line = inputWords.ReadLine();

                    if (line == null) break;

                    string[] wordsLine = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    words.AddRange(wordsLine);
                }
            }

            foreach (string word in words)
            {
                dic.TryAdd(word, 0);
            }

            using (var text = new StreamReader(textFilePath))
            {
                char[] trim = new char[] { ' ', ',', '-', '.', '!', '?' };

                while (true)
                {
                    string line = text.ReadLine();

                    if (line == null) break;

                    string[] lineWords = line.ToLower().Split(new string[] { ",", " ", ".", "!", "?", "-", "...", "?!" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in lineWords)
                    {
                        if (dic.ContainsKey(word))
                            dic[word]++;
                    }
                }
            }

            using (var output = new StreamWriter(outputFilePath))
            {
                var ordered = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in ordered)
                {
                    output.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
