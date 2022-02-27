namespace DotNETAPI.Models;

public class Pizza {
    public int? id { get; set;}
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public decimal? Price { get; set; }
    public bool? isGlutenFree { get; set; }
}