using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _872
{
    class Program
    {
        public static int max = 1;
        static void ArrCheck(int n,string word,int number,string[] strs)
        {
            bool finded = false;
            for(int i = 0; i < n; i++)
            {
                string s = strs[i];
                bool ok = true;
                int j = 0;
                if (s.Length > word.Length)
                {
                    while ((j < word.Length) & (j < s.Length) & (ok))
                    {
                        if (word[j] != s[j])
                        {
                            ok = false;
                        }
                        j++;
                    }
                    if (ok)
                    {
                        if (s.Length > word.Length)
                        {

                            finded = true;
                            ArrCheck(n, s, number + 1, strs);
                        }
                    }
                }
                
            }
            if (finded == false)
            {
                if (number > max) max = number;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] wrd = new string[n];
            for(int i = 0; i < n; i++)
            {
                wrd[i] = Console.ReadLine();
            }
            for(int i = 0; i < n; i++)
            {
                ArrCheck(n, wrd[i], 1, wrd);
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
