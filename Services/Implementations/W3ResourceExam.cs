using ConsoleTestApp.Models.Interfaces;
using ConsoleTestApp.Services.Interfaces;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleTestApp.Services.Implementations
{
    internal class W3ResourceExam : IW3ResourceExam<IStringValue>
    {
        public int[] ComputeTheSum(List<string> lstInput)
        {
            int[] arrResults = new int[lstInput.Count];

            foreach (var item in lstInput)
            {
                var arrIntegers = item.Trim().Split(',').Select(int.Parse).ToArray();
                int a = arrIntegers[0];
                int b = arrIntegers[1];

                int iResult = a + b;
                if (a == b)
                {
                    iResult = iResult * 3;
                }

                arrResults[lstInput.IndexOf(item)] = iResult;
            }

            return arrResults;
        }

        public int[] AbsoluteDifferenceBetweenNAnd51(List<int> lstInput)
        {
            int[] arrResult = new int[lstInput.Count];
            foreach (int iInput in lstInput)
            {
                if (iInput > 51)
                {
                    arrResult[lstInput.IndexOf(iInput)] = (iInput - 51) * 3;
                }
                else
                {
                    arrResult[lstInput.IndexOf(iInput)] = 51 - iInput;
                }
            }

            return arrResult;
        }

        public bool[] CheckTwoGivenIntegers(List<string> lstInput)
        {
            bool[] arrResult = new bool[lstInput.Count];

            foreach (string item in lstInput)
            {
                var arrIntegers = item.Trim().Split(',').Select(int.Parse).ToArray();

                if (arrIntegers[0] is 30 || arrIntegers[1] is 30 || arrIntegers[0] + arrIntegers[1] is 30)
                {
                    arrResult[lstInput.IndexOf(item)] = true;
                }
                else
                {
                    arrResult[lstInput.IndexOf(item)] = false;
                }
            }

            return arrResult;
        }

        public bool[] CheckGivenIntegers(List<int> lstInput)
        {
            bool[] arrResult = new bool[lstInput.Count];

            foreach (int item in lstInput)
            {
                if ((Math.Abs(item - 100) <= 10) || (Math.Abs(item - 200) <= 10))
                {
                    arrResult[lstInput.IndexOf(item)] = true;
                }
                else
                {
                    arrResult[lstInput.IndexOf(item)] = false;
                }
            }

            return arrResult;
        }

        public string[] ReturnStringStartWithIf(List<string> lstInput)
        {
            string[] arrResult = new string[lstInput.Count];

            foreach (string item in lstInput)
            {
                if (item.StartsWith("if", StringComparison.OrdinalIgnoreCase))
                {
                    arrResult[lstInput.IndexOf(item)] = item;
                }
                else
                {
                    arrResult[lstInput.IndexOf(item)] = $"if {item}";
                }
            }

            return arrResult;
        }

        public string[] RemoveTheCharacterAtAGivenPositionInTheString(List<IStringValue> lstInput)
        {
            string[] strings = new string[lstInput.Count];
            foreach (IStringValue item in lstInput)
            {
                strings[lstInput.IndexOf(item)] = item.Key.Remove(item.Value, 1);
            }

            return strings;
        }

        public List<string> ExchangeTheFirstAndLastCharactersInAGivenStringAndReturnTheNewString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sResult = lstString[i];
                if (string.IsNullOrEmpty(sResult)) continue;
                if (sResult.Length > 1)
                {
                    sResult = $"{sResult.Substring(sResult.Length - 1, 1)}{sResult.Substring(1, sResult.Length - 2)}{sResult.Substring(0, 1)}";
                }

                lstResult.Add(sResult);
                //string sTemp = lstString[i];

                //string sFirst = sResult.Substring(0, 1);
                //string sLast = sResult.Substring(sResult.Length - 1, 1);

                //sResult = sResult.Replace(sResult.Substring(0, 1), sLast);
                //sResult = sResult.Replace(sTemp.Substring(sTemp.Length - 1), sFirst);
            }

            return lstResult;
        }

        public List<string> RemoveFirstTwoStringWith4Copies(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            foreach (string item in lstString)
            {
                if (item.Length < 2)
                {
                    lstResult.Add(item);
                    continue;
                }

                string sTemp = string.Concat(Enumerable.Repeat(item.Substring(0, 2), 4));

                lstResult.Add(sTemp);
            }

            return lstResult;
        }

        public List<string> ReverseString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            foreach (string item in lstString)
            {
                char[] chars = item.ToCharArray();
                char[] reversed = chars.Reverse().ToArray();

                lstResult.Add(new string(reversed));
            }

            return lstResult;
        }

        public List<string> AddLastStringToFirstAndLastGivenString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            foreach (string str in lstString)
            {
                string sTemp = str;
                char cTemp = str.Last();
                sTemp = $"{cTemp}{str}{cTemp}";

                lstResult.Add(sTemp);
            }

            return lstResult;
        }

        public List<bool> Ismultiple3Or7(List<int> lstIntegers)
        {
            List<bool> lstBoolean = new List<bool>();
            for (int i = 0; i < lstIntegers.Count; i++)
            {
                lstBoolean.Add(lstIntegers[i] % 3 == 0 || lstIntegers[i] % 7 == 0);
            }

            return lstBoolean;
        }

        public List<string> Add3FirstStringToFirstAndLastGivenString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                if (string.IsNullOrEmpty(lstString[i]))
                {
                    continue;
                }

                string sTemp = lstString[i].Substring(0, 3);
                sTemp = $"{sTemp}{lstString[i]}{sTemp}";

                lstResult.Add(sTemp);
            }

            return lstResult;
        }

        public List<bool> CheckGivenStringStartsWith(List<string> lstString)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                lstResult.Add(lstString[i].StartsWith("C#", StringComparison.OrdinalIgnoreCase));
            }

            return lstResult;
        }

        public List<bool> ChecksWhetherOneTemperatureIsLessThan0AndAnotherIsGreaterThan100(List<string> lstString)
        {
            List<bool> lstResults = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                decimal[] arrDecimal = lstString[i].Split(',').Select(decimal.Parse).ToArray();
                if ((arrDecimal[0] < 0 && arrDecimal[1] > 100) || (arrDecimal[1] < 0 && arrDecimal[0] > 100))
                {
                    lstResults.Add(true);
                    continue;
                }

                lstResults.Add(false);
            }
            return lstResults;
        }

        public List<bool> CheckTwoGivenIntegersWhetherEitherOfThemIsInTheRange100And200(List<string> lstString)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                decimal[] arrDecimals = lstString[i].Split(',').Select(decimal.Parse).ToArray();
                if ((arrDecimals[0] > 99 && arrDecimals[0] < 201) && (arrDecimals[1] > 99 && arrDecimals[1] < 201))
                {
                    lstResult.Add(true);
                    continue;
                }

                lstResult.Add(false);
            }

            return lstResult;
        }

        public List<bool> CheckOneOrMoreWhetherThreeGivenIntegerValuesAreInTheRangeOf20And50(List<string> lstString)
        {
            List<bool> lstResults = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                int[] arrIntegers = lstString[i].Split(',').Select(int.Parse).ToArray();
                lstResults.Add(arrIntegers.Any(x => x >= 20 && x <= 50));
            }

            return lstResults;
        }

        public List<bool> CheckWhetherTwoGivenIntegerValuesAreInTheRange20And50Inclusive(List<string> lstString)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                int[] arrIntegers = lstString[i].Split(',').Select(int.Parse).ToArray();
                bool iA = (arrIntegers[0] >= 20 && arrIntegers[0] <= 50);
                bool iB = (arrIntegers[1] >= 20 && arrIntegers[1] <= 50);

                if (iA && iB || !iA && !iB)
                {
                    lstResult.Add(false);
                    continue;
                }

                lstResult.Add(true);
            }

            return lstResult;
        }

        public List<string> CheckIfAStringYTAppearsAtIndex1InAGivenString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sTemp = lstString[i];
                if (string.IsNullOrEmpty(sTemp))
                {
                    continue;
                }

                if (sTemp.Length < 3)
                {
                    lstResult.Add(sTemp);
                    continue;
                }

                if (sTemp.Substring(1, 2).ToLower().Equals("yt"))
                {
                    lstResult.Add(sTemp.Replace(sTemp.Substring(1, 2), ""));
                    continue;
                }

                lstResult.Add(sTemp);
            }

            return lstResult;
        }

        public List<int> CheckTheLargestNumberAmongThreeGivenIntegers(List<int[]> lstArrIntegers)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstArrIntegers.Count; i++)
            {
                int[] arrIntegers = lstArrIntegers[i];

                lstResult.Add(arrIntegers.Max());
            }

            return lstResult;
        }

        public List<int> CheckWhichNumberIsClosestTo100AmongTwoGivenIntegers(List<int[]> lstArrIntegers)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstArrIntegers.Count; i++)
            {
                int[] arrInteger = lstArrIntegers[i];
                if (arrInteger[0] == arrInteger[1])
                {
                    lstResult.Add(0);
                    continue;
                }

                if (Math.Abs(100 - arrInteger[0]) < Math.Abs(100 - arrInteger[1]))
                {
                    lstResult.Add(arrInteger[0]);
                }
                else
                {
                    lstResult.Add(arrInteger[1]);
                }
            }

            return lstResult;
        }

        public List<bool> CheckWhetherTwoGivenIntegersAreInTheRange40And50OrTheyAreBothInRange50And60(List<int[]> lstArrInteger)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                int[] arrInteger = lstArrInteger[i];
                bool boolA = arrInteger.Any(x => x >= 40 && x <= 50);
                bool boolB = arrInteger.Any(x => x >= 50 && x <= 60);

                lstResult.Add(boolA || boolB);
            }

            return lstResult;
        }

        public List<int> FindTheLargestValueFromTwoPositiveIntegerValuesInTheRange20And30(List<int[]> lstArrInteger)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                int iMax = 0;
                int[] arrInteger = lstArrInteger[i];
                bool aBool = arrInteger[0] >= 20 && arrInteger[0] <= 30;
                bool bBool = arrInteger[1] >= 20 && arrInteger[1] <= 30;

                if (aBool && bBool)
                {
                    iMax = arrInteger.Max();
                }

                lstResult.Add(iMax);
            }

            return lstResult;
        }

        public List<bool> CheckIfAGivenStringContainsBetween2And4zCharacters(List<string> lstString)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                char[] arrChars = lstString[i].ToCharArray();
                int iChar_z = arrChars.Count(x => x == 'z');

                lstResult.Add(iChar_z >= 2 && iChar_z <= 4);
            }
            return lstResult;
        }

        public List<bool> CheckIfTwoGivenNonNegativeIntegersHaveTheSameLastDigit(List<int[]> lstArrInteger)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                int[] arrInteger = lstArrInteger[i];

                char[] arrCharA = arrInteger[0].ToString().ToCharArray();
                char[] arrCharB = arrInteger[1].ToString().ToCharArray();

                char cLastA = arrCharA[arrCharA.Length - 1];
                char cLastB = arrCharB[arrCharB.Length - 1];

                lstResult.Add(cLastA == cLastB);
            }

            return lstResult;
        }

        public List<string> UpperCaseTheLast3Characters(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sString = lstString[i];
                string s3LastString, sFinal = string.Empty;

                if (sString.Length >= 3)
                {
                    s3LastString = sString.Substring(sString.Length - 3).ToUpper();
                    sFinal = sString.Replace(sString.Substring(sString.Length - 3), s3LastString);
                }
                else
                {
                    sFinal = sString.ToUpper();
                }


                lstResult.Add(sFinal);
            }

            return lstResult;
        }

        public List<string> CreateAStringWhichIsnNonNegativeIntegerCopiesOfAGivenString(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sString = lstString[i];
                string[] arrString = sString.Split(',');

                string strA = arrString[0];
                int intB = int.Parse(arrString[1]);

                string sResult = string.Concat(Enumerable.Repeat(strA, intB));

                lstResult.Add(sResult);
            }

            return lstResult;
        }

        public List<string> ReturnCopiesOfTheFirst3Characters(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sString = lstString[i];
                string[] arrString = sString.Split(',');

                string strA = arrString[0];
                int intB = int.Parse(arrString[1]);

                if (strA.Length > 2)
                {
                    strA = strA.Substring(0, 3);
                }

                lstResult.Add(string.Concat(Enumerable.Repeat(strA, intB)));
            }

            return lstResult;
        }

        public List<int> CountTheString_aa_InAGivenString(List<string> lstString)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstString.Count; i++)
            {
                char[] arrChar = lstString[i].ToCharArray();
                int i_aa = arrChar.Count(x => x == 'a');
                int iResultA = i_aa / 2;
                int iResultB = i_aa % 2;

                lstResult.Add(iResultA + (iResultB > 0 ? 1 : 0));
            }

            return lstResult;
        }

        public List<bool> CheckFirstAppearanceOf_a_InAGivenStringIsImmediatelyFollowedByAnother_a(List<string> lstString)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstString.Count; i++)
            {
                char[] arrChar = lstString[i].ToCharArray();
                int iFind_a = 0;
                bool bResult = false;

                foreach (char c in arrChar)
                {
                    //cabbb
                    if (c == 'a')
                    {
                        if (iFind_a > 0)
                        {
                            bResult = true;
                            break;
                        }

                        iFind_a++;
                        continue;
                    }

                    if (iFind_a > 0)
                    {
                        break;
                    }

                    iFind_a = 0;
                }

                lstResult.Add(bResult);
            }

            return lstResult;
        }

        public List<string> CreateStringMadeOfEveryOtherCharacterStartingWithTheFirst(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                string sResult = string.Empty;
                string sString = lstString[i];
                for (int j = 0; j < sString.Length; j++)
                {
                    // Check if the current index 'j' is even
                    if (j % 2 == 0)
                    {
                        // Append the character at index 'j' to the result string
                        sResult += sString[j];
                    }
                }

                lstResult.Add(sResult);
            }

            return lstResult;
        }

        public List<string> CreateAStringLike_aababcabcd_FromAGivenString_abcd(List<string> lstString)
        {
            List<string> lstResult = new List<string>();
            for (int i = 0; i < lstString.Count; i++)
            {
                //abcd: a ab abc abcd
                string sTemp = lstString[i];
                string sResult = string.Empty;
                for (int j = 0; j < sTemp.Length; j++)
                {
                    sResult += sTemp.Substring(0, j + 1);
                }

                lstResult.Add(sResult);
            }

            return lstResult;
        }

        public List<int> CountASubstringOfLength2ThatAppearsInAGivenString(List<string> lstString)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstString.Count; i++)
            {
                int iResult = 0;
                string sString = lstString[i];
                string s2LastChar = sString.Substring(sString.Length - 2);

                for (int j = 0; j < sString.Length - 2; j++)
                {
                    if (sString.Substring(j, 2).Equals(s2LastChar))
                    {
                        iResult++;
                    }
                }

                lstResult.Add(iResult);
            }

            return lstResult;
        }

        public List<bool> CheckIfASpecifiedNumberIsPresentInAGivenArrayOfIntegers(List<int[]> lstArrInteger, List<int> lstInteger)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                int[] arrInteger = lstArrInteger[i];
                int iInteger = lstInteger[i];

                lstResult.Add(arrInteger.Any(x => x == iInteger));
            }

            return lstResult;
        }

        public List<bool> CheckIfOneOfTheFirst4ElementsInAnArrayOfIntegersIsEqualToAGivenElement(List<int[]> lstArrInteger, List<int> lstInteger)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                int[] arrInteger = lstArrInteger[i];
                if (arrInteger.Length > 4)
                {
                    arrInteger = arrInteger.Take(4).ToArray();
                }

                int iInteger = lstInteger[i];

                lstResult.Add(arrInteger.Any(x => x == iInteger));
            }

            return lstResult;
        }

        public List<bool> CheckWhetherTheSequenceOfNumbers123AppearsInAGivenArrayOfIntegersSomewhere(List<int[]> lstArrInteger)
        {
            List<bool> lstResult = new List<bool>();
            for (int i = 0; i < lstArrInteger.Count; i++)
            {
                bool bResult = false;
                int[] arrInteger = lstArrInteger[i];

                for (int j = 0; j < arrInteger.Length - 2; j++)
                {
                    if (arrInteger[j] == 1 && arrInteger[j + 1] == 2 && arrInteger[j + 2] == 3)
                    {
                        bResult = true;
                        break;
                    }
                }

                lstResult.Add(bResult);
            }

            return lstResult;
        }

        public List<int> CompareTwoGivenStringsAndReturnTheNumberOfPositionsWhereTheyContainTheSameLengthOf2Substrings(List<string> lstStringA, List<string> lstStringB)
        {
            List<int> lstResult = new List<int>();
            for (int i = 0; i < lstStringA.Count; i++)
            {
                string strA = lstStringA[i];
                string strB = lstStringB[i];
                int iResult = 0;

                for (int j = 0; j < strA.Length - 1; j++)
                {
                    for (int k = 0; k < strB.Length - 1; k++)
                    {
                        if (strA.Substring(j, 2).Equals(strB.Substring(k, 2)))
                        {
                            iResult++;
                        }
                    }
                }

                lstResult.Add(iResult);
            }
            return lstResult;
        }

        public string CreateAStringFromAGivenStringWhereASpecifiedCharacterIsRemovedExceptForTheBeginningAndEndingPositions(string sInput, string sToRemove)
        {
            string sResult = string.Empty;
            var lstChar = sInput.ToList();
            char cToRemove = sToRemove.ToList()[0];

            for (int i = 1; i < lstChar.Count - 1; i++)
            {
                if (lstChar[i] == cToRemove)
                {
                    lstChar.RemoveAt(i);
                }
            }
            sResult = new string(lstChar.ToArray());

            return sResult;
        }

        public string CreateAStringOfCharactersAtIndexes014589FromAGivenString(string sInput, int[] arrays)
        {
            string sResult = string.Empty;
            List<char> lstChar = sInput.ToList();

            for (int i = 0; i < arrays.Length; i++)
            {
                int iFromArrays = arrays[i];
                for (int j = 0; j < lstChar.Count; j++)
                {
                    if (j == iFromArrays)
                    {
                        sResult += lstChar[j];
                    }
                }
            }

            return sResult;
        }

        public int CountTheNumberOfTwo5sNextToEachOtherInAnArrayOfIntegers_CountTheSituationWhereTheSecond5IsActuallyA6(int[] arrIntegers)
        {
            int iResult = 0;
            for (int i = 0; i < arrIntegers.Length - 1; i++)
            {
                if (arrIntegers[i] == 5 && (arrIntegers[i + 1] == 5 || arrIntegers[i + 1] == 6))
                {
                    iResult++;
                }
            }
            return iResult;
        }

        public bool FindTriple(int[] arrInteger)
        {
            bool bResult = false;
            for (int i = 0; i < arrInteger.Length - 2; i++)
            {
                if (arrInteger[i] == arrInteger[i + 1] && arrInteger[i + 1] == arrInteger[i + 2])
                {
                    bResult = true;
                    break;
                }
            }

            return bResult;
        }

        public int ComputeTheSumOfTheTwoGivenIntegers(int[] arrInteger)
        {
            int iResult = 0;
            iResult = arrInteger.Sum();
            if (iResult >= 10 && iResult <= 20)
            {
                iResult = 30;
            }

            return iResult;
        }

        public bool Find5FromGivenArrayOrSumOf5(int[] arrInteger)
        {
            bool bResult = false;
            bResult = arrInteger.Contains(5) || arrInteger.Sum() == 5;

            return bResult;
        }

        public bool TestIfAGivenNonNegativeNumberIsAMultipleOf13OrOneMoreThanAMultipleOf13(int iInput)
        {
            bool bResult = false;
            int iMod = iInput % 13;
            bResult = iMod == 0 || iMod == 1;

            return bResult;
        }

        public bool CheckIfAGivenNumberThatIsNotNegativeIsAMultipleOf3Or7ButNotBoth(int iInput)
        {
            bool bResult = false;
            if (iInput < 0) return bResult;

            bool bMod3 = iInput % 3 == 0;
            bool bMod7 = iInput % 7 == 0;

            if (bMod3 && bMod7) return bResult;

            bResult = bMod3 || bMod7;

            return bResult;
        }

        public int ComputeTheSumOfTheTwoGivenIntegers_Return18IfOneOfTheGivenIntegerValuesIsInTheRangeOf10To20(int[] arrInteger)
        {
            int iResult = arrInteger.Sum();
            if (arrInteger.Any(x => x >= 10 && x <= 20))
            {
                iResult = 18;
            }

            return iResult;
        }

        public string StringStartWithForB(string sInput)
        {
            string sResult = string.Empty;
            //If the string starts with "F" return "Fizz"
            //and return "Buzz" if it ends with "B"
            //If the string starts with "F" and ends with "B" return "FizzBuzz".
            //In other cases return the original string.
            if (sInput.StartsWith("F", StringComparison.OrdinalIgnoreCase) && sInput.EndsWith("B", StringComparison.OrdinalIgnoreCase))
            {
                sResult = "FizzBuzz";
            }
            else if (sInput.StartsWith("F", StringComparison.OrdinalIgnoreCase))
            {
                sResult = "Fizz";
            }
            else if (sInput.EndsWith("B", StringComparison.OrdinalIgnoreCase))
            {
                sResult = "Buzz";
            }
            else
            {
                sResult = sInput;
            }

            return sResult;
        }

        public bool CheckIfItIsPossibleToAddTwoIntegersToGetTheThirdIntegerFromThreeGivenIntegers(int[] arrInteger)
        {
            bool bResult = false;
            int i1 = arrInteger[0];
            int i2 = arrInteger[1];
            int i3 = arrInteger[2];

            if (i1 + i2 == i3)
            {
                bResult = true;
            }

            return bResult;
        }

        public bool CheckIf_Y_IsGreaterThan_X_And_Z_IsGreaterThan_Y_FromThreeGivenIntegersXYZ(int[] arrInteger)
        {
            bool bResult = false;

            int iX = arrInteger[0];
            int iY = arrInteger[1];
            int iZ = arrInteger[2];

            bResult = iY > iX && iZ > iY;

            return bResult;
        }

        public bool CheckIfThreeGivenNumbersAreInStrictIncreasingOrder(int[] arrInteger, bool isAllowEqual)
        {
            bool bResult = false;
            int iA = arrInteger[0];
            int iB = arrInteger[1];
            int iC = arrInteger[2];

            if (isAllowEqual)
            {
                bResult = iC >= iB && iB >= iA;
            }
            else
            {
                bResult = iC > iB && iB > iA;
            }

            return bResult;
        }

        public bool CheckIfTwoOrMoreIntegersThatAreNotNegativeHaveTheSameRightMostDigit(int[] arrInteger)
        {
            bool bResult = false;
            int iResult = 0;
            //for (int i = 0; i < arrInteger.Length - 2; i++)
            //{
            //    char cA = arrInteger[i].ToString().Last();
            //    char cB = arrInteger[i + 1].ToString().Last();
            //    char cC = arrInteger[i + 2].ToString().Last();

            //    if (cA == cB) iResult++;
            //    if (cA == cC) iResult++;
            //    if (cB == cC) iResult++;
            //    if (cC == cA) iResult++;
            //}

            //bResult = iResult >= 2;

            char cA = arrInteger[0].ToString().Last();
            char cB = arrInteger[1].ToString().Last();
            char cC = arrInteger[2].ToString().Last();

            //bResult = iA % 10 == iB % 10 || iA % 10 == iC % 10 || iB % 10 == iC % 10;
            bResult = cA == cB || cA == cC || cB == cC;

            return bResult;
        }

        public string CreateAStringUsingTheTwoGivenStrings_s1s2_NewStringFormat_s1s2s2s1(string s1, string s2)
        {
            return $"{s1}{s2}{s2}{s1}";
        }

        //public bool CheckThreeGivenIntegersAndReturnTrueIfOneOfThemIs20OrMoreLessThanOneOfTheOthers(int[] arrInteger)
        //{
        //    bool bResult = false;
        //    int iA = arrInteger[0];
        //    int iB = arrInteger[1];
        //    int iC = arrInteger[2];

        //    bResult = iB - iA == 20 || iC - iB == 20 || iC - iA == 20;

        //    return bResult;
        //}

        public bool CheckThreeGivenIntegersAndReturnTrueIfOneOfThemIs20OrMoreLessThanOneOfTheOthers(int[] arrInteger)
        {
            bool bResult = false;
            int iA = arrInteger[0];
            int iB = arrInteger[1];
            int iC = arrInteger[2];

            bResult = Math.Abs(iA - iB) >= 20 || Math.Abs(iB - iC) >= 20 || Math.Abs(iC - iA) >= 20;

            return bResult;
        }

        public int FindTheLargestOfTwoGivenIntegers_IfTheTwoIntegersHaveTheSameRemainderWhenDividedBy7ThenReturnTheSmallestInteger_IfTheTwoIntegersAreTheSameReturn0(int[] arrInteger)
        {
            int iResult = 0;
            int iA = arrInteger[0];
            int iB = arrInteger[1];

            if (iA == iB) return iResult;

            iResult = arrInteger.Max();

            int iModA = iA % 7;
            int iModB = iB % 7;
            if (iModA == iModB)
            {
                iResult = arrInteger.Min();
            }

            return iResult;
        }

        public bool CheckTwoGivenIntegersEachInTheRange10to99_ReturnTrueIfADigitAppearsInBothNumbersSuchAsThe3In13And33(int[] arrInteger)
        {
            bool bResult = false;
            for (int i = 0; i < arrInteger.Length - 1; i++)
            {
                char[] arrCharA = arrInteger[i].ToString().ToCharArray();
                char[] arrCharB = arrInteger[i + 1].ToString().ToCharArray();
                int iCount = arrCharA.Count(x => arrCharB.Contains(x));

                bResult = iCount > 0;
            }

            return bResult;
        }

        public int SumTwoInteger(int[] arrInteger)
        {
            int iResult = arrInteger.Sum();
            if (arrInteger[0].ToString().Length != iResult.ToString().Length)
            {
                iResult = arrInteger[0];
            }

            return iResult;
        }

        public int SumThreeInteger(int[] arrInteger)
        {
            int iResult = arrInteger.Sum();
            if (arrInteger[0] == arrInteger[1])
            {
                iResult = arrInteger[2];
            }
            else if (arrInteger[1] == arrInteger[2])
            {
                iResult = arrInteger[0];
            }
            else if (arrInteger[0] == arrInteger[2])
            {
                iResult = arrInteger[1];
            }

            return iResult;
        }

        public int SumThreeIntegerBy13(int[] arrInteger)
        {
            int iResult = 0;
            for (int i = 0; i < arrInteger.Length; i++)
            {
                if (arrInteger[i] == 13) break;

                iResult += arrInteger[i];
            }

            return iResult;
        }

        public int SumThreeIntegerInRange10_20WillCountAsNolExcept13And17(int[] arrInteger)
        {
            int iResult = 0;
            int[] arrExecption = new int[] { 13, 17 };
            for (int i = 0; i < arrInteger.Length; i++)
            {
                if (arrInteger[i] >= 10 && arrInteger[i] <= 20 && !arrExecption.Contains(arrInteger[i]))
                {
                    continue;
                }

                iResult += arrInteger[i];
            }

            return iResult;
        }

        public int CheckTwoIntegersAndReturnTheValueNearestTo13WithoutCrossingOver_Return0IfBothNumbersExceed(int[] arrInteger)
        {
            int iResult = 0;
            const int iConst = 13;

            int iA = arrInteger[0];
            int iB = arrInteger[1];

            if (iA > iConst & iB > iConst)
            {
                iResult = 0;
                return iResult;
            }

            iA = Math.Abs(arrInteger[0] - iConst);
            iB = Math.Abs(arrInteger[1] - iConst);

            iResult = iA > iB ? arrInteger[1] : arrInteger[0];

            return iResult;
        }

        public bool CompareThreeIntegersSmallMediumAndLarge_AndReturnTrueIfTheDifferenceBetweenSmallAndMediumAndTheDifferenceBetweenMediumAndLargeIsTheSame(int[] arrInteger)
        {
            bool bResult = false;
            int iA = arrInteger[0];
            int iB = arrInteger[1];
            int iC = arrInteger[2];

            int iDiffA = iB - iA;
            int iDiffB = iC - iB;

            bResult = iDiffA == iDiffB;

            return bResult;
        }

        public string InsertAGivenStringIntoTheMiddleOfAnotherGivenStringOfLength4(string strA, string strB)
        {
            string sResult = string.Empty;
            sResult = $"{strA.Substring(0, 2)}{strB}{strA.Substring(2, 2)}";

            return sResult;
        }

        public string CreateAStringUsingThreeCopiesOfTheLastTwoCharactersOfAGivenStringOfLengthAtLeastTwo(string str)
        {
            string strResult = string.Empty;

            if (str.Length < 2) return strResult;

            for (int i = 0; i < 3; i++)
            {
                strResult += str.Substring(str.Length - 2, 2);
            }

            return strResult;
        }

        public string CreateANewStringUsingTheFirstTwoCharactersOfAGivenString_IfTheStringLengthIsLessThan2_ReturnTheOriginalString(string str)
        {
            string strResult = str;
            if (str.Length < 2) return strResult;

            strResult = str.Substring(0, 2);

            return strResult;
        }

        public string CreateAStringFromTheFirstHalfOfAGivenStringOfEvenLength(string str)
        {
            string strResult = string.Empty;
            strResult = str.Substring(0, str.Length / 2);

            return strResult;
        }

        public string CreateANewStringWithoutTheFirstAndLastCharacterOfAGivenStringOfLengthAtLeastTwo(string str)
        {
            string strResult = string.Empty;

            if (str.Length < 2) return strResult;

            strResult = str.Substring(1, str.Length - 2);

            return strResult;
        }

        public string CreateANewStringFromTwoGivenStrings_OneOfWhichIsShorterAndOneOfWhichIsLonger_TheNewStringFormatWillBeLongStringShortStringLongString(string strA, string strB)
        {
            string strResult = string.Empty;
            strResult = strA.Length > strB.Length ? $"{strA}{strB}{strA}" : $"{strB}{strA}{strB}";

            return strResult;
        }

        public string CombineTwoStringsOfLengthAtLeast1_AfterRemovingTheirFirstCharacter(string strA, string strB)
        {
            string strResult = string.Empty;

            if (strA.Length < 2 && strB.Length < 2) return strResult;

            strResult = $"{strA.Substring(1, strA.Length - 1)}{strB.Substring(1, strB.Length - 1)}";

            return strResult;
        }

        public string MoveTheFirstTwoCharactersToTheEndOfAGivenStringOfLengthAtLeastTwo(string str)
        {
            string strResult = string.Empty;
            if (str.Length < 2) return str;
            
            strResult = $"{str.Substring(2, str.Length - 2)}{str.Substring(0, 2)}";

            return strResult;
        }

    }
}
