using ConsoleApp2.Services.Interfaces;

namespace ConsoleApp2.Services.Implementations
{
    internal class Rotation : IRotation
    {
        private int TotalRotation { get; set; }
        private int NumOfRotation { get; set; }
        private int[] ArrayOfIntegers { get; set; }
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
                if (i + NumOfRotation > TotalRotation - 1)
                {
                    lstIntegers.Add(ArrayOfIntegers[i]);
                }
                else
                {
                    lstLastIntegers.Add(ArrayOfIntegers[i]);
                }
            }
            lstIntegers.AddRange(lstLastIntegers);

            return lstIntegers.ToArray();
        }
    }
}
