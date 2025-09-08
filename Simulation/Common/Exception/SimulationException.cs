namespace Simulation.Common.Exception;

public class SimulationException : SimulationExceptionBase
{
    protected SimulationException(string message, System.Exception? innerException)
        : base(ExceptionType.Fatal, message, innerException)
    {
    }

    protected SimulationException() : base(ExceptionType.Fatal,
        "Возникло исключение. Дополнительной информации предоставлено не было.",
        null)
    {
    }
}