// See https://aka.ms/new-console-template for more information

using C3APPLICATION.Interfaces;
using C3APPLICATION.Services;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;
using C1DOMAIN.Services;
using C2INFRA.Repositories;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!\n");

#region CONFIGURAÇÃO IOC DI

// Configurar o contêiner de serviços
var serviceCollection = new ServiceCollection();

serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
serviceCollection.AddTransient<IClienteService, ClienteService>();
serviceCollection.AddTransient<IClienteApp, ClienteApp>();

var serviceProvider = serviceCollection.BuildServiceProvider();

// Resolver o contêiner de serviço
var clienteApp = serviceProvider.GetService<IClienteApp>();

#endregion

#region C3APPLICATION

if (clienteApp != null) // Verificar se serviceProvider não é nulo
{
    var clientes = clienteApp.GetAll();
    if (clientes != null)
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.ClienteId}, Nome: {cliente.Nome}");
        }
    }
    else
    {
        Console.WriteLine("Nenhum cliente encontrado.");
    }

    var objCliente = clienteApp.GetById(Guid.Parse("f34b9d97-bdf3-4561-a35f-63a68bfb9cd3"));
    if (objCliente != null)
    {
        Console.WriteLine($"\nID: {objCliente.ClienteId}, Nome: {objCliente.Nome}");
    }
    else
    {
        Console.WriteLine("Nenhum cliente encontrado.");
    }
}
else
{
    Console.WriteLine("O serviço de cliente não foi resolvido.");
}

#endregion