using RoguLikeGame1135.Creatures;
using RoguLikeGame1135.Enemies;

namespace RoguLikeGame1135
{
    public class Room
    {
        public Creature Player { get; set; }

        public List<Creature> Enemies { get; set; }

        public Room(Creature player, List<Enemy> allEnemies)
        {
            Player = player;
            Enemies = new List<Creature>();
            for (int i = 0; i < new Random().Next(5); i++)
            {
                Enemies.Add(allEnemies[new Random().Next(7)]);
            }
            Console.WriteLine("Вы попали в комнату, вас окружают враги:\n");
            foreach (Enemy enemy in allEnemies) Console.WriteLine($"{enemy.Stats.Name}\n");
        }
        public void RunBattle()
        {
            var creatures = new List<Creature>();
            int round = 1;
            while (!Player.IsDead || !NoAliveEnemies())
            {
                Console.WriteLine($"Роунд {round++}");
                Player.RandomSpeed();
                foreach (var creature in Enemies)
                    creature.RandomSpeed();
                creatures.AddRange(Enemies);
                creatures.Add(Player);
                var order = creatures.OrderByDescending(s=>s.Stats.Speed);
                foreach (var creature in order)
                    creature.RunAction(this);
            }
            if (Player.IsDead == false)
            {
                Console.WriteLine("Поздравляем, вы победили");
            }
        }

        private bool NoAliveEnemies()
        {
            foreach (var creature in Enemies)
                if (creature.IsDead)
                    return true;
            return false;
        }
    }
}
