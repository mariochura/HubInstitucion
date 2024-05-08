using Domain.Entities;

namespace Application.Business;

public interface IOrganizationBusiness
{
    void Save(Organization itemToSave);
    Organization GetById(int id);
}