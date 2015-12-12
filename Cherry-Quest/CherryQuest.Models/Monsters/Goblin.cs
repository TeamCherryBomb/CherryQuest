namespace TW.Monsters
{
    using System;
    using Enums;

    public class Goblin : Monster
    {
        private const int GoblinHealth = 30;
        private const int GoblinAttack = 10;
        private const int GoblinDefence = 7;

        public Goblin(int id, string name, Position position, bool isAlive)
            : base(id, name, position, GoblinHealth, GoblinAttack, GoblinDefence, isAlive, MonsterType.Warrior)
        {
        }
    }
}