using System.Runtime;

namespace Domain.Entities;

public class Study_Plan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Ministerial_Resolution { get; set; }
    public DateTime Date_Aproveer { get; set; }
    public string Number_Semester { get; set; }
    public string Hour_Load { get; set; }
    public string Title_Denomination { get; set; }
    public int Career_Id { get; set; }
    public Careers Careers { get; set; }
    public int Modality_Id { get; set; }
    public Modality Modality { get; set; }
    public int Level_academic_Id { get; set; }
    public Academic_Level Academic_Level { get; set; }
    
}