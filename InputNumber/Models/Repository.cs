using Microsoft.EntityFrameworkCore;
using InputNumber.Interface;


namespace InputNumber.Models
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

        public void Create(T _entity)
        {
            Dbset.Add(_entity);
            db.SaveChanges();
        }
    }
}
