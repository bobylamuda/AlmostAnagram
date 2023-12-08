using ConsoleApp2.Services;
using ConsoleApp2.Services.Implementations;
using ConsoleApp2.Services.Interfaces;
using ConsoleTestApp.Services.Implementations;
using ConsoleTestApp.Services.Interfaces;
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
        //int k = 12;//jumlah rotasi
        //int j = 3;//nilai rotasi
        //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 8, 7, 10, 9, 20, 30 };

        //IRotation rotation = new Rotation(k, j, arr);
        //int[] arr2 = rotation.FindRotation();

        //foreach (int i in arr2)
        //{
        //    Console.Write($"{i} ");
        //}
        #endregion

        #region W3Resource Exam
        IW3ResourceExam service = new W3ResourceExam();

        #region Compute The Sum
        //List<string> lstInput = new List<string>();
        //lstInput.Add("1,2");
        //lstInput.Add("3,2");
        //lstInput.Add("2,2");
        //int[] arrResult = service.ComputeTheSum(lstInput);
        //foreach (int i in arrResult)
        //{
        //    Console.WriteLine($"{i} ");
        //}
        #endregion

        #region Absolute Difference Between N And 51
        //List<int> lstInput = new List<int>();
        //lstInput.Add(53);
        //lstInput.Add(30);
        //lstInput.Add(51);

        //int[] arrResult = service.AbsoluteDifferenceBetweenNAnd51(lstInput);
        //foreach (var item in arrResult)
        //{
        //    Console.WriteLine($"{item} ");
        //}
        #endregion

        #region Check Two Given Integers
        //List<string> lstInput = new List<string>();
        //lstInput.Add("30,0");
        //lstInput.Add("25,5");
        //lstInput.Add("20,30");
        //lstInput.Add("20,25");

        //bool[] arrResult = service.CheckTwoGivenIntegers(lstInput);
        //foreach (var item in arrResult)
        //{
        //    Console.WriteLine($"{item} ");
        //}
        #endregion

        #region Check given integers
        //List<int> lstInput = new List<int>();
        //lstInput.Add(103);
        //lstInput.Add(90);
        //lstInput.Add(89);

        //bool[] arrResult = service.CheckGivenIntegers(lstInput);
        //foreach (var item in arrResult)
        //{
        //    Console.WriteLine($"{item} ");
        //}
        #endregion

        #region Return String Start With If
        List<string> lstInput = new List<string>();
        lstInput.Add("If else");
        lstInput.Add("else");

        foreach (var item in service.ReturnStringStartWithIf(lstInput))
        {
            Console.WriteLine($"{item} ");
        }
        #endregion
        Console.ReadLine();

        #endregion
    }
}