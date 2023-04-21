using System;

namespace GameSix
{
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
                Console.WriteLine(enemy.GetName());
            }

            
        }
    }
}
