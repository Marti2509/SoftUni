namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                uint lineNum = 0;
                using (var writer = new StreamWriter(outputFilePath))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null) break;

                        if (lineNum % 2 == 1)
                            writer.WriteLine(line);

                        lineNum++;
                    }
                }
            }
        }
    }
}
