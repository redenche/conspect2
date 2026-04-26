using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(D.ReadString());
        }

    }
    public class D
    {
        public static string ReadString()
        {
            string? k = Console.ReadLine();
if( k != null){
return k;
            }else{
                return string.Empty;
            }
    }
}
}