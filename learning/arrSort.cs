using System;
using System.Reflection.Metadata.Ecma335;

class Gh
{
    static void Main()
    {
        int[] hj = new int[3]{65,82,1};
Jseven l =new Jseven(hj);
l.SortArr();
l.PrintArr();
int[] cuprum = l.getArr();
Console.Write(cuprum[0]);
    }
}
public class Jseven
{
    int[] h;

    public Jseven(int[] hh)
    {
           h = hh;
    }
    public void SortArr()
    {
   
        int leght = h.Length;
        

for(int i = 0; i <= leght; i++)
        {
            for(int j = i + 1;j < leght; j++)
            {
                if(h[i]> h[j])
                {
                    int real = h[i];
                    int next = h[j];
                    h[i] = next;
                    h[j] = real;
                }
            }

        }
    }
    public void PrintArr()
    {
                foreach (var item in h)
        {
            Console.WriteLine(item);
        }

       // Console.WriteLine(h);
    }
    public int[] getArr()
    {
        return h;
    }
}

