namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Barbarian : Character
    {
        private const int BarbarianAttack = 10;
        private const int BarbarianDefense = 2;
        private const string image = "sheet";
        private const int x = 200;
        private const int y = 200;
        //new Vector2(400, 200)
        //private Texture2D texture = Content.Load<Texture2D>("sheet");

        public Barbarian(ContentManager content, int rows, int cols) 
            : base(BarbarianAttack, BarbarianDefense, rows, cols)
        {
            this.Texture = content.Load<Texture2D>(image);
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(x,y));
        }
    }
}
