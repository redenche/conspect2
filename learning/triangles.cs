using System;

class Hh
{
    static void Main
    (){
        kirieshki:
        Console.Write("Введи значение высоты треугольника: ");
   string svisota = Console.ReadLine();
int karapuz = Convert.ToInt32(svisota) + 1;
if (karapuz > 120)
        {
            Console.WriteLine("слишком большое значение, максимум 120");
goto kirieshki;
        }
  string[] ix = new string[karapuz];
  int i=1;
     Console.WriteLine("");
  for(; i < karapuz; i++)
        {
            ix[i] =ix[i-1]+ "@";
            Console.WriteLine(ix[i]);
        }
                    Console.WriteLine("");
          for(; i <= karapuz; i--)
        {
            if(i == 0)
            {
                break;
            }
            Console.WriteLine(ix[i-1]);
        }
        Console.Read();
    }

    

}