using RoguLikeGame1135.Actions;

namespace RoguLikeGame1135.Creatures
{
    public class Mage : CreatureClass
    {
        public Mage()
        {
            MaxHP = 100;
            Damage = 11;
            Armor = 5;
            CurrentHP = 100;
            Actions.Add(new LightAttackTarget());
            Actions.Add(new MultiAtacktarget());
        }
    }
}
