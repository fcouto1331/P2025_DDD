using C3APPLICATION.DTOs;
using C1DOMAIN.Entities;

namespace C3APPLICATION.Mapping
{
    public partial class Mapper
    {
        public static void ToCliente(List<ClienteDTO> clienteDto, out List<Cliente> cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = clienteDto.Select(dto => new Cliente(
                dto.Nome ?? string.Empty,
                dto.ClienteId
                )).ToList();
        }

        public static void ToCliente(ClienteDTO clienteDto, out Cliente cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = new Cliente(
                clienteDto.Nome ?? string.Empty,
                clienteDto.ClienteId
                );
        }
    }
}
