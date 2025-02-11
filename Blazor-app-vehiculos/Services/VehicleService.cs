using Blazor_app_vehiculos.Models;

namespace Blazor_app_vehiculos.Services;

public class VehicleService
{
    // Almacenamiento estático compartido para mantener los datos mientras la aplicación está corriendo
    private static readonly List<Vehicle> _vehicles = new();
    private static int _nextId = 1;

    public Task<List<Vehicle>> GetAll()
    {
        return Task.FromResult(_vehicles.ToList());
    }

    public Task Add(Vehicle vehicle)
    {
        vehicle.Id = _nextId++;
        _vehicles.Add(vehicle);
        return Task.CompletedTask;
    }

    public Task Update(Vehicle vehicle)
    {
        var index = _vehicles.FindIndex(v => v.Id == vehicle.Id);
        if (index != -1)
        {
            _vehicles[index] = vehicle;
        }
        return Task.CompletedTask;
    }

    public Task Delete(int id)
    {
        var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
        if (vehicle != null)
        {
            _vehicles.Remove(vehicle);
        }
        return Task.CompletedTask;
    }
} 