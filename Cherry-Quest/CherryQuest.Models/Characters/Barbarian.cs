namespace CherryQuest.Models.Characters
{
    using System.Runtime;
    using Enums;
    using Microsoft.Win32.SafeHandles;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Barbarian : Character
    {
        private const int BarbarianAttack = 10;
        private const int BarbarianDefense = 2;
        private const string Image = "dude";
        private const int RowsSplit = 5;
        private const int ColsSplit = 6;

        public Barbarian(ContentManager content, int x, int y)
            : base(BarbarianAttack, BarbarianDefense, RowsSplit, ColsSplit)
        {
            this.Texture = content.Load<Texture2D>(Image);

            //TODO validations
            this.X = x;
            this.Y = y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            this.Draw(spriteBatch, new Vector2(this.X, this.Y), this.ObjectState);
        }
    }
}
