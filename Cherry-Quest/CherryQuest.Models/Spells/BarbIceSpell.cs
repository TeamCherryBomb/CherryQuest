namespace CherryQuest.Models.Spells
{
    using Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class BarbIceSpell : Spell
    {
        private const string Image = "icespell";
        private const int RowsSplit = 8;
        private const int ColsSplit = 8;

        public BarbIceSpell(ContentManager content, int x, int y) : base(RowsSplit, ColsSplit)
        {
            this.Texture = content.Load<Texture2D>(Image);
            this.ObjectState = ObjectState.Moving;
            this.X = x;
            this.Y = y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(this.X, this.Y), this.ObjectState);
        }
    }
}