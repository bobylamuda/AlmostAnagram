using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static Dictionary<string, string> dicTempString = new Dictionary<string, string>();
    public static void Main()
    {
        List<string> lstString = new List<string>();
        lstString.Add("race");
        lstString.Add("beat");
        lstString.Add("brass");
        lstString.Add("grass");
        lstString.Add("sabre");
        lstString.Add("back");
        lstString.Add("chat");
        lstString.Add("cabs");
        lstString.Add("saga");
        lstString.Add("pack");

        int i = 0;
        foreach (string str in lstString)
        {
            i = FindAlmostAnagram(str, lstString);
            Console.WriteLine("{0} {1}", str, i);
        }

        Console.ReadLine();
    }

    private static int FindAlmostAnagram(string strInput, List<string> lstString)
    {
        int result = 0;
        int iToleransi = 1;
        List<int> lstResult = new List<int>();

        List<char> lstCInput = strInput.ToCharArray().ToList();

        foreach (string str in lstString)
        {
            if (strInput.Length != str.Length) continue;
            if (strInput == str)
            {
                if (dicTempString.ContainsKey(str))
                {
                    result = iToleransi;
                    return result;
                }

                continue;
            }

            List<char> lstCStr = str.ToCharArray().ToList();
            foreach (char c in lstCStr.Where(x => !lstCInput.Contains(x)))
            {
                iToleransi++;
                if (iToleransi > 2)
                {
                    iToleransi = 1;
                    break;
                }
            }

            if (iToleransi > 1)
            {
                if (!dicTempString.ContainsKey(str))
                {
                    dicTempString.Add(str, str);
                }

                lstResult.Add(iToleransi);
            }

            iToleransi = 1;
        }

        if (lstResult.Count > 0)
        {
            result = lstResult.Max();
        }

        return result;
    }
}