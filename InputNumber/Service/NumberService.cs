using InputNumber.Interface;
using InputNumber.Models;

namespace InputNumber.Service
{
    public class NumberService : INumberService
    {
        IRepository<Number> repNumber;
        public NumberService(IRepository<Number> rep)
        {
            repNumber = rep;
        }
        public void CreateNumber(string number)
        {
            Number n = new Number();
            n.Id = Guid.NewGuid();
            n.Value = number;
            n.CreateDatetime = DateTime.Now;
            repNumber.Create(n);
        }
    }
}
