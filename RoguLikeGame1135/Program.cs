using RoguLikeGame1135.Creatures;
using RoguLikeGame1135.Enemies;

namespace RoguLikeGame1135
{
    public class Program
    {
        public static List<Enemy> AllEnemies { get; set; } = new List<Enemy>() { new EnemySkeletonMage(), new EnemySkeletonWarrior(), new EnemyGoblinMage(), new EnemyGoblinWarrior(), new EnemyElfMage(), new EnemyElfWarrior() };
        static void Main(string[] args)
        {
            while (true)
            {
                new Room(new Player(), AllEnemies).RunBattle();
            }
        }
    }
}
