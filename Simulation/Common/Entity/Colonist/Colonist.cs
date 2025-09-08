namespace Simulation.Common.Entity.Colonist;

internal class Colonist : Entity
{
    private string _name = string.Empty;

    internal string Name
    {
        get => _name;
        set => SetProperty(ref _name, value,
            Shared.Metrix.Package.Colonist.Name);
    }

    private float _hunger = 0;

    internal float Hunger
    {
        get => _hunger;
        set => SetProperty(ref _hunger, value,
            Shared.Metrix.Package.Colonist.Hunger);
    }

    private float _thirst = 0;

    internal float Thirst
    {
        get => _thirst;
        set => SetProperty(ref _thirst, value,
            Shared.Metrix.Package.Colonist.Thirst);
    }

    private float _mentalState = 0;

    internal float MentalState
    {
        get => _mentalState;
        set => SetProperty(ref _mentalState, value,
            Shared.Metrix.Package.Colonist.MentalState);
    }

    private float _employmentRate = 0;

    internal float EmploymentRate
    {
        get => _employmentRate;
        set => SetProperty(ref _employmentRate, value,
            Shared.Metrix.Package.Colonist.EmploymentRate);
    }

    private float _health = 0;

    internal float Health
    {
        get => _health;
        set => SetProperty(ref _health, value,
            Shared.Metrix.Package.Colonist.Health);
    }

    private float _radiationExposure = 0;

    internal float RadiationExposure
    {
        get => _radiationExposure;
        set => SetProperty(ref _radiationExposure, value,
            Shared.Metrix.Package.Colonist.RadiationExposure);
    }
}