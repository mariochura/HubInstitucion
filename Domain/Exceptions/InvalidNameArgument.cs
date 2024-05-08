namespace Infrastructure.Exceptions;

public class InvalidNameArgument: Exception
{
    public InvalidNameArgument() : base("Nombre invalido")
    {
    }
}