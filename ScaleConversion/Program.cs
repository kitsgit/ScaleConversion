using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the scale : ");
            string s = Console.ReadLine().ToLower();
            int[] ar = new int[20];
            int j = 0;
            char c2 = '.';
            for(int i=0;i<s.Length;i++)
            {
                char c1 = s[i];
                if (i < s.Length - 1)
                {
                    c2 = s[i + 1];
                }
                if (c2 == '+')
                {
                    char c3 = s[i + 2];
                    if ((c1=='w' && c3=='h') || (c1 == 'h' && c3 == 'w'))
                    {
                        ar[j] = 3;
                        j++;
                    }
                    else if (c1 == 'w' && c3 == 'w')
                    {
                        ar[j] = 4;
                        j++;
                    }
                    else if (c1 == 'h' && c3 == 'h')
                    {
                        ar[j] = 2;
                        j++;
                    }
                    i += 2;
                }         
                else
                {
                    if (c1 == 'w')
                    {
                        ar[j] = 2;
                        j++;
                    }
                    else if (c1 == 'h')
                    {
                        ar[j] = 1;
                        j++;
                    }
                }
                
            }
            for (int i=0;i<j;i++)
            {
                Console.Write(ar[i]);
            }
            Console.ReadLine();
        }
    }
}
