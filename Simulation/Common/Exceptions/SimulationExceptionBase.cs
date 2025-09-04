namespace Simulation.Common.Exceptions;

public class SimulationExceptionBase : Exception
{
    protected SimulationExceptionBase(ExceptionType exceptionType, string message,
        Exception? innerException) : base(message, innerException)
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