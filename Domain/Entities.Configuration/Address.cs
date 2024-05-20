namespace Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Lengh { get; set; }
    public string Province_Id { get; set; }
    public Province Province { get; set; }
    public ICollection<Branch> Branches { get; set; }
    public int BranchId { get; set; }
    public Branch Branch { get; set; }
    
}