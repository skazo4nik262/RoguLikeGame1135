using RoguLikeGame1135.Actions;

namespace RoguLikeGame1135.Creatures
{
    public abstract class CreatureClass
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }

        public List<CreatureAction> Actions { get; set; }

        public void PrintActions()
        {
            Console.WriteLine("Доступные атаки:");
            foreach (CreatureAction action in Actions)
            {
                Console.WriteLine(action.Title);
            }
        }
    }
}
