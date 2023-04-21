using System;

namespace GameSix
{
    public enum PowerUp 
    {
        Health,
        Shield
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of enemies");
            int EnemyNumber=int.Parse( Console.ReadLine());

            Foe[] enemies=new Foe[EnemyNumber];

            for (int e=0;e<EnemyNumber;e++)
            {
                Console.WriteLine("Write the enemy name");
                string name= Console.ReadLine();
                Foe ene= new Foe(name);
                enemies[e]=ene;
            }

            Console.WriteLine("Enemies:");

            foreach (Foe enemy in enemies)
            {
                Console.WriteLine("Name: "+enemy.GetName());
                Console.WriteLine("Health: "+enemy.GetHealth());
                Console.WriteLine("Shield: "+enemy.GetShield());
            }

            foreach (Foe enemy in enemies)
            {
                enemy.PickupPowerUp(PowerUp.Health,20);
                enemy.PickupPowerUp(PowerUp.Shield,20);
                Console.WriteLine("Name: "+enemy.GetName());
                Console.WriteLine("Health: "+enemy.GetHealth());
                Console.WriteLine("Shield: "+enemy.GetShield());
            }
            foreach (Foe enemy in enemies)
            {
                enemy.TakeDamage(20);
                Console.WriteLine("Name: "+enemy.GetName());
                Console.WriteLine("Health: "+enemy.GetHealth());
                Console.WriteLine("Shield: "+enemy.GetShield());
            }

        



            
        }


    }
}
