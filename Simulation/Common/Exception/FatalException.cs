namespace Simulation.Common.Exception;

public class FatalException : SimulationExceptionBase
{
    protected FatalException(string message, System.Exception? innerException)
        : base(ExceptionType.Fatal, message, innerException)
    {
    }

    protected FatalException() : base(ExceptionType.Fatal,
        "Возникла фатальная ошибка. Дополнительной информации предоставлено не было.",
        null)
    {
    }
}