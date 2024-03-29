using System.ComponentModel.DataAnnotations;

namespace walterParcial1.ViewModels;

public class CarVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    [Display(Name = "Marca")]
    public string? BrandName {get; set; }
    public string? DealershipName {get ;set ;}
    public int Stock {get; set; }
}