namespace CherryQuest.Models.Monsters
{
    using Models;
    using Interfaces;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Monster : DrawableGameObject, IMonster
    {
        protected Monster( int health, int attack, int defence, Texture2D texture, int rows, int cols) 
            : base(texture, rows, cols)
        { 
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
        }

        public int Health { get; set; } 

        public int Attack { get; set; }

        public int Defence { get; set; }
    }
}
