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
        private const string image = "sheet";
        private const int rowsSplit = 4;
        private const int colsSplit = 6;

        public Barbarian(ContentManager content, int x, int y) 
            : base(BarbarianAttack, BarbarianDefense, rowsSplit, colsSplit)
        {
            this.Texture = content.Load<Texture2D>(image);
            this.X = x;
            this.Y = y;
        }

        //TODO validations
        public int X { get; set; }

        public int Y { get; set; }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(this.X,this.Y));
        }
    }
}
