namespace BubbleSortServices
{
    public class BubbleSortArray : IBubbleSortArray
    {
        private int ArrayLength { get; set; }

        public BubbleSortArray() { }

        public async Task<int[]> SortArray(int[] UnsortedArray)
        {

            // Determine the length of the array, 
            ArrayLength = UnsortedArray.Length;


            // we start the loop with 0
            // and we end the arraylenth -1 (array starts with 0)
            // and every iteration we go 1 up (i++)
            for (int i = 0; i < ArrayLength - 1; i++)
            {
                // For the nested for loop we start the loop with 0
                // and we end the arraylenth -1 (array starts with 0)
                // and every iteration we go 1 up (j++)
                for (int j = 0; j < ArrayLength - i - 1; j++)
                {
                    //if the j value of the array is bigger (J = bigger, then J+1) then the next J value (j  + 1 value) 
                    // {4,3}
                    // we swap the values's
                    //In this case 4 is bigger then 3, en we need to swap these places
                    if (UnsortedArray[j] > UnsortedArray[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        // we create a temp int, so we can place the the swapped value for save keeping
                        // we store int temp = 4
                        int temp = UnsortedArray[j];
                        // we swapping the values, the next value smaller then j > j+1
                        // 4 is replace with 3
                        // j = j+1
                        UnsortedArray[j] = UnsortedArray[j + 1];
                        // we replace the value of j+1 with the value of the temp
                        // j+1 = temp
                        // 3 is replced with 4
                        UnsortedArray[j + 1] = temp;

                        // the result is
                        // {3,4}
                    }
                }
            }
            // return sorted array
            return UnsortedArray;
        }

    }
}