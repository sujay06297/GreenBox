namespace OutputNumber.Interface
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
    }
}
