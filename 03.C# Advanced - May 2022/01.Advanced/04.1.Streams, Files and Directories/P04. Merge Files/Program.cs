namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (var firstFile = new StreamReader(firstInputFilePath))
            {
                using (var secondFile = new StreamReader(secondInputFilePath))
                {
                    using (var outputFile = new StreamWriter(outputFilePath))
                    {
                        while (true)
                        {
                            string lineFirst = firstFile.ReadLine();
                            string lineSecond = secondFile.ReadLine();

                            if (lineFirst == null && lineSecond == null) break;

                            outputFile.WriteLine(lineFirst);
                            outputFile.WriteLine(lineSecond);
                        }
                    }
                }
            }
        }
    }
}
