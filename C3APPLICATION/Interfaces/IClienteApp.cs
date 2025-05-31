using C3APPLICATION.DTOs;

namespace C3APPLICATION.Interfaces
{
    public interface IClienteApp
    {
        List<ClienteDTO> GetAll();
        ClienteDTO GetById(Guid ClienteId);
    }
}
