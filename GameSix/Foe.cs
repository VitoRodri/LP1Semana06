using System;

namespace GameSix
{
    public class Foe 
    {
        private static int powerups;
        private string name;
        private float health;
        private float shield;
        

        public string GetName()
        {
            SetName(name);
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public string GetPower()
        {
            return Convert.ToString( powerups);
        }
    
        public Foe(string name)
        {
            this.name=name;
            health=100;
            shield=0;
        }

        public void TakeDamage(float damage)
        {
            shield -=damage;
            if (shield<0)
            {
                float damageStillToInflict = -shield;
                shield=0;
                health -= damageStillToInflict;
                if (health<0) health=0;
            }
        }

        public void SetName(string name)
        {
            this.name=name.Trim();
        }

        public void PickupPowerUp(PowerUp power, float a)
        {
            if ((health<100) && (power==PowerUp.Health))
            {
                
                health+=a;
                
            }

            else if ((shield<100) && (power==PowerUp.Shield))
            {
                shield+=a;
            }

            if (health>100)
            {
                health=100;
            }
            if (shield>100)
            {
                shield=100;
            }
            powerups++;
        }


    }
}