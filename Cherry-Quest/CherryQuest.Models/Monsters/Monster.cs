namespace CherryQuest.Models.Monsters
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Models;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Spells;

    public abstract class Monster : DrawableGameObject, IMonster
    {
        private readonly TimeSpan attackCooldown = TimeSpan.FromMilliseconds(3000);
        private TimeSpan lastAttackTime = TimeSpan.FromMilliseconds(0);
        private IList<ISpell> attacks; 

        protected Monster( int health, int attack, int defence, int rows, int cols, ContentManager content) 
            : base(rows, cols)
        { 
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
            this.attacks = new List<ISpell>();
            this.Content = content;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public IEnumerable<ISpell> Attacks
        {
            get
            {
                return this.attacks;
            }
        } 

        public Rectangle BoundingBox => new Rectangle(this.X, this.Y, this.SpriteWidth / 2, this.SpriteHeight / 2);

        public int Health { get; set; } 

        public int Attack { get; set; }

        public int Defence { get; set; }

        public ObjectState ObjectState { get; set; }

        protected ContentManager Content { get; }

        public void PerformAttack(GameTime gameTime)
        {
            //this.attacks.Add(new BarbFireSpell(this.Content, this.X - 15, this.Y + 20));

            if (this.lastAttackTime + this.attackCooldown < gameTime.TotalGameTime)
            {
                this.attacks.Add(new GoblinSpell(this.Content, this.X - 15, this.Y + 20));
                this.lastAttackTime = gameTime.TotalGameTime;
            }
        }
    }
}
