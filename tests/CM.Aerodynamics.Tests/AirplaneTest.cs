using System;
using CM.Aerodynamics.BusinessLogic;
using Xunit;

namespace CM.Aerodynamics.Tests
{
    public class AirplaneTest
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            Airplane airplane = new SimpleAirplane();

        }

        [Fact]
        public void ShouldBeAbleToSetAndGetSpeed()
        {
            Airplane airplane = new SimpleAirplane();
            airplane.SetSpeed(200);

            int currentSpeed = airplane.GetSpeed();
            Assert.Equal(200, currentSpeed);

            airplane.SetSpeed(300);
            currentSpeed = airplane.GetSpeed();
            Assert.Equal(300, currentSpeed);
        }

        [Fact]
        public void ShouldBeAbleToCreateJet()
        {
            Jet jet = new Jet();
        }

        [Fact]
        public void ShouldBeAbleToSetSpeedOjJetWithMultiplier()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);

            int currentSpeed = jet.GetSpeed();
            Assert.Equal(400, currentSpeed);
        }

        [Fact]
        public void ShouldBeAbleToSetSpeedOjJetWithCustomMultiplier()
        {
            Jet jet = new Jet(customMultiplier: 3);
            jet.SetSpeed(200);

            int currentSpeed = jet.GetSpeed();
            Assert.Equal(600, currentSpeed);
        }

        [Fact]
        public void ShouldBeAbleToAccelerateJet()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);
            // 400
            jet.Accelerate();
            int currentSpeed = jet.GetSpeed();

            Assert.Equal(800, currentSpeed);
        }

        [Fact]
        public void ShouldBeAbleToUseJetAsSimpleAirplane()
        {
            IAirplane airplane = new Jet();
            Set200Speed(airplane);

            int currentSpeed = airplane.Speed;
            Assert.Equal(400, currentSpeed);
        }



        private void Set200Speed(IAirplane airplane)
        {
            airplane.SetSpeed(200);
        }

        [Fact]
        public void ShouldBeAbleToUseRocketAsSimpleAirplane()
        {
            Rocket airplane = new Rocket();
            Set200Speed(airplane);

            int currentSpeed = airplane.GetSpeed();
            Assert.Equal(20000, currentSpeed);
        }

        [Fact]
        public void ShouldNotHaveSpeedMoreThen20000()
        {
            Rocket airplane = new Rocket();

            Assert.Throws<MaxSpeedException>(() => { airplane.SetSpeed(20001); });
            Assert.Throws<SpeedIsToSmallException>(() => { airplane.SetSpeed(50); });

            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }


}
