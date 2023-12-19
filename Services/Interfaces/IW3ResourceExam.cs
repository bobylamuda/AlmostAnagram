using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleTestApp.Services.Interfaces
{
    internal interface IW3ResourceExam<T>
    {
        int[] ComputeTheSum(List<string> lstInput);

        int[] AbsoluteDifferenceBetweenNAnd51(List<int> lstInput);
        bool[] CheckTwoGivenIntegers(List<string> lstInput);
        bool[] CheckGivenIntegers(List<int> lstInput);
        string[] ReturnStringStartWithIf(List<string> lstInput);
        string[] RemoveTheCharacterAtAGivenPositionInTheString(List<T> lstInput);
        List<string> ExchangeTheFirstAndLastCharactersInAGivenStringAndReturnTheNewString(List<string> lstString);
        List<string> RemoveFirstTwoStringWith4Copies(List<string> lstString);
        List<string> ReverseString(List<string> lstString);
        List<string> AddLastStringToFirstAndLastGivenString(List<string> lstString);
        List<bool> Ismultiple3Or7(List<int> lstIntegers);
        List<string> Add3FirstStringToFirstAndLastGivenString(List<string> lstString);
        List<bool> CheckGivenStringStartsWith(List<string> lstString);
        List<bool> ChecksWhetherOneTemperatureIsLessThan0AndAnotherIsGreaterThan100(List<string> lstString);
        List<bool> CheckTwoGivenIntegersWhetherEitherOfThemIsInTheRange100And200(List<string> lstString);
        List<bool> CheckOneOrMoreWhetherThreeGivenIntegerValuesAreInTheRangeOf20And50(List<string> lstString);
        List<bool> CheckWhetherTwoGivenIntegerValuesAreInTheRange20And50Inclusive(List<string> lstString);
        List<string> CheckIfAStringYTAppearsAtIndex1InAGivenString(List<string> lstString);
        List<int> CheckTheLargestNumberAmongThreeGivenIntegers(List<int[]> lstArrIntegers);
        List<int> CheckWhichNumberIsClosestTo100AmongTwoGivenIntegers(List<int[]> lstArrIntegers);
        List<bool> CheckWhetherTwoGivenIntegersAreInTheRange40And50OrTheyAreBothInRange50And60(List<int[]> lstArrInteger);
        List<int> FindTheLargestValueFromTwoPositiveIntegerValuesInTheRange20And30(List<int[]> lstArrInteger);
        List<bool> CheckIfAGivenStringContainsBetween2And4zCharacters(List<string> lstString);
        List<bool> CheckIfTwoGivenNonNegativeIntegersHaveTheSameLastDigit(List<int[]> lstArrInteger);
        List<string> UpperCaseTheLast3Characters(List<string> lstString);
        List<string> CreateAStringWhichIsnNonNegativeIntegerCopiesOfAGivenString(List<string> lstString);
        List<string> ReturnCopiesOfTheFirst3Characters(List<string> lstString);
        List<int> CountTheString_aa_InAGivenString(List<string> lstString);
        List<bool> CheckFirstAppearanceOf_a_InAGivenStringIsImmediatelyFollowedByAnother_a(List<string> lstString);
        List<string> CreateStringMadeOfEveryOtherCharacterStartingWithTheFirst(List<string> lstString);
        List<string> CreateAStringLike_aababcabcd_FromAGivenString_abcd(List<string> lstString);
        List<int> CountASubstringOfLength2ThatAppearsInAGivenString(List<string> lstString);
        List<bool> CheckIfASpecifiedNumberIsPresentInAGivenArrayOfIntegers(List<int[]> lstArrInteger, List<int> lstInteger);
        List<bool> CheckIfOneOfTheFirst4ElementsInAnArrayOfIntegersIsEqualToAGivenElement(List<int[]> lstArrInteger, List<int> lstInteger);
        List<bool> CheckWhetherTheSequenceOfNumbers123AppearsInAGivenArrayOfIntegersSomewhere(List<int[]> lstArrInteger);
        List<int> CompareTwoGivenStringsAndReturnTheNumberOfPositionsWhereTheyContainTheSameLengthOf2Substrings(List<string> lstStringA, List<string> lstStringB);
        string CreateAStringFromAGivenStringWhereASpecifiedCharacterIsRemovedExceptForTheBeginningAndEndingPositions(string sInput, string sToRemove);
        string CreateAStringOfCharactersAtIndexes014589FromAGivenString(string sInput, int[] arrays);
        int CountTheNumberOfTwo5sNextToEachOtherInAnArrayOfIntegers_CountTheSituationWhereTheSecond5IsActuallyA6(int[] arrIntegers);
        bool FindTriple(int[] arrInteger);
        int ComputeTheSumOfTheTwoGivenIntegers(int[] arrInteger);
        bool Find5FromGivenArrayOrSumOf5(int[] arrInteger);
        bool TestIfAGivenNonNegativeNumberIsAMultipleOf13OrOneMoreThanAMultipleOf13(int iInput);
        bool CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth(int iInput);
        int ComputeTheSumOfTheTwoGivenIntegers_Return18IfOneOfTheGivenIntegerValuesIsInTheRangeOf10To20(int[] arrInteger);
        string StringStartWithForB(string sInput);
        bool CheckIfItIsPossibleToAddTwoIntegersToGetTheThirdIntegerFromThreeGivenIntegers(int[] arrInteger);
        bool CheckIf_Y_IsGreaterThan_X_And_Z_IsGreaterThan_Y_FromThreeGivenIntegersXYZ(int[] arrInteger);
        bool CheckIfThreeGivenNumbersAreInStrictIncreasingOrder(int[] arrInteger, bool isAllowEqual);
        bool CheckIfTwoOrMoreIntegersThatAreNotNegativeHaveTheSameRightMostDigit(int[] arrInteger);
        string CreateAStringUsingTheTwoGivenStrings_s1s2_NewStringFormat_s1s2s2s1(string s1, string s2);
        bool CheckThreeGivenIntegersAndReturnTrueIfOneOfThemIs20OrMoreLessThanOneOfTheOthers(int[] arrInteger);
        int FindTheLargestOfTwoGivenIntegers_IfTheTwoIntegersHaveTheSameRemainderWhenDividedBy7ThenReturnTheSmallestInteger_IfTheTwoIntegersAreTheSameReturn0(int[] arrInteger);
        bool CheckTwoGivenIntegersEachInTheRange10to99_ReturnTrueIfADigitAppearsInBothNumbersSuchAsThe3In13And33(int[] arrInteger);
        int SumTwoInteger (int[] arrInteger);
        int SumThreeInteger(int[] arrInteger);
        int SumThreeIntegerBy13(int[] arrInteger);
        int SumThreeIntegerInRange10_20WillCountAsNolExcept13And17(int[] arrInteger);
        int CheckTwoIntegersAndReturnTheValueNearestTo13WithoutCrossingOver_Return0IfBothNumbersExceed(int[] arrInteger);
        bool CompareThreeIntegersSmallMediumAndLarge_AndReturnTrueIfTheDifferenceBetweenSmallAndMediumAndTheDifferenceBetweenMediumAndLargeIsTheSame(int[] arrInteger);
    }
}
