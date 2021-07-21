﻿using System;

namespace Enemies
{
    public class Zombie
    {
        public int health;
        public Zombie()
        {
        }
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArithmeticException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
