using System;

namespace GameSix
{
    public class Foe 
    {
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


    }
}