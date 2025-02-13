
//Example 1:
//Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
//Output: 4
//Explanation: 9 exists in nums and its index is 4
int ex1 = Search([-1, 0, 3, 5, 9, 12], 9);

//Example 2:
//Input: nums = [-1, 0, 3, 5, 9, 12], target = 2
//Output: -1
//Explanation: 2 does not exist in nums so return -1
int ex2 = Search([-1, 0, 3, 5, 9, 12], 2);

int Search(int[] nums, int target)
{
    int lenArr = nums.Count();
    int lowPos = 0;
    int highPos = lenArr;

    while (lowPos < highPos)
    {
        int middle = (int)((lowPos + highPos) / 2);

        if (nums[middle] == target)
            return middle;

        if (nums[middle] < target)
            lowPos = middle + 1;
        else
            highPos = middle;

    }

    return -1;
}
