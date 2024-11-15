namespace RoguLikeGame1135.Creatures
{
    public abstract class Creature
    {
        public CreatureClass Stats { get; set; }

        public bool IsDead { get; set; } = false;

        private void Death()
        {
            Console.WriteLine("Вы умерли");
            IsDead = true;
        }

        public void TakeDamage(int damage)
        {
            var hp = Stats.CurrentHP -= damage + Stats.Armor;
            if (hp <= 0) Death();
        }

        public abstract void RunAction(Room room);

        public void RandomSpeed() => Stats.Speed = new Random().Next(11);
    }
}
