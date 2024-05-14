using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Last_Name { get; set; } = "";
    public string Identity_Card { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Place_Birth { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    

}