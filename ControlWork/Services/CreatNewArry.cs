using System;

namespace ControlWork.Services
{
    public static  class CreatNewArry
    {
       static string textSum = string.Empty;

        /// <summary>
        /// Создания пустой строки. Походя масив. Проверя его  если в масиве элементы из 3 или меньше символов.
        ///Если услови совпадают. Добавляем элемент состоящий из 3 и менее символов в пустую строку и добавляем ",".
        ///Строку раздилаем и делаем масив . разделитель для слов ",".
        ///Возвращаем массив
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static  string [] CreatArry(string[] arry)
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

