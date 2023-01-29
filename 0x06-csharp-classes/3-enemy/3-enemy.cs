using System;

namespace Enemies
{
	///<summary>Skeleton Zombie Class, now with health</summary>///
	class Zombie
	{
		///<value>Enemy's total life. Dead at zero or below</value>///
		private int health;
		///<summary>Class Constructor; sets health to zero</summary>///
		public Zombie()
		{
			health = 0;
		}
		///<summary>Class Constructor; takes arguments and validates them</summary>///
		public Zombie(int value)
		{
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			else
				health = value;
		}
		///<summary>Returns the entity's current health</summary>///
		public int GetHealth()
		{
			return this.health;
		}
	}
}
