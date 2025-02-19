int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 18, 19, 20, 23, 24, 25, 28, 29, 30, 31, 32, 33, 35, 37, 39, 40, 45, 46, 47, 48, 49, 50, 52, 53, 55, 57, 58, 59, 60, 63, 64, 65, 67, 69, 71 };
int target = 35;

int result = ExponencialSearch(arr, target);

Console.WriteLine("Result is: " + result);

int ExponencialSearch(int[] arr, int target)
{
    int rigth = 1;
    int arrLen = arr.Length - 1;

    if (arr[0] == target)
        return target;

    while (rigth <= (arrLen - 1))
    {
        if (arr[rigth] == target)
            return target;

        rigth *= 2;
    }

    rigth = Math.Min(rigth, arrLen);

    return BinarySearch(arr, target, rigth / 2, rigth);
}

int BinarySearch(int[] arr, int target, int left, int right)
{
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target)
            return target;
        if (arr[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }
    return -1;
}
