using System;

namespace Enemies
{
    /// <summary> Represents empty class. </summary>
    class Zombie
    {
        private string name = "(No name)";
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
        /// <summary> public prpperty Name / retrieve name / set name </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary> public method public int to return the value of health </summary>
        public int GetHealth()
        {
            return health;
        }
    }    
}