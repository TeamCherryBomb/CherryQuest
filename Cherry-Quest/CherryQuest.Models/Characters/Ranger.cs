namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Ranger : Character
    {
        private const int RangerAttack = 8;
        private const int RangerDefense = 4;
        private const string Image = "dude";
        private const int RowsSplit = 5;
        private const int ColsSplit = 6;

        //TODO Content
        public Ranger(ContentManager content, int x, int y)
            : base(RangerAttack, RangerDefense, RowsSplit, ColsSplit)
        {
            this.Texture = content.Load<Texture2D>(Image);
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
