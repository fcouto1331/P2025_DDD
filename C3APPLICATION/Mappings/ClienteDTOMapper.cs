using C1DOMAIN.Entities;
using C3APPLICATION.DTOs;

namespace C3APPLICATION.Mapping
{
    public partial class Mapper
    {
        public static void ToClienteDto(List<Cliente> cliente, out List<ClienteDTO> clienteDto)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            clienteDto = cliente.Select(cliente => new ClienteDTO
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            }).ToList();
        }

        public static void ToClienteDto(Cliente cliente, out ClienteDTO clienteDto)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            clienteDto = new ClienteDTO
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            };
        }
    }
}
