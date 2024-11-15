using RoguLikeGame1135.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguLikeGame1135.Actions
{
    public abstract class CreatureAction
    {
        public string Title { get; set; }

        public abstract void Run(Creature creature, Room room);

    }

    public class LightAttackTarget : AttackOneTarget
    {
        Random rnd = new Random();
        public LightAttackTarget()
        {
            Title = "Лёгкая атака";
        }
        public override void Run(Creature creature, Room room)
        {
            int i = 1;
            if (creature is Player)
            {
                Console.WriteLine("Выберите атакуемого противника");
                foreach (var enemy in room.Enemies)
                {
                    Console.WriteLine($"{++i}) {enemy.Stats.Name}: {enemy.Stats.CurrentHP}");
                }
                try
                {
                    i = int.Parse(Console.ReadLine()) - 1;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, пожалуйста введите номер противника");
                }
                room.Enemies[i].TakeDamage(rnd.Next(1, 6) + creature.Stats.Damage);
            }
            else
            {
                Console.WriteLine($"Противник {creature.Stats.Name} проводит атаку");
                room.Player.TakeDamage(rnd.Next(1, 6) + creature.Stats.Damage);
                Console.WriteLine($"После атаки {creature.Stats.Name} у вас осталось {room.Player.Stats.CurrentHP}");
            }
        }
    }
    public class MultiAtacktarget : AttackAllTarget
    {
        Random rnd = new Random();
        public MultiAtacktarget()
        {
            Title = "Атака по группе";
        }

        public override void Run(Creature creature, Room room)
        {
            List<Creature> targets = new List<Creature>();

            if (creature is Player)
            {
                targets.AddRange(room.Enemies);

            }
            else
            {
                targets.Add(room.Player);
                targets[0].TakeDamage(rnd.Next(1, 4) + creature.Stats.Damage / 2);
            }
        }
    }
}
