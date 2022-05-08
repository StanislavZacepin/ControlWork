using System;

public class CreatNewArry
{
	string textSum = string.Empty;

	public int [] CreatArry(string[] arry)
	{
        for (int i = 0; i < arry.Length; i++)
        {
            if (arry[i].Length <= 3)
            {
                textSum += $"{arry[i]},";
            }
        }          

        return ;
    }
}
