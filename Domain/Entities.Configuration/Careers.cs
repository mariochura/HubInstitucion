using System.Security.Principal;

namespace Domain.Entities;

public class Careers
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Foundation_Date { get; set; }
    public int Address_Id { get; set; }
    public string Detail { get; set; }
    public string Acronym { get; set; }
    public string Logo { get; set; }
    public int Unit_Id { get; set; }
    public Units Units { get; set; }
    public int Branch_Id { get; set; }
    public Branch Branch { get; set; }
    public int Person_Id { get; set; }
    public Person Person { get; set; }
    
}