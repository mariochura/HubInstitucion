using Domain.Entities;

namespace Domain.Repositories;

public interface IOrganizationRepository
{
    void Save(Organization itemToSave);
    Organization GetById(int id);
}