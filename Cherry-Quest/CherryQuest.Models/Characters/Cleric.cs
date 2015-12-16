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
        private const int x = 400;
        private const int y = 200;

        //TODO Context
        public Cleric(ContentManager content, int rows, int cols) 
            : base(ClericAttack, ClericDefense, rows, cols)
        {
            this.Texture = content.Load<Texture2D>(image);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(x, y));
        }
    }
}
