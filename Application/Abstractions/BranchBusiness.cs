using Domain.Entities;
using Domain.Repositories;

namespace Application;

public class BranchBusiness : IBranchRepository
{
    private readonly IBranchRepository _repository;

    public BranchBusiness(IBranchRepository repository)
    {
        _repository = repository;
    }

    public void Save(Branch itemToSave)
    {
        _repository.Save(itemToSave);
    }

    public Branch GetById(int id)
    {
        return _repository.GetById(id);
    }
}