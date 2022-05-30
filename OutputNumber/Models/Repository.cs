using Microsoft.EntityFrameworkCore;
using OutputNumber.Interface;

namespace OutputNumber.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SujayTestContext db = null;
        private DbSet<T> Dbset = null;

        public Repository() //建構函式
        {
            db = new SujayTestContext();
            Dbset = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return Dbset;
        }
    }
}
