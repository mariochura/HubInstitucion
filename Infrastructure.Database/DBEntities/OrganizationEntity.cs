using Domain.Entities;

namespace Infrastructure.Database.DBEntities;

public class OrganizationEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int OrganizationId { get; set; }

    public Organization toDto()
    {
        return new Organization { name = this.Name };
    }
}