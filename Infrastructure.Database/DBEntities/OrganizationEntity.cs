using Domain.Entities;

namespace Infrastructure.Database.DBEntities;

public class OrganizationEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Nit { get; set; } = "";
    public string Logo { get; set; } = "";
    public DateTime Date_Creation { get; set; }
    public string Municipality { get; set; }= "";
    public string Acronym { get; set; }= "";

    public Organization toDto()
    {
        return new Organization { Name = this.Name };
    }
}