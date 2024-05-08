using Domain.Entities;
using Infrastructure.Database.DBEntities;

namespace Infrastructure.Database.Extensions;

public static class OrganizationExtensions
{
    public static OrganizationEntity GetDbEntity(this Organization dto)
    {
        return new OrganizationEntity
        {
            Name = dto.name
        };
    }
}