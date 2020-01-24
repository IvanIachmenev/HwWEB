using System;

namespace SixthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            string[] textArray = s.Split(' ');

            int countWord = 0;

            for (int i = 0; i < textArray.Length; i++)
            {

                if (char.IsLetter(textArray[i], 0))
                {
                    countWord++;
                }
            }
            Console.WriteLine("кол-во слов: " + countWord);

            int countSymbol = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    countSymbol++;
                }
            }

            Console.WriteLine("кол-во символов: " + countSymbol);
            Console.WriteLine("Соотношение количество символов без пробелов к количеству слов:" + Math.Round((double)countSymbol / countWord, 2));

            string newWord = "";
            for (int i = 0; i < textArray.Length; i++)
            {
                string buf = textArray[i];
                if (char.IsLetter(textArray[i], 0))
                {
                    int j = 1;
                    while (!char.IsLetter(buf[buf.Length - j]))
                    {
                        j++;
                    }
                    newWord = newWord + buf[buf.Length - j];
                }
            }
            Console.WriteLine("кол-во символов: " + newWord);
        }
    }
}