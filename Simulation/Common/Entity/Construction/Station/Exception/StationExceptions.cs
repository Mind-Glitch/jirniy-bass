namespace Simulation.Common.Entity.Construction.Station.Exception;

public class PayloadTransferException : System.Exception
{
}

public class NoFreeSpaceException : PayloadTransferException
{
}