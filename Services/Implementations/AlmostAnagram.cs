using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class AlmostAnagram : IAlmostAnagram
    {
        private List<string> lstStringData = null;
        private Dictionary<string, string> dicTempString = null;

        public AlmostAnagram(List<string> lstStrData)
        {
            this.lstStringData = lstStrData;
            this.dicTempString = new Dictionary<string, string>();
        }

        public int FindAlmostAnagram(string strInput)
        {
            if (lstStringData is null || lstStringData.Count == 0) return 0;

            int result = 0;
            int iToleransi = 1;
            List<int> lstResult = new List<int>();
            List<char> lstCInput = strInput.ToCharArray().ToList();

            foreach (string str in lstStringData)
            {
                if (strInput.Length != str.Length) continue;
                if (strInput == str)
                {
                    if (dicTempString.ContainsKey(str))
                    {
                        result = iToleransi;
                        return result;
                    }

                    continue;
                }

                List<char> lstCStr = str.ToCharArray().ToList();
                foreach (char c in lstCStr.Where(x => !lstCInput.Contains(x)))
                {
                    iToleransi++;
                    if (iToleransi > 2)
                    {
                        iToleransi = 1;
                        break;
                    }
                }

                if (iToleransi > 1)
                {
                    if (!dicTempString.ContainsKey(str))
                    {
                        dicTempString.Add(str, str);
                    }

                    lstResult.Add(iToleransi);
                }

                iToleransi = 1;
            }

            if (lstResult.Count > 0)
            {
                result = lstResult.Max();
            }

            return result;
        }
    }
}
