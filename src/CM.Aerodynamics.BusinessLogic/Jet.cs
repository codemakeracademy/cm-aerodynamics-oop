using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Aerodynamics.BusinessLogic
{
    public class Jet : Airplane
    {
        public override int Multiplier { get; set; } = 2;

        public Jet()
        {

        }

        public Jet(int customMultiplier)
        {
            Multiplier = customMultiplier;
        }

        public override void SetSpeed(int speed)
        {
            base.SetSpeed(speed * Multiplier);
        }

        public override int GetSpeed()
        {
            return Speed;
        }

        public void Accelerate()
        {
            int currentSpeed = Speed;

            Speed = 100;

            base.SetSpeed(currentSpeed * Multiplier);
        }
    }
}
