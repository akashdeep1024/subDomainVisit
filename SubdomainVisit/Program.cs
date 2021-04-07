using System;
using System.Collections.Generic;

namespace SubdomainVisit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] domainString = { "9001 discuss.leetcode.com", "1 yahoo.com" };

            Dictionary<string, int> dictDomain = new Dictionary<string, int>();

            foreach (var domItem in domainString)
            {
                string[] allDomain = domItem.Split();

                string[] domainValues = allDomain[1].Split(".");
                int count = Convert.ToInt32(allDomain[0]);
                string currentDomain = "";

                for (int i = domainValues.Length - 1; i >= 0; i--)
                {
                    currentDomain = domainValues[i] + (i < domainValues.Length - 1 ? "." : "") + currentDomain;

                    if (dictDomain.ContainsKey(currentDomain))
                    {
                        dictDomain[currentDomain] += count;
                    }
                    else
                    {
                        dictDomain.Add(currentDomain, count);
                    }

                }
            }

            List<string> list = new List<string>();
            foreach (var d in dictDomain)
            {
                list.Add(" " + d.Key + " " + d.Value);
            }

            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

        }
    }
}
