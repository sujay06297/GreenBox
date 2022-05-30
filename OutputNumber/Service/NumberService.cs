using GreenBox.Common;
using GreenBox.Interface;
using OutputNumber.Interface;
using OutputNumber.Models;

namespace OutputNumber.Service
{
    public class NumberService : INumberService
    {
        private readonly IRepository<Number> _repNumber;
        private readonly INumberHelper _numberHelper;
        private readonly ILogger<NumberHelper> _logger;

        public NumberService(IRepository<Number> rep, INumberHelper numberHelper, ILogger<NumberHelper> logger)
        {
            _repNumber = rep;
            _numberHelper = numberHelper;
            _logger = logger;
        }

        public string GetNumber()
        {
            var missingNumber = string.Empty;

            var number = _repNumber.GetAll().OrderByDescending(x => x.CreateDatetime).FirstOrDefault().Value;
            try
            {
                if (!string.IsNullOrEmpty(number))
                {
                    int[] numberlist = number.Split(',').Select(c => Convert.ToInt32(c)).ToArray();
                    missingNumber = _numberHelper.MissingNumber(numberlist);
                }

                return missingNumber;
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetNumber 發生錯誤,number:{number},{ex.Message.ToString()}");
                throw;
            }
        }



    }
}
