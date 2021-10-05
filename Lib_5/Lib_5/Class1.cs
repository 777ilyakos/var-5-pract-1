using System;

namespace Lib_5
{
    public class resh
    {
        /// <summary>
        /// Вычисляет сумму целых случайных чисел, распределенных в диапазоне от Ot до Do,пока эта сумма не превышает некоторого числа SummDo
        /// </summary>
        /// <param name="Ot">число для рандома</param>
        /// <param name="Do">число для рандома</param>
        /// <param name="summDo">число которое не должно быть превышено</param>
        /// <param name="generatMas">сгенерированые числа в строковой форме "1 2 3 4 ..."</param>
        /// <param name="kolvoNum">количество сгенеррованых чисел</param>
        /// <param name="summItog">сумма сгенерированых чисел</param>
        public static void GeneretToSumm(int Ot, int Do, int summDo,out string generatMas,out int kolvoNum, out int summItog)
        {
            int a=0;
            summItog = 0;
            kolvoNum = 0;
            generatMas = "";
            Random rnd = new Random();
            do
            {
                a = rnd.Next(Ot, Do);
                if (a+ summItog <= summDo)
                {
                    summItog += a;
                    kolvoNum++;
                    generatMas += " " + a.ToString();
                }
            } while (a + summItog <= summDo);
        }
    }
}
