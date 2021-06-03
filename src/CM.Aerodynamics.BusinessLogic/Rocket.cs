namespace CM.Aerodynamics.BusinessLogic
{
    public class Rocket : Airplane
    {
        public override int Multiplier { get; set; } = 100;

        public override void SetSpeed(int speed)
        {
            if (speed > 20000)
            {
                throw new MaxSpeedException();
            }

            if (speed < 100)
            {
                throw new SpeedIsToSmallException();
            }

            base.SetSpeed(speed * Multiplier);
        }

        public override int GetSpeed()
        {
            return Speed;
        }

        public void Accelerate()
        {
            int currentSpeed = GetSpeed();

            base.SetSpeed(currentSpeed * Multiplier);
        }
    }
}