﻿namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                using (var writer = new StreamWriter(outputFilePath))
                {
                    uint lineNum = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null) break;

                        writer.WriteLine($"{lineNum}. {line}");

                        lineNum++;
                    }
                }
            }
        }
    }
}
