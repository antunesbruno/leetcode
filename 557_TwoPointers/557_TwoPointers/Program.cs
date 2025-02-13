
//Example 1:
//Input: s = "Let's take LeetCode contest"
//Output: "s'teL ekat edoCteeL tsetnoc"
string ex1 = ReverseWords("Let's take LeetCode contest");

//Example 2:
//Input: s = "Mr Ding"
//Output: "rM gniD"
string ex2 = ReverseWords("Mr Ding");

string ReverseWords(string s)
{

    int posL = 0;
    int posR = 0;
    char[] strChar = s.ToCharArray();
    int len = s.Count();

    for (int i = 0; i < len; i++)
    {
        if ((strChar[i].Equals((char)32)) || (i == (len - 1)))
        {
            int startIdx = posL;
            int endIdx = i == (len - 1) ? i : (i - 1);

            while (startIdx < endIdx)
            {
                char temp = strChar[startIdx];
                strChar[startIdx] = strChar[endIdx];
                strChar[endIdx] = temp;

                startIdx++;
                endIdx--;
            }

            posR = posL = i + 1;
        }
    }

    return new string(strChar);
}
