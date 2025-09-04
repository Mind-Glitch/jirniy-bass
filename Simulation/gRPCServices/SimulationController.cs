using Grpc.Core;
using Simulation.gRPC;

namespace Simulation.gRPCServices;

public class SimulationController : 
    SimulationControllerService.SimulationControllerServiceBase
{
    public override Task Control(
        IAsyncStreamReader<SimulationCommand> requestStream,
        IServerStreamWriter<SimulationStatus> responseStream,
        ServerCallContext context)
    {
        return Task.CompletedTask;
    }
}