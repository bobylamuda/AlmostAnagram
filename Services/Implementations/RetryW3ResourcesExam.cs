using ConsoleTestApp.Models.Interfaces;
using ConsoleTestApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Services.Implementations
{
    public class RetryW3ResourcesExam : IRetryW3ResourcesExam
    {
        public int ComputeTheSum(string strInput)
        {
            int[] iArrayIntegers = strInput.Trim().Split(',').Select(int.Parse).ToArray();
            int iA = iArrayIntegers[0];
            int iB = iArrayIntegers[1];

            int iResult = iA + iB;
            if (iA == iB)
            {
                iResult = iResult * 3;
            }

            return iResult;
        }

        public int AbsoluteDifferenceBetweenNAnd51(int iInput)
        {
            const int iConst = 51;
            int iResult = 0;
            if (iInput > iConst)
            {
                iResult = (iInput - iConst) * 3;
            }
            else if (iInput < iConst)
            {
                iResult = iConst - iInput;
            }

            return iResult;
        }

        public bool CheckTwoGivenIntegersAndReturnTrueIfOneOfThemIs30orIfTheirSumIs30(string sInput)
        {
            bool bResult = false;
            int[] arrInput = sInput.Trim().Split(',').Select(int.Parse).ToArray();
            int iA = arrInput[0];
            int iB = arrInput[1];

            bResult = iA + iB == 30 || iA == 30 || iB == 30;

            return bResult;
        }

        public bool CheckTwoGivenIntegersAndReturnTrueIfOneOfThemIs30orIfTheirSumIs30(int iInputA, int iInputB)
        {
            bool bResult = false;
            bResult = iInputA + iInputB == 30 || iInputA == 30 || iInputB == 30;

            return bResult;
        }

        public bool CheckAGivenIntegerAndReturnTrueIfItIsWithin10of100Or200(int iInput)
        {
            bool bResult = false;
            if (Math.Abs(iInput - 100) <= 10 || Math.Abs(iInput - 200) <= 10)
            {
                bResult = true;
            }

            return bResult;
        }

        public string CreateAStringWhereIfIsAddedToTheFrontOfAGivenString(string sInput)
        {
            string sResult = sInput;

            if (!sResult.StartsWith("if"))
            {
                sResult = $"if {sResult}";
            }

            return sResult;
        }

        public int ProgramToComputeTheSumOfTheElementsOfAnArrayOfIntegers(int[] arrInput)
        {
            int iResult = arrInput.Sum();

            return iResult;
        }


    }
}
