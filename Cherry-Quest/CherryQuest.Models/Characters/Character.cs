namespace CherryQuest.Models.Characters
{
    using System.Collections.Generic;
    using Interfaces;
    using Monsters;

    public abstract class Character : GameObject, ICharacter
    {
        private ICollection<Monster> monsters;

        protected Character(string name, Position position, int attack, int defence, CharacterLevel level, int gold)
            : base(position, name)
        {
            this.Attack = attack;
            this.Defence = defence;
            this.Level = level;
            this.Gold = gold;
            this.monsters = new HashSet<Monster>();
        }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public CharacterLevel Level { get; set; }

        public int Gold { get; set; } // cherries

        public virtual ICollection<Monster> Monsters
        {
            get { return this.monsters; }
            set { this.monsters = value; }
        }
    }
}
