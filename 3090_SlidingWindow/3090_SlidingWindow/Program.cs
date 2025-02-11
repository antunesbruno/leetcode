// See https://aka.ms/new-console-template for more information

//teste case 1
//Input: s = "bcbbbcba"
//Output: 4
Console.WriteLine("Result1: "+ maximumLengthSubstring("bcbbbcba"));

//Input: s = "aaaa"
//Output: 2
Console.WriteLine("Result2: " + maximumLengthSubstring("aaaa"));

//Input: s = "bbbab"
//Output: 3
Console.WriteLine("Result3: " + maximumLengthSubstring("bbbab"));

int maximumLengthSubstring(string s)
{
    int rigth = 0;
    int left = 0;    
    int max = 1;
    Dictionary<string, int> dicSub = new Dictionary<string, int>();
    dicSub.Add(s[0].ToString(), 1);

    while (rigth < s.Length-1)
    {
        rigth++;

        if (dicSub.ContainsKey(s[rigth].ToString()))
        {
            string letterR = s[rigth].ToString();
            dicSub[letterR] = dicSub[letterR] + 1;
        }
        else
        {
            dicSub.Add(s[rigth].ToString(), 1);
        }

        while (dicSub[s[rigth].ToString()] == 3)
        {
            string letterL = s[left].ToString();
            dicSub[letterL] = dicSub[letterL] - 1;
            left++;
        }

        max = Math.Max(max, rigth - left + 1);     
    }

    return max;
}

