using ConsoleTestApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Services.Implementations
{
    internal class W3ResourceExam : IW3ResourceExam
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
    }
}
