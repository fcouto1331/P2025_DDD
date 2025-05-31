namespace C1DOMAIN.Interfaces
{
    public interface IBaseService
    {
        List<T> GetAll<T>() where T : class;
    }
}
