/*
Написал небольшую игру которую я писал и на go в одном лишь отличии что тут нет проверки на тип принимаемого значения
теперь он автоматически закрываеться при введении не правильного значения
*/


using System;
using System.Security.Cryptography;

class Hg
{
    static void Main(){

   bool game = true;


   Random h2 = new Random();
   int h3 = h2.Next(0,101);

Console.WriteLine("Я загадал число от 0 до 100 \n попробуй отгадать \n попыток 6");
        for (int i = 5; game; i--)
        {

       Console.Write(">");
    string? k = Console.ReadLine(); 
    int h = Convert.ToInt32(k);

            if(h < h3)
            {

            Console.WriteLine("загаданное число меньше \n количество попыток: "+ i.ToString());

            }else if (h > h3)
            {

                Console.WriteLine("загаданное число больше \n количество попыток: "+ i.ToString());

            }
            else
            {

                     Console.WriteLine("ты угадал, загаданное число: " + h3.ToString());
                     break;

            }


            if(i == 0)
            {

                Console.WriteLine("ты проиграл, загаданное число: " + h3.ToString());
                break;

            }
        }
    }
}
