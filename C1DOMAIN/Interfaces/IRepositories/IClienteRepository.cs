using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IRepositories
{
    public interface IClienteRepository : IBaseRepository
    {
        Cliente GetById(Guid clienteId);
    }
}
