using System;
using System.Linq;
using DynamicLink;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // A text is printed to consol demanding a number
            Console.WriteLine("Write the number of Inexes you wish to test");
            //the input provided is passed into an array
            int indexes = Convert.ToInt32(Console.ReadLine());
            //instantiate an object of array
            int[] Array = new int[indexes];
            //using a method prepare to randomize array
            Array = Class1.Prepare(Array, indexes);
            
            //prints out and presents alernitives
            Console.WriteLine("Choose your algorihm!\n\n\n" +
                "For Bubble Sort, type: 1\n\n" +
                "For Selection Sort, type: 2\n\n" +
                "For Quick Selection Sort, type: 3\n\n" +
                "For Merge Sort, type: 4\n\n" +
                "For insertion Sort, type: 5\n\n" +
                "For Lambda sort, type 6 ");



            //the ipnut provided is passed into an object inpudData
            int inputData = Convert.ToInt32(Console.ReadLine());
            //new objact has been created and passed in value
            int selected = inputData;
            
            //Using Switched Statements
            switch (selected)
            {
                //if 1 has been chosen
                case 1:
                    //prints out to the consol
                    Console.WriteLine(" You choosed Buuble Sort!");
                    //starts measuring time while calling the method SortBubble and using "Array" 
                    DateTime startTime = DateTime.Now;
                    Class1.SortBubble(Array);
                    //stops measuring time
                    TimeSpan finishTime = DateTime.Now - startTime;
                    //prints out sorted array and measured time  
                    Console.WriteLine("[{0}]", string.Join(", ", Array));
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishTime.TotalMilliseconds);
                    break;
                // same as in case 1 !!!
                case 2:
                    Console.WriteLine(" You choosed Selection Sort!");
                    DateTime startTimeSelection = DateTime.Now;
                    Class1.SelectionSort(Array);
                    TimeSpan finishTimeSelection = DateTime.Now - startTimeSelection;
                    Console.WriteLine("[{0}]", string.Join(", ", Array));
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishTimeSelection.TotalMilliseconds);
                    break;
                // same as in case 1 !!!
                case 3:
                    Console.WriteLine(" You choosed Quick Selection Sort!");
                    DateTime startTimeQuickSelection = DateTime.Now;
                    Class1.QuickSort(Array, 0, Array.Length - 1);
                    TimeSpan finishQuickTimeSelection = DateTime.Now - startTimeQuickSelection;
                    Console.WriteLine("[{0}]", string.Join(", ", Array));
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishQuickTimeSelection.TotalMilliseconds);
                    break;
                // same as in case 1 !!!
                case 4:
                    Console.WriteLine(" You choosed Merge Sort!");
                    DateTime startTimeMerge = DateTime.Now;
                    int len = Array.Length;
                    Console.WriteLine("MergeSort:");

                    Class1.SortMethod(Array, 0, len - 1);

                    for (int i = 0; i < Array.Length; i++)
                        Console.WriteLine(Array[i]);
                    TimeSpan finishMerge = DateTime.Now - startTimeMerge;
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishMerge.TotalMilliseconds);
                    break;
                // same as in case 1 !!!
                case 5:
                    Console.WriteLine(" You choosed Insertion Sort!");
                    DateTime startTimeInsertion = DateTime.Now;
                    Class1.InsertionSort(Array);
                    Console.WriteLine("[{0}]", string.Join(", ", Array));
                    TimeSpan finishInsertion = DateTime.Now - startTimeInsertion;
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishInsertion.TotalMilliseconds);
                    break;
                case 6:
                    Console.WriteLine(" You choosed lambda Sort!");
                    DateTime startTimeLambda = DateTime.Now;
                    var arrayLambda = Array.OrderBy(x => x);
                    Console.WriteLine("[{0}]", string.Join(", ", arrayLambda));
                    TimeSpan finishLambda = DateTime.Now - startTimeLambda;
                    Console.WriteLine("It took {0:0.00} ms too sort.\n", finishLambda.TotalMilliseconds);

                    break;

            }
        }
    }
}
                    




            











        

        



















