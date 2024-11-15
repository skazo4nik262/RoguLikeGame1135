using RoguLikeGame1135.Actions;

namespace RoguLikeGame1135.Creatures
{
    public class Warrior : CreatureClass
    {
        public Warrior()
        {
            MaxHP = 100;
            Damage = 10;
            Armor = 22;
            CurrentHP = 100;
            Actions.Add(new LightAttackTarget());
            Actions.Add(new MultiAtacktarget());
        }
    }
}
