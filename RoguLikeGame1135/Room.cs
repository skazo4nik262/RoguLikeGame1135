using RoguLikeGame1135.Creatures;

namespace RoguLikeGame1135
{
    public class Room
    {
        public Creature Player { get; set; }

        public List<Creature> Enemies { get; set; }

        public Room(Creature player)
        {
            Player = player;
            Enemies = new List<Creature>() { new Enemy(), new Enemy(), new Enemy() };
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
