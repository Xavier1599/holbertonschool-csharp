using System;

namespace Enemies
{
    /// <summary> Represents empty class. </summary>
    class Zombie
    {
        /// <summary> public field </summary>
        public int health;
        /// <summary> public constructor </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> public constructor with parameter </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be grater than or equal to 0");
            }
            health = value;
        }
    }    
}