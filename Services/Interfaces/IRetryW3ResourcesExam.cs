using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleTestApp.Services.Interfaces
{
    internal interface IRetryW3ResourcesExam
    {
        int ComputeTheSum(string strInput);
        int AbsoluteDifferenceBetweenNAnd51(int iInput);
        bool CheckTwoGivenIntegersAndReturnTrueIfOneOfThemIs30orIfTheirSumIs30(string sInput);
        bool CheckTwoGivenIntegersAndReturnTrueIfOneOfThemIs30orIfTheirSumIs30(int iInputA, int iInputB);

        bool CheckAGivenIntegerAndReturnTrueIfItIsWithin10of100Or200(int iInput);
        string CreateAStringWhereIfIsAddedToTheFrontOfAGivenString(string sInput);

        int ProgramToComputeTheSumOfTheElementsOfAnArrayOfIntegers(int[] arrInput);
    }
}
