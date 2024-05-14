namespace Domain.Entities;

public class Dependent_Subject
{
    public int Id { get; set; }
    public string Dependent_Code { get; set; }
    public int Subject_Id { get; set; }
    public Subject? Subject { get; set; }
}