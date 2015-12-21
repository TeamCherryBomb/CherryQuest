namespace CherryQuest.Models.Spells
{
    using Enums;
    using Interfaces;
    using Microsoft.Xna.Framework;

    public abstract class Spell : DrawableGameObject, ISpell
    {
        protected Spell(int rows, int cols) : base(rows, cols)
        {

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

        public int X { get; set; }

        public int Y { get; set; }

        public ObjectState ObjectState { get; set; }

        //TODO very bad practise, Edo, please find properway to remove the spells, after we don't need them....
        public void Dispose()
        {
            this.X = 10000;
        }
    }
}