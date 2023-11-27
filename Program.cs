using ConsoleApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
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
        lstString.Add("lack");
        lstString.Add("chgt");

        IAlmostAnagram service = new AlmostAnagram(lstString);
        int i = 0;
        foreach (string str in lstString)
        {
            i = service.FindAlmostAnagram(str);
            Console.WriteLine("{0} {1}", str, i);
        }

        Console.ReadLine();
    }

}