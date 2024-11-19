using System.Runtime.CompilerServices;

namespace RoguLikeGame1135.Creatures
{
    public class Player : Creature
    {
        private Mage mage = new();
        private Warrior warrior = new();


        public Player()
        {
            Color = ConsoleColor.Green;
            Console.WriteLine($"Выберите класс:\n 1) Mage: \tMax HP: {mage.MaxHP}\n, \tArmor: {mage.Armor}\n, \tDamage: {mage.Damage}\n2) Warrior: \tMax HP: {warrior.MaxHP}\n, \tArmor: {warrior.Armor}\n, \tDamage: {warrior.Damage}");
            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Stats = new Mage();
                    break;
                case "2":
                    Stats = new Warrior();
                    break;
                default:
                    Console.WriteLine("Невенрный ввод");
                    break;

            }
            Console.WriteLine("Введите имя персонажа");
            Stats.Name = Console.ReadLine();
        }

        public override void RunAction(Room room)
        {
            Stats.PrintActions();
            Console.WriteLine("Введите номер атаки, которую хотите выбрать");
            switch (Console.ReadLine())
            {
                case "1":
                    Stats.Actions[0].Run(this, room);
                    Stats.PrintStats(Stats.Actions[0]);
                    break;
                case "2":
                    Stats.Actions[1].Run(this, room);
                    Stats.PrintStats(Stats.Actions[1]);
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }

        }
    }
}
