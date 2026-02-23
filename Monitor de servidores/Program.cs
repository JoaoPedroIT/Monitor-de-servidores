using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monitor_de_servidores;

var servers = new List<Server>
{
    new Server
    {
        ID = 1,
        Name = "Servidor 1",
        Status = Server.ServerStatus.Online,
        IPAddress = "192.168.0.10",
        CpuUsage = 0,
        MemoryUsage = 0,
        LastCheck = DateTime.MinValue
    },
    new Server
    {
        ID = 2,
        Name = "Servidor 2",
        Status = Server.ServerStatus.Offline,
        IPAddress = "192.168.0.11",
        CpuUsage = 0,
        MemoryUsage = 0,
        LastCheck = DateTime.MinValue
    },
    new Server
    {
        ID = 3,
        Name = "Servidor 3",
        Status = Server.ServerStatus.Maintenance,
        IPAddress = "192.168.0.12",
        CpuUsage = 0,
        MemoryUsage = 0,
        LastCheck = DateTime.MinValue
    }
};

var random = new Random();

static async Task MonitorServers(List<Server> servers)
{
    var rnd = new Random();

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Monitor de Servidores");
        Console.WriteLine("=====================");

        foreach (var server in servers)
        {
            // Atualiza métricas
            server.CpuUsage = rnd.Next(0, 100);
            server.MemoryUsage = rnd.Next(0, 100);
            server.LastCheck = DateTime.Now;
            server.Status = Server.ServerStatus.Online;

            Console.WriteLine($"ID: {server.ID} | Name: {server.Name} | Status: {server.Status} | IP: {server.IPAddress} | CPU: {server.CpuUsage}% | MEM: {server.MemoryUsage}%");
        }

        await Task.Delay(5000);
    }
}

// Exemplo de uso inicial: calcular métricas iniciais e detectar alertas
foreach (var server in servers)
{
    server.CpuUsage = random.Next(0, 100);
    server.MemoryUsage = random.Next(0, 100);
    server.LastCheck = DateTime.Now;

    if (server.CpuUsage > 90 || server.MemoryUsage > 90)
    {
        Console.WriteLine($"Alerta: O servidor {server.Name} está com uso crítico!");
    }
}

var criticalServers = servers
    .Where(s => s.CpuUsage > 80 || s.MemoryUsage > 85)
    .ToList();

var tasks = servers.Select(server => CheckServer(server));
await Task.WhenAll(tasks);
static async Task CheckServer(Server server)
{
    await Task.Delay(500);
}
