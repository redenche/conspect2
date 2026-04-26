/*
тут я воссоздал то что видел у одного блогера
раньше циклов не было и использовали это

*/


using System;
using System.ComponentModel.DataAnnotations.Schema;

class Ij
{
    static void Main()
    {
    //for = goto
    int i = 0;
    ForK:
    if (i < 5)
        {
     
            i++;
                   Console.WriteLine(i);
             goto ForK;
        }
    }
}
