using Domain.Entities;

namespace Domain.Repositories;

public interface IBranchRepository
{
    void Save(Branch itemToSave);
    
    Branch GetById(int id);
}