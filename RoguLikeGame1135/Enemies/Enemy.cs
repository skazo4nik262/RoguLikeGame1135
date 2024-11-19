using RoguLikeGame1135.Creatures;

namespace RoguLikeGame1135.Enemies
{
    public abstract class Enemy : Creature
    {
        
        Random rnd = new Random();
        public Enemy()
        {
            Color = ConsoleColor.Red;
        }
        public override void RunAction(Room room)
        {
            var a = Stats.Actions[rnd.Next(0, Stats.Actions.Count)];
            if (IsDead) return;
            else { a.Run(this, room); Stats.PrintStats(a); }
        }
    }
}
