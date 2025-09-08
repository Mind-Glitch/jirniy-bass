namespace Simulation.Common.Entity.Colonist;

internal class Colonist : Entity
{
    private string _name = string.Empty;

    internal string Name
    {
        get => _name;
        set => SetProperty(ref _name, value,
            Shared.Metrics.Package.Colonist.Name);
    }

    private float _hunger;

    internal float Hunger
    {
        get => _hunger;
        set => SetProperty(ref _hunger, value,
            Shared.Metrics.Package.Colonist.Hunger);
    }

    private float _thirst;

    internal float Thirst
    {
        get => _thirst;
        set => SetProperty(ref _thirst, value,
            Shared.Metrics.Package.Colonist.Thirst);
    }

    private float _mentalState;

    internal float MentalState
    {
        get => _mentalState;
        set => SetProperty(ref _mentalState, value,
            Shared.Metrics.Package.Colonist.MentalState);
    }

    private float _employmentRate;

    internal float EmploymentRate
    {
        get => _employmentRate;
        set => SetProperty(ref _employmentRate, value,
            Shared.Metrics.Package.Colonist.EmploymentRate);
    }

    private float _health;

    internal float Health
    {
        get => _health;
        set => SetProperty(ref _health, value,
            Shared.Metrics.Package.Colonist.Health);
    }

    private float _radiationExposure;

    internal float RadiationExposure
    {
        get => _radiationExposure;
        set => SetProperty(ref _radiationExposure, value,
            Shared.Metrics.Package.Colonist.RadiationExposure);
    }
}