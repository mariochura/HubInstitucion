namespace Domain.Entities;

public class Units
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Grade_Education_Id { get; set; }
    public Grade_Education GradeEducation { get; set; }
}