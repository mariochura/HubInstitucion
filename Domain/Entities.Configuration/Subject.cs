using System.Runtime;

namespace Domain.Entities;

public class Subject
{
    public int Id { get; set; }
    public int Order_Subject { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int Theoretical_Hours { get; set; }
    public int Practical_Hours { get; set; }
    public int Total_Hours { get; set; }
    public int Credit { get; set; }
    public int Aproval_Note { get; set; }
    public int Semester_Id { get; set; }
    public Semester Semester { get; set; }
    public int Education_Level_Id { get; set; }
    public Education_Level EducationLevel{ get; set; }
    public int Curricular_Area_Id { get; set; }
    public Curricular_Area Curricular_Area { get; set; }
    public int Study_Plan_id { get; set; }
    public Study_Plan StudyPlan { get; set; }
    
}
