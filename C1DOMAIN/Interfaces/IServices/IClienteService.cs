using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IServices
{
    public interface IClienteService : IBaseService
    {
        Cliente GetById(Guid clienteID);
    }
}
