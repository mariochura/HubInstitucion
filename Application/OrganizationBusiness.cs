using Application.Business;
using Domain.Entities;
using Domain.Repositories;

namespace Application;

public class OrganizationBusiness: IOrganizationBusiness
{
    private readonly IOrganizationRepository _repository;

    public OrganizationBusiness(IOrganizationRepository repository)
    {
        _repository = repository;
    }

    public void Save(Organization itemToSave)
    {
        _repository.Save(itemToSave);
    }

    public Organization GetById(int id)
    {
        return _repository.GetById(id);
    }
}