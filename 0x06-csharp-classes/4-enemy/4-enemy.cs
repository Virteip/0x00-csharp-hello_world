using System;

namespace Enemies
    {
    ///<summary>Create public Zombie Class</summary>
        public class Zombie
        {
          public int health;
          private string name = "(No name)";

    ///<summary>Zombie constructor.</summary>
          public Zombie(){
            health = 0;
          }

    ///<summary>Zombie constructor with health check.</summary>
          public Zombie(int value)
          {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
          }

    ///<summary>Get the health value</summary>
          public int GetHealth()
          {
            return (health);
          }

    ///<summary>Get/Set the name value</summary>
          public string Name
          {
            get {
              return name;
            }
            set {
              name = value;
            }
          }
        }
    }
