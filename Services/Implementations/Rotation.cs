using ConsoleApp2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Implementations
{
    internal class Rotation : IRotation
    {
        public int TotalRotation { get; set; }
        public int NumOfRotation { get; set; }
        public int[] ArrayOfIntegers { get; set; }

        private List<int> lstIntegers;
        private List<int> lstLastIntegers;

        public Rotation(int totalRotation, int numOfRotation, int[] arrIntegers)
        {
            TotalRotation = totalRotation;
            NumOfRotation = numOfRotation;
            ArrayOfIntegers = arrIntegers;
            lstIntegers = new List<int>();
            lstLastIntegers = new List<int>();
        }
        public int[] FindRotation()
        {
            for (int i = 0; i < ArrayOfIntegers.Length; i++)
            {
                int iTemp = ArrayOfIntegers[i];
                if (i + NumOfRotation > TotalRotation - 1)
                {
                    lstIntegers.Add(iTemp);
                }
                else
                {
                    lstLastIntegers.Add(iTemp);
                }
            }

            lstIntegers.AddRange(lstLastIntegers);

            return lstIntegers.ToArray();
        }
    }
}
