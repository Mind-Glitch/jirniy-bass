namespace Simulation.Common.Exceptions;

public class FatalException : SimulationExceptionBase
{
    protected FatalException(string message, Exception? innerException)
        : base(ExceptionType.Fatal, message, innerException)
    {
    }

    protected FatalException() : base(ExceptionType.Fatal,
        "Возникла фатальная ошибка. Дополнительной информации предоставлено не было.",
        null)
    {
    }
}