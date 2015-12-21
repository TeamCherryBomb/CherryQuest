namespace CherryQuest.Models.Characters
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Monsters;

    public abstract class Character : DrawableGameObject, ICharacter
    {
        private const int DefaultStartingGold = 0;
        public const int DefaultStartingHealth = 100;

        private readonly IEnumerable<Monster> monsters;
        private int health;

        protected Character(int attack, int defence, int rows, int cols)
            : base(rows, cols)
        {
            this.ObjectState = ObjectState.Moving;
            this.Attack = attack;
            this.Defence = defence;
            this.Level = new CharacterLevel();
            this.Gold = DefaultStartingGold;
            this.Health = DefaultStartingHealth;
            this.monsters = new HashSet<Monster>();
        }

        public IList<ISpell> Spells { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value > 0 ? value : 0;
            }
        }

        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(this.X, this.Y, 
                    this.SpriteWidth / 2, 
                    this.SpriteHeight / 2);
            }
        }

        public CharacterLevel Level { get; private set; }

        public int Gold { get; private set; } 

        public virtual IEnumerable<Monster> Monsters
        {
            get { return this.monsters; }
        }

        //TODO Raise the abstraction and make different attac for different characters and different attack moves for the charachters 

        public ObjectState ObjectState { get; set; }

        public void DealDamage(IMonster monster)
        {
            monster.Health -= this.Attack - monster.Defence;
        }

        public void RespondToAttack(int damage, GameTime gameTime)
        {
            //make the character block 33% of the time ... hopefully : )
            if (gameTime.TotalGameTime.Milliseconds % 3 != 0)
            {
                this.Health -= damage;
            }
        }

        public void IncreaseGold(int value)
        {
            this.Gold += value;
        }

        public abstract void UseSpell(string attackName);

        public void MoveRight()
        {
            this.ObjectState = ObjectState.Moving;
            this.Effects = SpriteEffects.None;
            this.X += 10;
        }

        public void MoveLeft()
        {
            this.ObjectState = ObjectState.Moving;
            this.Effects = SpriteEffects.FlipHorizontally;
            this.X -= 10;
        }
    }
}
