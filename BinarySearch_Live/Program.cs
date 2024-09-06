namespace BinarySearch_Live;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Binary Search!");

        int[] ints = { 1, 45, 56, 78, 95, 32, 79, 22, 44, 81, 62 };
        Array.Sort(ints);

        int tries = BinarySearch(ints, 0, ints.Length, 32);
        Console.WriteLine("Found it at position" + tries);
    }

    public static int BinarySearch(int[] arr, int left, int right, int target)
    {
        if(right >= left)
        {
            int mid = left + ((right - left) / 2);

            if(arr[mid] == target)
            {
                return mid;
            }

            if(arr[mid] > target)
                return BinarySearch(arr, left, mid - 1, target);
            else
            {
                return BinarySearch(arr, mid + 1, right, target);
            }
        }

        return -1;
    }
}
