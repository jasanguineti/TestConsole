using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lOutput = subStringsKDist("awaglknagawunaglkwaglawaglknagawunaglkwagl", 4);

            foreach (string item in lOutput)
            {
                Console.WriteLine(item);
            }
        }


        public static List<string> subStringsKDist(string inputStr, int num)
        {
            List<string> lString = sDistinct(inputStr);

            List<string> lReturn = new List<string>();
            int nLen = inputStr.Length;
            int nCount=0, nInterv =0, nStart = 0;
            if (nLen < 0 || nLen >= 26)
            {
                Console.WriteLine("Invalid number of characters");
                return ;
            }
            string sRet = "";
            do
            {
                for (int i = 0; i < lString.Count; i++)
                {

                    sRet += lString[i+nInterv];
                    nStart++;
                    nCount++;
                    if (nCount == num)
                    {
                        nInterv++;
                        nCount = 0;
                        lReturn.Add(sRet);
                        sRet = "";
                        if (lString.Count < nInterv + num) nInterv = num;
                        break;
                    }

                }

            } while (nInterv < num);
            


            return lReturn;

        }

        public static List<string> sDistinct(string input)
        {
            int nLen = input.Length;
            List<string> lReturn = new List<string>();
            for (int i = 0; i < nLen; i++)
            {
                if (lReturn.Contains(input.Substring(i, 1))) continue;
                lReturn.Add(input.Substring(i, 1));
            }

            return lReturn;
        }

    }
}
