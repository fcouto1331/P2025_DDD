using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Mapping;
using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IServices;

namespace C3APPLICATION.Services
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteService _clienteService;
        public ClienteApp(IClienteService clienteService)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        public List<ClienteDTO> GetAll()
        {
            List<Cliente> cliente = _clienteService.GetAll<Cliente>();
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            Mapper.ClienteToClienteDto(cliente, out List<ClienteDTO> clienteDto);
            return clienteDto;
        }

        public ClienteDTO GetById(Guid ClienteId)
        {
            Cliente cliente = _clienteService.GetById(ClienteId);
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            Mapper.ClienteToClienteDto(cliente, out ClienteDTO clienteDto);
            return clienteDto;
        }
    }
}
