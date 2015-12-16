namespace CherryQuest.Models.Characters
{
    using System.Runtime;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Barbarian : Character
    {
        private const int BarbarianAttack = 10;
        private const int BarbarianDefense = 2;
        private const string Image = "sheet";
        private const int RowsSplit = 4;
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
            this.Draw(spriteBatch, new Vector2(this.X,this.Y));
        }
    }
}
