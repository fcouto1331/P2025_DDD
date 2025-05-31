using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;

namespace C1DOMAIN.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }

        public List<T> GetAll<T>() where T : class
        {
            return _clienteRepository.GetAll<T>();
        }

        public Cliente GetById(Guid clienteID)
        {
            Cliente model = _clienteRepository.GetById(clienteID);
            model.AlterarNome(model.Nome?.ToUpper()); // Regra de negócio: Nome deve ser em maiúsculas
            return model;
        }
    }
}
