using ConsoleApp2.Services;
using ConsoleApp2.Services.Implementations;
using ConsoleApp2.Services.Interfaces;
using ConsoleTestApp.Models.Implementations;
using ConsoleTestApp.Models.Interfaces;
using ConsoleTestApp.Services.Implementations;
using ConsoleTestApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        #region W3Resource Exam

        IW3ResourceExam<IStringValue> service = new W3ResourceExam();

        #region [061] 
        string s1 = "whats";
        string s2 = "app";
        string values = service.CreateAStringUsingTheTwoGivenStrings_s1s2_NewStringFormat_s1s2s2s1(s1, s2);

        Console.WriteLine($"[{s1} {s2}] => {values}");
        #endregion

        #region [060] CreateAStringUsingTheTwoGivenStrings_s1s2_NewStringFormat_s1s2s2s1
        //string s1 = "whats";
        //string s2 = "app";
        //string values = service.CreateAStringUsingTheTwoGivenStrings_s1s2_NewStringFormat_s1s2s2s1(s1, s2);

        //Console.WriteLine($"[{s1} {s2}] => {values}");
        #endregion

        #region [059] CompareThreeIntegersSmallMediumAndLarge_AndReturnTrueIfTheDifferenceBetweenSmallAndMediumAndTheDifferenceBetweenMediumAndLargeIsTheSame
        //int[] arrInteger = new int[] { -1, 0, 1 };
        //bool values = service.CompareThreeIntegersSmallMediumAndLarge_AndReturnTrueIfTheDifferenceBetweenSmallAndMediumAndTheDifferenceBetweenMediumAndLargeIsTheSame(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [058]  CheckTwoIntegersAndReturnTheValueNearestTo13WithoutCrossingOver_Return0IfBothNumbersExceed
        //int[] arrInteger = new int[] { 17, 33 };
        //int values = service.CheckTwoIntegersAndReturnTheValueNearestTo13WithoutCrossingOver_Return0IfBothNumbersExceed(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [057]  SumThreeIntegerInRange10_20WillCountAsNolExcept13And17
        //int[] arrInteger = new int[] { 14, 15, 16 };
        //int values = service.SumThreeIntegerInRange10_20WillCountAsNolExcept13And17(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [056] SumThreeIntegerBy13 
        //int[] arrInteger = new int[] { 12, 12, 13 };
        //int values = service.SumThreeIntegerBy13(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [055] SumThreeInteger 
        //int[] arrInteger = new int[] { 11, 15, 15 };
        //int values = service.SumThreeInteger(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [054] SumTwoInteger 
        //int[] arrInteger = new int[] { 10, 10 };
        //int values = service.SumTwoInteger(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [053] CheckTwoGivenIntegersEachInTheRange10to99_ReturnTrueIfADigitAppearsInBothNumbersSuchAsThe3In13And33
        //int[] arrInteger = new int[] { 10, 17 };
        //bool values = service.CheckTwoGivenIntegersEachInTheRange10to99_ReturnTrueIfADigitAppearsInBothNumbersSuchAsThe3In13And33(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [052] FindTheLargestOfTwoGivenIntegers_IfTheTwoIntegersHaveTheSameRemainderWhenDividedBy7ThenReturnTheSmallestInteger_IfTheTwoIntegersAreTheSameReturn0
        //int[] arrInteger = new int[] { 10, 10 };
        //int values = service.FindTheLargestOfTwoGivenIntegers_IfTheTwoIntegersHaveTheSameRemainderWhenDividedBy7ThenReturnTheSmallestInteger_IfTheTwoIntegersAreTheSameReturn0(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [051] CheckThreeGivenIntegersAndReturnTrueIfOneOfThemIs20OrMoreLessThanOneOfTheOthers
        //int[] arrInteger = new int[] { 10, 20, 15 };
        //bool values = service.CheckThreeGivenIntegersAndReturnTrueIfOneOfThemIs20OrMoreLessThanOneOfTheOthers(arrInteger);

        //Console.WriteLine($"[{string.Join(",", arrInteger)}] => {values}");
        #endregion

        #region [050] CheckIfTwoOrMoreIntegersThatAreNotNegativeHaveTheSameRightmostDigit
        //int[] arrIntger = new int[] { 11, 22, 33 };

        //bool values = service.CheckIfTwoOrMoreIntegersThatAreNotNegativeHaveTheSameRightMostDigit(arrIntger);

        //Console.WriteLine($"[{string.Join(", ", arrIntger)}] => {values}");
        #endregion

        #region [049] CheckIfThreeGivenNumbersAreInStrictIncreasingOrder
        //int[] arrIntger = new int[] { 10, 30, 10 };
        //bool isAllowEqual = true;

        //bool values = service.CheckIfThreeGivenNumbersAreInStrictIncreasingOrder(arrIntger, isAllowEqual);

        //Console.WriteLine($"[{string.Join(", ", arrIntger)}] => {values}");
        #endregion

        #region [048] CheckIf_Y_IsGreaterThan_X_And_Z_IsGreaterThan_Y_FromThreeGivenIntegersXYZ
        //int[] arrIntger = new int[] { 4, 5, 6 };
        ////1, 2, 3
        ////4, 5, 6
        ////- 1, 1, 0
        //bool values = service.CheckIf_Y_IsGreaterThan_X_And_Z_IsGreaterThan_Y_FromThreeGivenIntegersXYZ(arrIntger);

        //Console.WriteLine($"[{string.Join(", ", arrIntger)}] => {values}");
        #endregion

        #region [047] CheckIfItIsPossibleToAddTwoIntegersToGetTheThirdIntegerFromThreeGivenIntegers
        //int[] arrIntger = new int[] { -1, 1, 0 };
        ////1, 2, 3
        ////4, 5, 6
        ////- 1, 1, 0
        //bool values = service.CheckIfItIsPossibleToAddTwoIntegersToGetTheThirdIntegerFromThreeGivenIntegers(arrIntger);

        //Console.WriteLine($"[{string.Join(", ", arrIntger)}] => {values}");
        #endregion

        #region [046] StringStartWithForB
        //string sInput = "Founderb";
        //string values = service.StringStartWithForB(sInput);

        //Console.WriteLine($"[{sInput}] => {values}");
        #endregion

        #region [045] ComputeTheSumOfTheTwoGivenIntegers_Return18IfOneOfTheGivenIntegerValuesIsInTheRangeOf10To20
        //int[] arrInteger = new int[] { 21, 220 };

        //int values = service.ComputeTheSumOfTheTwoGivenIntegers_Return18IfOneOfTheGivenIntegerValuesIsInTheRangeOf10To20(arrInteger);

        //Console.WriteLine($"[{string.Join(", ", arrInteger)}] => {values}");
        #endregion

        #region [044] CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth
        //int iInput = 21;

        //bool values = service.CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth(iInput);

        //Console.WriteLine($"[{iInput}] => {values}");
        #endregion

        #region [043] CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth
        //int iInput = 21;

        //bool values = service.CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth(iInput);

        //Console.WriteLine($"[{iInput}] => {values}");
        #endregion

        #region [042] TestIfAGivenNonNegativeNumberIsAMultipleOf13OrOneMoreThanAMultipleOf13
        //int iInput = 41;

        //bool values = service.TestIfAGivenNonNegativeNumberIsAMultipleOf13OrOneMoreThanAMultipleOf13(iInput);

        //Console.WriteLine($"[{iInput}] => {values}");
        #endregion

        #region [041] Find5FromGivenArrayOrSumOf5
        //int[] arrInteger = new int[] { 1, 4 };

        //bool values = service.Find5FromGivenArrayOrSumOf5(arrInteger);

        //Console.WriteLine($"[{string.Join(", ", arrInteger)}] => {values}");
        #endregion

        #region [040] ComputeTheSumOfTheTwoGivenIntegers
        //int[] arrInteger = new int[] { 20, 0 };

        //int values = service.ComputeTheSumOfTheTwoGivenIntegers(arrInteger);

        //Console.WriteLine($"[{string.Join(", ", arrInteger)}] => {values}");
        #endregion

        #region [039] FindTriple
        //int[] arrInteger = new int[] { 1, 1, 2, 2, 1, 1, 1 };
        //int[] arrInteger = new int[] { 1, 1, 2, 1, 2, 3 };
        //int[] arrInteger = new int[] { 1, 1, 1, 2, 2, 2, 1 };

        //bool values = service.FindTriple(arrInteger);

        //Console.WriteLine($"[{string.Join(", ", arrInteger)}] => {values}");
        #endregion

        #region [038] CountTheNumberOfTwo5sNextToEachOtherInAnArrayOfIntegers_CountTheSituationWhereTheSecond5IsActuallyA6
        //int[] arrInteger = new int[] { 5, 6, 2, 9 };

        //int values = service.CountTheNumberOfTwo5sNextToEachOtherInAnArrayOfIntegers_CountTheSituationWhereTheSecond5IsActuallyA6(arrInteger);

        //Console.WriteLine($"[{string.Join(", ", arrInteger)}] => {values}");
        #endregion

        #region [037] CreateAStringOfCharactersAtIndexes014589FromAGivenString
        //string sInput = "HTML";
        //int[] arrInteger = new int[] { 0, 1, 4, 5, 8, 9 };

        //string values = service.CreateAStringOfCharactersAtIndexes014589FromAGivenString(sInput, arrInteger);

        //Console.WriteLine($"[{sInput}] => {values}");
        #endregion

        #region [036] CreateAStringFromAGivenStringWhereASpecifiedCharacterIsRemovedExceptForTheBeginningAndEndingPositions
        //string sInput = "xabjbhtrb";
        //string sToRemove = "b";

        //string values = service.CreateAStringFromAGivenStringWhereASpecifiedCharacterIsRemovedExceptForTheBeginningAndEndingPositions(sInput, sToRemove);

        //Console.WriteLine($"[{sInput}] => {values}");
        #endregion

        #region [035] CompareTwoGivenStringsAndReturnTheNumberOfPositionsWhereTheyContainTheSameLengthOf2Substrings
        //List<string> lstStringA = new List<string>();
        //lstStringA.Add("abcdefgh");
        //lstStringA.Add("abcde");
        //lstStringA.Add("pqrstuvwx");

        //List<string> lstStringB = new List<string>();
        //lstStringB.Add("abijsklm");
        //lstStringB.Add("osuefrcd");
        //lstStringB.Add("pqkdiewx");

        //List<int> values = service.CompareTwoGivenStringsAndReturnTheNumberOfPositionsWhereTheyContainTheSameLengthOf2Substrings(lstStringA, lstStringB);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstStringA[i]} - {lstStringB[i]}] => {values[i]}");
        //}
        #endregion

        #region [034] CheckWhetherTheSequenceOfNumbers123AppearsInAGivenArrayOfIntegersSomewhere
        //List<int[]> lstArrInteger = new List<int[]>();
        //lstArrInteger.Add(new int[] { 1, 1, 2, 3, 1 });
        //lstArrInteger.Add(new int[] { 1, 1, 2, 4, 1 });
        //lstArrInteger.Add(new int[] { 1, 1, 2, 1, 2, 3 });

        //List<bool> values = service.CheckWhetherTheSequenceOfNumbers123AppearsInAGivenArrayOfIntegersSomewhere(lstArrInteger);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrInteger[i])}] => {values[i]}");
        //}
        #endregion

        #region [033] CheckIfOneOfTheFirst4ElementsInAnArrayOfIntegersIsEqualToAGivenElement
        //List<int[]> lstArrInteger = new List<int[]>();
        //lstArrInteger.Add(new int[] { 1, 2, 9, 3 });
        //lstArrInteger.Add(new int[] { 1, 2, 3, 4, 5, 6 });
        //lstArrInteger.Add(new int[] { 1, 2, 2, 3 });
        //lstArrInteger.Add(new int[] { 1, 2, 2, 7, 3, 5, 6, 7 });

        //List<int> lstInteger = new List<int>() { 3, 2, 9, 7 };

        //List<bool> values = service.CheckIfOneOfTheFirst4ElementsInAnArrayOfIntegersIsEqualToAGivenElement(lstArrInteger, lstInteger);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrInteger[i])}], {lstInteger[i]} => {values[i]}");
        //}
        #endregion

        #region [032] CheckIfASpecifiedNumberIsPresentInAGivenArrayOfIntegers
        //List<int[]> lstArrInteger = new List<int[]>();
        //lstArrInteger.Add(new int[] { 1, 2, 9, 3 });
        //lstArrInteger.Add(new int[] { 1, 2, 2, 3 });
        //lstArrInteger.Add(new int[] { 1, 2, 2, 3 });

        //List<int> lstInteger = new List<int>() { 3, 2, 9 };

        //List<bool> values = service.CheckIfASpecifiedNumberIsPresentInAGivenArrayOfIntegers(lstArrInteger, lstInteger);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrInteger[i])}], {lstInteger[i]} => {values[i]}");
        //}
        #endregion

        #region [031] CountASubstringOfLength2ThatAppearsInAGivenString
        //List<string> lstString = new List<string>();
        //lstString.Add("abcdsab");
        //lstString.Add("abcdabab");
        //lstString.Add("abcabdabab");
        //lstString.Add("abcabd");

        //List<int> values = service.CountASubstringOfLength2ThatAppearsInAGivenString(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [030] CreateAStringLike_aababcabcd_FromAGivenString_abcd
        //List<string> lstString = new List<string>();
        //lstString.Add("abcd");
        //lstString.Add("abc");
        //lstString.Add("ab");
        //lstString.Add("a");

        //List<string> values = service.CreateAStringLike_aababcabcd_FromAGivenString_abcd(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [029] CreateStringMadeOfEveryOtherCharacterStartingWithTheFirst
        //List<string> lstString = new List<string>();
        //lstString.Add("Python");
        //lstString.Add("PHP");
        //lstString.Add("JS");

        //List<string> values = service.CreateStringMadeOfEveryOtherCharacterStartingWithTheFirst(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [028] CheckFirstAppearanceOf_a_InAGivenStringIsImmediatelyFollowedByAnother_a
        //List<string> lstString = new List<string>();
        //lstString.Add("caabb");
        //lstString.Add("babaaba");
        //lstString.Add("aaaaa");

        //List<bool> values = service.CheckFirstAppearanceOf_a_InAGivenStringIsImmediatelyFollowedByAnother_a(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [027] CountTheString_aa_InAGivenString
        //List<string> lstString = new List<string>();
        //lstString.Add("bbaaccaag");
        //lstString.Add("jjkiaaasew");
        //lstString.Add("JSaaakoiaa");

        //List<int> values = service.CountTheString_aa_InAGivenString(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [026] ReturnCopiesOfTheFirst3Characters
        //List<string> lstString = new List<string>();
        //lstString.Add("Python,2");
        //lstString.Add("Python,3");
        //lstString.Add("JS,3");
        //lstString.Add("PHP,5");

        //List<string> values = service.ReturnCopiesOfTheFirst3Characters(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [025] CreateAStringWhichIsnNonNegativeIntegerCopiesOfAGivenString
        //List<string> lstString = new List<string>();
        //lstString.Add("JS,2");
        //lstString.Add("JS,3");
        //lstString.Add("JS,1");
        //lstString.Add("PHP,3");

        //List<string> values = service.CreateAStringWhichIsnNonNegativeIntegerCopiesOfAGivenString(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [024] UpperCaseTheLast3Characters
        //List<string> lstString = new List<string>();
        //lstString.Add("Python");
        //lstString.Add("Javascript");
        //lstString.Add("js");
        //lstString.Add("PHP");

        //List<string> values = service.UpperCaseTheLast3Characters(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [023] CheckIfTwoGivenNonNegativeIntegersHaveTheSameLastDigit
        //List<int[]> lstArrInteger = new List<int[]>();
        //lstArrInteger.Add(new int[] { 123, 456 });
        //lstArrInteger.Add(new int[] { 12, 512 });
        //lstArrInteger.Add(new int[] { 7, 87 });
        //lstArrInteger.Add(new int[] { 12, 45 });

        //List<bool> values = service.CheckIfTwoGivenNonNegativeIntegersHaveTheSameLastDigit(lstArrInteger);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrInteger[i])}] => {values[i]}");
        //}
        #endregion

        #region [022] CheckIfAGivenStringContainsBetween2And4zCharacters
        //List<string> lstString = new List<string>();
        //lstString.Add("frizz");
        //lstString.Add("zane");
        //lstString.Add("Zazz");
        //lstString.Add("false");
        //lstString.Add("zzzz");
        //lstString.Add("ZZZZ");

        //List<bool> values = service.CheckIfAGivenStringContainsBetween2And4zCharacters(lstString);
        //for (int i = 0; i < values.Count; i++)
        //{
        //Console.WriteLine($"[{lstString[i]}] => {values[i]}");
        //}
        #endregion

        #region [021] FindTheLargestValueFromTwoPositiveIntegerValuesInTheRange20And30
        //List<int[]> lstArrIntegers = new List<int[]>();
        //lstArrIntegers.Add(new int[] { 78, 95 });
        //lstArrIntegers.Add(new int[] { 20, 30 });
        //lstArrIntegers.Add(new int[] { 21, 25 });
        //lstArrIntegers.Add(new int[] { 28, 28 });
        //lstArrIntegers.Add(new int[] { 28, 91 });

        //List<int> values = service.FindTheLargestValueFromTwoPositiveIntegerValuesInTheRange20And30(lstArrIntegers);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrIntegers[i])}] => {values[i]}");
        //}
        #endregion

        #region [020] CheckWhetherTwoGivenIntegersAreInTheRange40And50OrTheyAreBothInRange50And60
        //List<int[]> lstArrIntegers = new List<int[]>();
        //lstArrIntegers.Add(new int[] { 78, 95 });
        //lstArrIntegers.Add(new int[] { 25, 35 });
        //lstArrIntegers.Add(new int[] { 40, 50 });
        //lstArrIntegers.Add(new int[] { 55, 60 });

        //List<bool> values = service.CheckWhetherTwoGivenIntegersAreInTheRange40And50OrTheyAreBothInRange50And60(lstArrIntegers);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrIntegers[i])}] => {values[i]}");
        //}
        #endregion

        #region [019] CheckWhichNumberIsClosestTo100AmongTwoGivenIntegers
        //List<int[]> lstArrIntegers = new List<int[]>();
        //lstArrIntegers.Add(new int[] { 78, 95 });
        //lstArrIntegers.Add(new int[] { 95, 95 });
        //lstArrIntegers.Add(new int[] { 99, 70 });

        //List<int> values = service.CheckWhichNumberIsClosestTo100AmongTwoGivenIntegers(lstArrIntegers);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrIntegers[i])}] => {values[i]}");
        //}
        #endregion

        #region [018] CheckTheLargestNumberAmongThreeGivenIntegers
        //List<int[]> lstArrIntegers = new List<int[]>();
        //lstArrIntegers.Add(new int[] { 1, 2, 3 });
        //lstArrIntegers.Add(new int[] { 1, 3, 2 });
        //lstArrIntegers.Add(new int[] { 1, 5, 1 });
        //lstArrIntegers.Add(new int[] { 1, 2, 2 });

        //List<int> values = service.CheckTheLargestNumberAmongThreeGivenIntegers(lstArrIntegers);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"[{string.Join(",", lstArrIntegers[i])}] => {values[i]}");
        //}
        #endregion

        #region [017] CheckIfAStringYTAppearsAtIndex1InAGivenString
        //List<string> strings = new List<string>()
        //{
        //    "Python",
        //    "ytade",
        //    "QYTown"
        //};

        //List<string> values = service.CheckIfAStringYTAppearsAtIndex1InAGivenString(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [016] CheckWhetherTwoGivenIntegerValuesAreInTheRange20And50Inclusive
        //List<string> strings = new List<string>()
        //{
        //    "20, 84",
        //    "14, 50",
        //    "11, 45",
        //    "25, 40",
        //    "70, 60"
        //};

        //List<bool> values = service.CheckWhetherTwoGivenIntegerValuesAreInTheRange20And50Inclusive(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [015] CheckOneOrMoreWhetherThreeGivenIntegerValuesAreInTheRangeOf20And50
        //List<string> strings = new List<string>()
        //{
        //    "11, 20, 12",
        //    "30, 30, 17",
        //    "25, 35, 50",
        //    "15, 12, 8 "
        //};

        //List<bool> values = service.CheckOneOrMoreWhetherThreeGivenIntegerValuesAreInTheRangeOf20And50(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [014] CheckTwoGivenIntegersWhetherEitherOfThemIsInTheRange100And200
        //List<string> strings = new List<string>()
        //{
        //    "100, 199",
        //    "250, 300",
        //    "105, 190"
        //};

        //List<bool> values = service.CheckTwoGivenIntegersWhetherEitherOfThemIsInTheRange100And200(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [013] ChecksWhetherOneTemperatureIsLessThan0AndAnotherIsGreaterThan100
        //List<string> strings = new List<string>()
        //{
        //    "120, -1",
        //    "-1, 120",
        //    "2, 120"
        //};

        //List<bool> values = service.ChecksWhetherOneTemperatureIsLessThan0AndAnotherIsGreaterThan100(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [012] CheckGivenStringStartsWith
        //List<string> strings = new List<string>()
        //{
        //    "c#Hanafi",
        //    "c#Nisa",
        //    "c#Adam",
        //    "Hawac#",
        //    "Uwaisc#",
        //    "Azurac#",
        //    "Irjanc#"
        //};

        //List<bool> values = service.CheckGivenStringStartsWith(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [011] Add3FirstStringToFirstAndLastGivenString
        //List<string> strings = new List<string>()
        //{
        //    "Hanafi",
        //    "Nisa",
        //    "Adam",
        //    "Hawa",
        //    "Uwais",
        //    "Azura",
        //    "Irjan"
        //};

        //List<string> values = service.Add3FirstStringToFirstAndLastGivenString(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [010] Ismultiple3Or7
        //List<int> lstIntegers = new List<int>()
        //{
        //    3, 14,12,37
        //};

        //List<bool> lstBooleans = service.Ismultiple3Or7(lstIntegers);
        //for (int i = 0; i < lstBooleans.Count; i++)
        //{
        //    Console.WriteLine($"{lstIntegers[i]} => {lstBooleans[i]}");
        //}
        #endregion

        #region [009] AddLastStringToFirstAndLastGivenString
        //List<string> strings = new List<string>()
        //{
        //    "Hanafi",
        //    "Nisa",
        //    "Adam",
        //    "Hawa",
        //    "Uwais",
        //    "Azura",
        //    "Irjan"
        //};

        //List<string> values = service.AddLastStringToFirstAndLastGivenString(strings);
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.WriteLine($"{strings[i]} => {values[i]}");
        //}
        #endregion

        #region [008] RemoveFirstTwoStringWith4Copies
        //List<string> strings = new List<string>();
        //strings.Add("Hanafi");
        //strings.Add("Nisa");
        //strings.Add("Adam");
        //strings.Add("Hawa");
        //strings.Add("Uwais");
        //strings.Add("Azura");
        //strings.Add("Irjan");

        //strings.Add("C Sharp");
        //strings.Add("JS");
        //strings.Add("a");

        //List<string> values = service.RemoveFirstTwoStringWith4Copies(strings);
        //foreach (string value in values)
        //{
        //    Console.WriteLine(value);
        //}
        #endregion

        #region [007] ExchangeTheFirstAndLastCharactersInAGivenStringAndReturnTheNewString
        //List<string> strings = new List<string>();
        //strings.Add("Hanafi");
        //strings.Add("Nisa");
        //strings.Add("Adam");
        //strings.Add("Hawa");
        //strings.Add("Uwais");
        //strings.Add("Azura");
        //strings.Add("Irjan");
        //strings.Add("abcd");
        //strings.Add("a");
        //strings.Add("xy");

        //List<string> values = service.ExchangeTheFirstAndLastCharactersInAGivenStringAndReturnTheNewString(strings);
        //foreach (string value in values)
        //{
        //    Console.WriteLine(value);
        //}
        #endregion

        #region [006] Remove The Character At A Given Position In The String
        //List<IStringValue> lstInput = new List<IStringValue>();
        //lstInput.Add(new StringValue("Python", 0));
        //lstInput.Add(new StringValue("Python", 1));
        //lstInput.Add(new StringValue("Python", 4));
        //lstInput.Add(new StringValue("Salam Lamahala", 7));

        //string[] strings = service.RemoveTheCharacterAtAGivenPositionInTheString(lstInput);
        //foreach (var item in strings)
        //{
        //    Console.WriteLine($"{item} ");
        //}
        #endregion

        #region [005] Return String Start With If
        //List<string> lstInput = new List<string>();
        //lstInput.Add("if else");
        //lstInput.Add("else");

        //foreach (var item in service.ReturnStringStartWithIf(lstInput))
        //{
        //    Console.WriteLine($"{item} ");
        //}
        #endregion

        #region [004] Check given integers
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

        #region [003] Check Two Given Integers
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

        #region [002] Absolute Difference Between N And 51
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

        #region [001] Compute The Sum
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

        #endregion

        #region  Personal Exercise

        #region ReverseString
        //List<string> strings = new List<string>();
        //strings.Add("Hanafi");
        //strings.Add("Nisa");
        //strings.Add("Adam");
        //strings.Add("Hawa");
        //strings.Add("Uwais");
        //strings.Add("Azura");
        //strings.Add("Irjan");

        //List<string> values = service.ReverseString(strings);
        //foreach (string value in values)
        //{
        //    Console.WriteLine($"{strings.ElementAt(strings.IndexOf(value))} => {value}");
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

        #endregion

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

        Console.ReadLine();

    }
}