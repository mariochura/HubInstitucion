namespace Domain.Entities;

public class Province
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int CountryId { get; set; }  // FK de Country
    public Country Country { get; set; }  // Objeto de navegación a Country
}