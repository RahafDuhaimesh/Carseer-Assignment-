using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICarService
{
    Task<List<CarMake>> GetAllMakesAsync();
    Task<List<VehicleType>> GetVehicleTypesForMakeIdAsync(int makeId);
    Task<List<CarModel>> GetModelsForMakeYearAsync(int makeId, int year);
}
