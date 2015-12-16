namespace CherryQuest.Models.Characters
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Enums;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Monsters;

    public abstract class Character : DrawableGameObject, ICharacter
    {
        private const int DefaultStartingGold = 0;

        private readonly IEnumerable<Monster> monsters;

        protected Character(int attack, int defence, int rows, int cols)
            : base( rows, cols)
        {
            this.ObjectState = ObjectState.Moving;
            this.Attack = attack;
            this.Defence = defence;
            this.Level = new CharacterLevel();
            this.Gold = DefaultStartingGold;
            this.monsters = new HashSet<Monster>();
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(this.X, this.Y, 
                    this.SpriteWidth / 2, 
                    this.SpriteHeight / 2);
            }
        }

        public CharacterLevel Level { get; set; }

        public int Gold { get; set; } // cherries

        public virtual IEnumerable<Monster> Monsters
        {
            get { return this.monsters; }
        }

        public ObjectState ObjectState { get; set; }
    }
}
