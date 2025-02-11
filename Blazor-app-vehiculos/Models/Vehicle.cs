using System.ComponentModel.DataAnnotations;

namespace Blazor_app_vehiculos.Models;

public class Vehicle
{
    public int Id { get; set; }

    [Required(ErrorMessage = "La marca es obligatoria")]
    [StringLength(50, ErrorMessage = "La marca no puede tener más de 50 caracteres")]
    public string Brand { get; set; } = string.Empty;

    [Required(ErrorMessage = "El modelo es obligatorio")]
    [StringLength(50, ErrorMessage = "El modelo no puede tener más de 50 caracteres")]
    public string Model { get; set; } = string.Empty;

    [Required(ErrorMessage = "El año es obligatorio")]
    [Range(1900, 2025, ErrorMessage = "El año debe estar entre 1900 y 2025")]
    public int Year { get; set; }
} 