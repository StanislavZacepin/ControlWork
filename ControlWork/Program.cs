﻿using System;
using ControlWork.Services;


namespace ControlWork
{
    internal static class Program
    {
        /// <summary>
        /// Массив отправляем в функцию 
        /// </summary>
        public static void Main()
        {
            string[] arry = new string[] { "asdasd", "123", "asd", "тан", "эх", "=)", "...." };
            
            string[] NewArry = ControlWork.Services.CreatNewArry.CreatArry(arry);

           
        }
    }

    #region Задание
    /*Итоговая проверочная работа.

    Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения
    на программе разработчик. Мы должны убедиться что базовое знакомство с # прошло успешно.

    Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:

    1.Создать репозиторий на СИНиь

    2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы
    выделяете ее в отдельный метод)

    3.Снабдить репозиторий оформленным текстовым описанием решения (файл ВКЕАОМЕ.т4)

    4.Написать программу, решающую поставленную задачу

    5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито
    одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

    Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
    меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
    выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
    исключительно массивами.*/
    #endregion
}
