using System;

namespace UpDownCast
{
    static class Extensionmethods
    {
        public static void Customcontains(this string par, string word)
        {
            Console.WriteLine(par.Contains(word));

        }
        public static void Customcontains(this string par, char ch)
        {
            for (int i = 0; i < par.Length; i++)
            {
                if (ch == par[i])
                {
                    Console.WriteLine("char is exist in string ");
                    return;
                }
            }

            Console.WriteLine("char is not exist in string");

        }
        public static void IsPrime(this int num)
        {
            if (num==1)
            {
                Console.WriteLine("hech biri");
            }
            else
            {
                int count = 2;
                for (int i = count; i < num; i++)
                {
                    if (num%i==0)
                    {
                        count++;
                    }
                }
                if (count==2)
                {
                    Console.WriteLine("num is prime");
                    return;
                }
            }
            Console.WriteLine("num is not prime");
        }

    }
}


