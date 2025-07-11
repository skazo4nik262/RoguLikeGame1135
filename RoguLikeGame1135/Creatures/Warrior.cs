﻿using RoguLikeGame1135.Actions;

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
            Names = new string[] { "Арагорн", "Конан", "Ахилл", "Гектор", "Спартак", "Александр Македонский", "Юлий Цезарь", "Ричард Львиное Сердце", "Жанна д\'Арк", "Уильям Уоллес", "Беовульф", "Роланд" };
            SubClass = new string[] { "Гладиатор", "Рыцарь", "Берсерк", "Паладин", "Воитель", "Варвар", "Кровожад", "Ярость", "Мечник", "Копейщик", "Топорник", "Булава" };
            Nicks = new string[] { "Железный Кулак", "Громовой Клинок", "Кровавый Берсерк", "Несокрушимый Щит", "Быстрый Меч", "Могучий Топор", "Яростный Воитель", "Убийца Драконов", "Повелитель Битвы", "Защитник Королевства", "Рыцарь Света", "Темный Рыцарь" };
        }
    }
}
