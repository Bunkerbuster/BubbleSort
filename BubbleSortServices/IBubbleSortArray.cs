namespace BubbleSortServices
{
    public interface IBubbleSortArray
    {
        Task<int[]> SortArray(int[] UnsortedArray);
    }
}