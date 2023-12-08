using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Services.Interfaces
{
    internal interface IW3ResourceExam
    {
        int[] ComputeTheSum(List<string> lstInput);

        int[] AbsoluteDifferenceBetweenNAnd51(List<int> lstInput);
        bool[] CheckTwoGivenIntegers(List<string> lstInput);
    }
}
