using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name = "(No name)";        
        public string Name
        {
            get => name;
            set
            {
                if (value != null)
                    name = value;
            }
        }
        
        public Zombie()
        {
        }
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArithmeticException("Health must be greater than or equal to 0");
            this.health = value;
        }
        public int GetHealth()
        {
            return health;
        }
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}