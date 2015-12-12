namespace TW.Monsters
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Monster : GameObject, IMonster
    {
        protected Monster(string name, Position position, int health, int attack, int defence, bool isAlive, MonsterType type) 
            : base(position, name)
        { 
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
            this.IsAlive = isAlive;
            this.Type = type;
        }

        public MonsterType Type { get; set; }

        public int Health { get; set; } 

        public int Attack { get; set; }

        public int Defence { get; set; }

        public bool IsAlive { get; set; }

    }
}
