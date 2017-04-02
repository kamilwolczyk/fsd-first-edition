namespace Fsd.Cs.ConsoleApp.Vehicles.Features
{
    public interface IComfort
    {
        int WindowCount { get; }

        void TurnClimatronicOn();

        void TurnClimatronicOff();
    }
}
