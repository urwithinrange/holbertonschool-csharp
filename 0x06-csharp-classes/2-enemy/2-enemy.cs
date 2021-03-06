using System;

namespace Enemies
{
    ///<summary>class Zombie</summary>
    public class Zombie
    {
        ///<summary>Zombie health field</summary>
        public int health;
        
        ///<summary>Zombie public constructor</summary>
        public Zombie()
        {
        }

        ///<summary>Zombie public constructor sets health to value</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArithmeticException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
