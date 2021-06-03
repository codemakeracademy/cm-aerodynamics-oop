using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Aerodynamics.BusinessLogic
{
    public abstract class Airplane : IAirplane
    {
        private int _speed;

        public abstract int Multiplier { set; get; }

        public int Speed
        {
            set { _speed = value; }
            get { return _speed; }
        }
    
        public virtual void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public abstract int GetSpeed();
    }
}
