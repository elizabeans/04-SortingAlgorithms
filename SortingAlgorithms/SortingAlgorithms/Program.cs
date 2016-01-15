using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading file..");
            //int[] list = readFromFile();
            int[] list = readFromFile();
            Console.WriteLine("File loaded.");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static int[] readFromFile()
        {
            //implement file read here
            string fileContent = File.ReadAllText(@"C:\dev\data\unsorted-numbers.txt");
            string[] numbersAsString = fileContent.Split(','); //splits by comma
            int[] numbers = new int[numbersAsString.Length]; //creates new array, need to specify length
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsString[i]);
            }
            return numbers;

        }

        static void bubbleSort(int[] list)
        {
            printList("Unsorted List", list);

            //implement bubble sort here
            for(var i = list.Length; i > 0; i--)
            {
                for(var j = 0; j < list.Length - 1; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            printList("Sorted List", list);
        }

        static void insertionSort (int[] list)
        {
            printList("Unsorted List", list);

            // implement insertion sort here
            for(var i = 0; i < list.Length; i++)
            {
                var j = i;
                while(j>0 && (list[j - 1] >list[j]))
                {
                    var temp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = temp;
                    j = j - 1;
                }
            }

            printList("Sorted List", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                if (i == list.Length - 1)
                {
                    Console.Write(list[i]);
                }
                else
                {
                    Console.Write(list[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
