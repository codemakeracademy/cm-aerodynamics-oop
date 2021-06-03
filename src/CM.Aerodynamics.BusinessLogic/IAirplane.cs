namespace CM.Aerodynamics.BusinessLogic
{
    public interface IAirplane
    {
        int Speed { get; }

        void SetSpeed(int speed);
    }
}