//у меня есть книга по обучению c# но там объясняеться в мамом начале взаимордействие с констркторами класами насоледованием и прочим, но практики почти нет
// а большинство курсов по c# на ютубе ну прям как будто для детей делались
//я решил то что просто буду брать там задания и выполнять их паррарельно ситая книгу
//программа принимает значение высоты треугольников и выводит их в консоль

using System;

class Hh
{
    static void Main
    (){
        kirieshki:
        Console.Write("Введи значение высоты треугольника: ");
   string svisota = Console.ReadLine();
int karapuz = Convert.ToInt32(svisota) ;
if (karapuz > 120)
        {
            Console.WriteLine("слишком большое значение, максимум 120");
goto kirieshki;
        }
               karapuz += 1;
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
