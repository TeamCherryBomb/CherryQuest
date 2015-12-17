namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Cleric : Character
    {
        private const int ClericAttack = 4;
        private const int ClericDefense = 8;
        private const string Image = "test";
        private const int RowsSplit = 2;
        private const int ColsSplit = 5;

        //TODO Context
        public Cleric(ContentManager content, int x, int y) 
            : base(ClericAttack, ClericDefense, RowsSplit, ColsSplit)
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

        public override void UseSpell(string attackName)
        {
            throw new System.NotImplementedException();
        }
    }
}
