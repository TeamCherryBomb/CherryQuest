namespace CherryQuest.Models.Monsters
{
    using Enums;
    using Models;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using System;

    public abstract class Monster : DrawableGameObject, IMonster
    {
        protected Monster( int health, int attack, int defence, int rows, int cols) 
            : base(rows, cols)
        { 
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Rectangle BoundingBox => new Rectangle(this.X, this.Y, this.SpriteWidth / 2, this.SpriteHeight / 2);

        public int Health { get; set; } 

        public int Attack { get; set; }

        public int Defence { get; set; }

        public ObjectState ObjectState { get; set; }

    }
}
