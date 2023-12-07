using ConsoleApp2.Services;
using ConsoleApp2.Services.Implementations;
using ConsoleApp2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {

        #region Almost Anagram
        //List<string> lstString = new List<string>();
        //lstString.Add("race");
        //lstString.Add("beat");
        //lstString.Add("brass");
        //lstString.Add("grass");
        //lstString.Add("sabre");
        //lstString.Add("back");
        //lstString.Add("chat");
        //lstString.Add("cabs");
        //lstString.Add("saga");
        //lstString.Add("pack");
        //lstString.Add("lack");
        //lstString.Add("chgt");        
        //lstString.Add("chgt");
        //lstString.Add("sags");
        //lstString.Add("sage");
        //lstString.Add("sago");

        //IAlmostAnagram service = new AlmostAnagram(lstString);
        //int i = 0;
        //foreach (string str in lstString)
        //{
        //    i = service.FindAlmostAnagram(str);
        //    Console.WriteLine("{0} {1}", str, i);
        //}
        #endregion

        #region Find Rotation
        int k = 10;//jumlah rotasi
        int j = 3;//nilai rotasi
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 8, 7, 10, 9 };

        IRotation rotation = new Rotation(k, j, arr);
        int[] arr2 = rotation.FindRotation();

        foreach(int i in arr2)
        {
            Console.Write($"{i} ");
        }
        #endregion

        Console.ReadLine();
    }
}