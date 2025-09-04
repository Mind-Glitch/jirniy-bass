namespace Simulation.Common.Exceptions;

public class SimulationException : SimulationExceptionBase
{
    protected SimulationException(string message, Exception? innerException)
        : base(ExceptionType.Fatal, message, innerException)
    {
    }

    protected SimulationException() : base(ExceptionType.Fatal,
        "Возникло исключение. Дополнительной информации предоставлено не было.",
        null)
    {
    }
}