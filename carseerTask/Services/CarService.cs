using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CarService : ICarService
{
    private readonly HttpClient _httpClient;

    public CarService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CarMake>> GetAllMakesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ApiResponse<CarMake>>(
            "https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json");

        return response?.Results ?? new List<CarMake>();
    }

    public async Task<List<VehicleType>> GetVehicleTypesForMakeIdAsync(int makeId)
    {
        var response = await _httpClient.GetFromJsonAsync<ApiResponse<VehicleType>>(
            $"https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{makeId}?format=json");

        return response?.Results ?? new List<VehicleType>();
    }

    public async Task<List<CarModel>> GetModelsForMakeYearAsync(int makeId, int year)
    {
        var response = await _httpClient.GetFromJsonAsync<ApiResponse<CarModel>>(
            $"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json");

        return response?.Results ?? new List<CarModel>();
    }
}
