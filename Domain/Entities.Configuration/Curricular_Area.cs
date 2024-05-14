namespace Domain.Entities;

public class Curricular_Area
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Formation_Axes_Id { get; set; }
    public Formation_Axes Formation_Axes { get; set; }
    
}