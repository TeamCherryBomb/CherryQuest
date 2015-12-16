namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Cleric : Character
    {
        private const int ClericAttack = 4;
        private const int ClericDefense = 8;
        private const string image = "test";
        private const int rowsSplit = 2;
        private const int colsSplit = 5;

        //TODO Context
        public Cleric(ContentManager content, int x, int y) 
            : base(ClericAttack, ClericDefense, rowsSplit, colsSplit)
        {
            this.Texture = content.Load<Texture2D>(image);
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(this.X, this.Y));
        }
    }
}
