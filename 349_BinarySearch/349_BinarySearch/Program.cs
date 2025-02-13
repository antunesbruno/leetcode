//Example 1:
//Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
//Output: [2]
int[] ex1 = Intersection([1, 2, 2, 1], [2, 2]);


//Example 2:
//Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
//Output: [9, 4]
//Explanation: [4, 9] is also accepted.
int[] ex2 = Intersection([4, 9, 5], [9, 4, 9, 8, 4]);

int[] Intersection(int[] nums1, int[] nums2)
{

    List<int> intersec = new List<int>();
    int k = 0;
    int z = 0;
    int lenNums1 = nums1.Count();
    int lenNums2 = nums2.Count();

    for (int i = 0; i < lenNums1; i++)
    {
        k = 0;

        for (int j = 0; j < lenNums2; j++)
        {
            if (nums1[i] == nums2[j])
                k++;
        }

        if (k >= 1)
        {
            z = 0;
            for (int l = 0; l < intersec.Count(); l++)
            {
                if (intersec[l] == nums1[i])
                    z++;
            }

            if (z == 0)
            {
                intersec.Add(nums1[i]);
            }
        }
    }

    return intersec.ToArray();
}