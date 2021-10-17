using System;

namespace DynamicLink
{
    public class Class1
    {
       
        //Randomize method

        public static int[] Randomize(int[] myRandArray)
        {
            //creates a new random object
            Random rnd = new Random();
            //condition for loop
            for(int j = 0; j < myRandArray.Length; j++)
            {
                //this randomize array
                myRandArray[j] = rnd.Next(0, myRandArray.Length);
            }
            return myRandArray;
        }



        //Swap method  
        public static void SwapMethod(int[] swapArray, int index1, int index2)
        {
            // First step to put index1 in temperary location
            int tmp = swapArray[index1];

            //Step two to switch places between index1 an index2
            swapArray[index1] = swapArray[index2];

            //Third step to put index2 in temperary location
            swapArray[index2] = tmp;

        }

        //Prepare Mothod
        public static int[] Prepare(int[] data, int SizeOfArray)
        {
            data = new int[SizeOfArray];
            int[] MyArray = Randomize(data);
            return MyArray;
        }

        //BUBBLE SORT
        public static void SortBubble(int[] sortBubleArray)
        {
            //Make a loop for each number to be sorted, cancel if the numbers are sorte
            for (int i = 0; i < sortBubleArray.Length; i++)
            {
                //Signal that we are starting a new loop with sorting
                for (int j = 0; j < sortBubleArray.Length - 1; j++)
                {
                    //Move larger numbers in front in the array
                    if (sortBubleArray[j] > sortBubleArray[j + 1])
                    {
                        //using a SwapMethod to swap two digits
                        SwapMethod(sortBubleArray, j + 1, j);
                    }
                }
            }
        }


        //SELECTION SORT
        public static void SelectionSort(int[] selectionArray)
        {
            //int Min = 0;
            for( int i = 0; i < selectionArray.Length -1; i++)
            {
                int Min = i;
                for(int j = i + 1; j < selectionArray.Length; j++)
                {
                    if(selectionArray[j] < selectionArray[Min])
                    {
                        Min = j;
                    }
                if(Min != i)
                    {
                        SwapMethod(selectionArray, Min, i);
                    }
                   
                }
            }
        }
        //INSERTION SORT
        public static void InsertionSort(int[] insertionsArray)
        {
            int j, temp;
            //Make a loop for each number to be sorted
            //start at index 1 becouse we will look "backwards" in the vector
            for (int i = 1; i <= insertionsArray.Length - 1; i++)
            {
                temp = insertionsArray[i];
                j = i - 1;
                while(j >= 0 && insertionsArray[j] > temp)
                {
                    insertionsArray[j + 1] = insertionsArray[j];
                    j--;
                }
                insertionsArray[j + 1] = temp;
            }
        }

        //MERGE SORT: containes two methods: sortmethod and mergemethod
        
        //SORT METHOD
        public static void SortMethod(int[] numbers, int left, int right)
        {
            //creates an object
            int mid;
            //codition
            if(right > left)
            {
                // passing in the value in object that is middle of an array
                mid = (right + left) / 2;
                //Using a sortMethod to sort left side of array
                SortMethod(numbers, left, mid);
                //Using a sortMethod to sort right side of array
                SortMethod(numbers, (mid + 1), right);
                //using mergeMethod from bellow
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        //MERGE METHOD
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[100];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end) temp[tmp_pos++] = numbers[left++];
            while (mid <= right) temp[tmp_pos++] = numbers[mid++];
            for(i = 0; i < num_elements; i++)
            {
                    numbers[right] = temp[right];
                    right--;
            }
            
        }

        //QUICK SORT
        static public void  QuickSort(int[] quickSortArray, int left, int right)
        {
            //choose a nuber that divides in larger and smaller numbers
            int middlepoint = quickSortArray[(left + right) / 2];

            // define variable for each parameter
            int i = left;
            int j = right;

            //condition for while loop 
            while (i <= j)
            {
                //Find a number in left part that should be in larger part
                while (quickSortArray[i] < middlepoint)
                    i++;

                //Find a number in right side that should be in smaller part
                while (quickSortArray[j] > middlepoint)  
                    j--;


                //if the condition is still the same
                if(i <= j)
                {
                    //change positions
                    SwapMethod(quickSortArray, i, j);
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(quickSortArray, left, j);
            if (i < right)
                QuickSort(quickSortArray, i, right);
        }
    }
}
                    

                    
               
        
               
              
                        
                
                   
