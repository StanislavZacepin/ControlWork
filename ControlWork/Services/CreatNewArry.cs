﻿using System;

namespace ControlWork.Services
{
    public  class CreatNewArry
    {
        string textSum = string.Empty;

        public  string [] CreatArry(string[] arry)
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
