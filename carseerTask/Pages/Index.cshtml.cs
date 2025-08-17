using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace carseerTask.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICarService _carService;

        public IndexModel(ICarService carService)
        {
            _carService = carService;
        }

        public List<CarMake> Makes { get; set; } = new();
        public List<VehicleType> VehicleTypes { get; set; } = new();
        public List<CarModel> Models { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int SelectedMakeId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SelectedYear { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SelectedVehicleTypeId { get; set; }

        public async Task OnGetAsync()
        {
            Makes = await _carService.GetAllMakesAsync();

            if (SelectedMakeId > 0)
                VehicleTypes = await _carService.GetVehicleTypesForMakeIdAsync(SelectedMakeId);

            if (SelectedMakeId > 0 && SelectedYear > 0)
                Models = await _carService.GetModelsForMakeYearAsync(SelectedMakeId, SelectedYear);
        }
    }
}
