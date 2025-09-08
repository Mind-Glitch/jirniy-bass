namespace Simulation.Common.Exception;

public class SimulationExceptionBase : System.Exception
{
    protected SimulationExceptionBase(ExceptionType exceptionType, string message,
        System.Exception? innerException) : base(message, innerException)
    {
        Type = exceptionType;
    }

    public enum ExceptionType
    {
        Regular,
        Fatal
    }

    public ExceptionType Type { get; private set; }
}