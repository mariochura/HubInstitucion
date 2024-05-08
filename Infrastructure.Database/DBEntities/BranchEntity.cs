namespace Infrastructure.Database.DBEntities;

public class BranchEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int OrganizationId { get; set; }
}