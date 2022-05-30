using GreenBox.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBox.Common
{
    public class NumberHelper : INumberHelper
    {
        private readonly ILogger<NumberHelper> _logger;

        public NumberHelper(ILogger<NumberHelper> logger)
        {
            _logger = logger;
        }

        public string MissingNumber(int[] numberArray)
        {
            try
            {
                string result = string.Empty;
                int a = numberArray.OrderBy(x => x).First();
                int b = numberArray.OrderBy(x => x).Last();
                List<int> myList2 = Enumerable.Range(a, b - a + 1).ToList();
                List<int> remaining = myList2.Except(numberArray).ToList();
                if (remaining.Any())
                {
                    string missingNumber = string.Empty;
                    foreach (int r in remaining)
                    {
                        missingNumber += $",{r}";
                    }
                    result = missingNumber.Remove(0, 1);
                }
                else
                {
                    result = "數字清單中無缺少的值";
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"MissingNumber 發生錯誤,{ex.Message}");
                throw;
            }

        }



    }
}
