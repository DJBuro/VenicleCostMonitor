﻿namespace VehicleCostsMonitor.Web.Areas.Vehicle.Models
{
    using Common.AutoMapping.Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Services.Models.Vehicle;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static VehicleCostsMonitor.Models.Common.ModelConstants;

    public class VehicleUpdateViewModel : IAutoMapWith<VehicleUpdateServiceModel>
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Make")]
        public int ManufacturerId { get; set; }

        public IEnumerable<SelectListItem> AllManufacturers { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string ModelName { get; set; }

        public IEnumerable<SelectListItem> AllModels { get; set; }

        [Display(Name = "Exact model name")]
        public string ExactModelname { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int YearOfManufacture { get; set; }

        public IEnumerable<SelectListItem> AvailableYears { get; set; }

        [Required]
        [Range(EngineHorsePowerMinValue, EngineHorsePowerMaxValue)]
        [Display(Name = "Engine horse power")]
        public int EngineHorsePower { get; set; }

        [Required]
        [Display(Name = "Vehicle type")]
        public int VehicleTypeId { get; set; }

        public IEnumerable<SelectListItem> AllVehicleTypes { get; set; }

        [Required]
        [Display(Name = "Fuel type")]
        public int FuelTypeId { get; set; }

        public IEnumerable<SelectListItem> AllFuelTypes { get; set; }

        [Required]
        [Display(Name = "Gearing type")]
        public int GearingTypeId { get; set; }

        public IEnumerable<SelectListItem> AllGearingTypes { get; set; }
    }
}
