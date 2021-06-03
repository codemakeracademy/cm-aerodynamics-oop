namespace CM.Aerodynamics.BusinessLogic
{
    public class SimpleAirplane : Airplane
    {
        public override int Multiplier { get; set; }

        public override int GetSpeed()
        {
            return Speed;
        }
    }
}