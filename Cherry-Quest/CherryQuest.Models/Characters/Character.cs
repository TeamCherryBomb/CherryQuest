﻿namespace CherryQuest.Models.Characters
{
    using System.Collections.Generic;
    using Interfaces;
    using Microsoft.Xna.Framework.Graphics;
    using Monsters;

    public abstract class Character : DrawableGameObject, ICharacter
    {
        private readonly IEnumerable<Monster> monsters;

        protected Character(int attack, int defence, CharacterLevel level, int gold, Texture2D texture, int rows, int cols)
            : base(texture, rows, cols)
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

        public virtual IEnumerable<Monster> Monsters
        {
            get { return this.monsters; }
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
