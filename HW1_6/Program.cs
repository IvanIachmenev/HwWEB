using System;

namespace HW_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение.");
            string text = Console.ReadLine() + ' ';
            string words = "";
            string endwords = "";
            int cnt = 0;
            int space = -1;
            foreach(var i in text)
            {
                words += i;
                if(words != "" && i == ' ')
                {
                    //if(i ==)
                    //{
                        endwords += words[words.Length - 2];
                        cnt++;
                        words = "";
                    //}
                }

                if(i == ' ')
                {
                    space++;
                }
            }
            int a = text.Length - space - 1;
            Console.WriteLine($" Количество слов: {cnt}\n Количество символов без проблев {a}" );
            Console.WriteLine($" Слово из последних символо: {endwords}\n Отношение символов к количеству слов: {(a/cnt)}");
        }
    }
}