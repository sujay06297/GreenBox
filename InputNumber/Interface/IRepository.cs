namespace InputNumber.Interface
{
    public interface IRepository<T> where T : class
    {
        public void Create(T _entity);
    }
}
