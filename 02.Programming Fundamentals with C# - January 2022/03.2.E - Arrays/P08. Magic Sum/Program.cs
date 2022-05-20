using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            foreach (int spot in arr)
            {
                if (spot == 4)
                {
                    count++;
                    continue;
                }
                else if (spot == 3)
                {
                    if (people == 0)
                    {
                        count++;
                        break;
                    }
                    
                    arr[count] += 1;
                    people--;

                    count++;

                    if (people == 0)
                    {
                        count++;
                        break;
                    }

                    continue;
                    
                }
                else if (spot == 2)
                {
                    if (people == 0)
                    {
                        count++;
                        break;
                    }
                    
                    if (people == 1)
                    {
                        arr[count] += 1;
                        people--;
                        count++;
                        break;
                    }
                    else if (people == 2)
                    {
                        arr[count] += 2;
                        people -= 2;
                        count++;
                        break;
                    }

                    arr[count] += 2;
                    people -= 2;
                    count++;
                    continue;
                }
                else if (spot == 1)
                {
                    if (people == 0)
                    {
                        count++;
                        break;
                    }

                    if (people == 1)
                    {
                        arr[count] += 1;
                        people--;
                        count++;
                        break;
                    }
                    else if (people == 2)
                    {
                        arr[count] += 2;
                        people -= 2;
                        count++;
                        break;
                    }
                    else if (people == 3)
                    {
                        arr[count] += 3;
                        people -= 3;
                        count++;
                        break;
                    }

                    arr[count] += 3;
                    people -= 3;
                    count++;
                    continue;
                }
                else if (spot == 0)
                {
                    if (people == 0)
                    {
                        count++;
                        break;
                    }

                    if (people == 1)
                    {
                        arr[count] += 1;
                        people--;
                        count++;
                        break;
                    }
                    else if (people == 2)
                    {
                        arr[count] += 2;
                        people -= 2;
                        count++;
                        break;
                    }
                    else if (people == 3)
                    {
                        arr[count] += 3;
                        people -= 3;
                        count++;
                        break;
                    }
                    else if (people == 4)
                    {
                        arr[count] += 4;
                        people -= 4;
                        count++;
                        break;
                    }

                    arr[count] += 4;
                    people -= 4;
                    count++;
                    continue;
                }
            }

            if (arr.All(w => w == 4) && people == 0)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else if (people == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(' ', arr));
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(' ', arr));
            }
        }
    }
}
