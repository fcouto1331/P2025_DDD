namespace C1DOMAIN.Interfaces
{
    public interface IBaseRepository
    {
        List<T> GetAll<T>() where T : class;
    }
}
