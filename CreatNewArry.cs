using System;

namespace ControlWork.Service
{
    public static class CreatNewArry
    {
        string textSum = string.Empty;

        public static int[] CreatArry(string[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i].Length <= 3)
                {
                    textSum += $"{arry[i]},";
                }
            }

            string[] NewArry = textSum.Split(",", StringSplitOptions.RemoveEmptyEntries);

            return NewArry;
        }
    }

}

