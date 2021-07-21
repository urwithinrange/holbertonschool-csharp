using System;

namespace Enemies
{
    ///<summary>class Zombie</summary>
    public class Zombie
    {
        ///<summary>Zombie private field</summary>
        private int health;
        
        ///<summary>Zombie private field</summary>
        private string name = "(No name)"; 

        ///<summary>Zombie public property</summary>
        public string Name
        {
            get => name;
            set
            {
                if (value != null)
                    name = value;
            }
        }

        ///<summary>Zombie public constructor</summary>
        public Zombie()
        {
        }

        ///<summary>Zombie public constructor with a value</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArithmeticException("Health must be greater than or equal to 0");
            this.health = value;
        }

        ///<summary>Zombie public method returning health value</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}