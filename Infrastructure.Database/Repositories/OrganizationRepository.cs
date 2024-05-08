using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Database.DBEntities;
using Infrastructure.Database.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories;

public class OrganizationRepository: IOrganizationRepository
{
    private readonly HubInstitutionContext _dbContext;

    public OrganizationRepository(HubInstitutionContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Save(Organization itemToSave)
    {
        _dbContext.Add(itemToSave.GetDbEntity());
        _dbContext.SaveChanges();
    }

    public Organization GetById(int id)
    {
        return _dbContext.Organizations.FirstOrDefault(b => b.Name.Equals("Jose"))?.toDto() ?? new Organization();
    }
}