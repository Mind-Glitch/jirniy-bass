namespace Simulation.Common.Entity.Interface;

public interface IModule
{
    public enum Type
    {
        Living,     // жилая площадь
        Farming,    // добыча простой еды
        Telecom,    // роботы, транспорт, связь
        Storage,    // хранилище ресурсов
        Electric,   // генераторы и солнечные панели 
        Weaponry,   // Склад оружия и брони
        Transport,  // Хаб дронов
    }
}