namespace CherryQuest.Models.Spells
{
    using Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    //TODO The abstraciotn could be raised. We can have only one class Spell and it can be inherit by ClericMainSpell and etc.
    public class BarbFireSpell : Spell
    {
        private const string Image = "firespell";
        private const int RowsSplit = 4;
        private const int ColsSplit = 5;

        public BarbFireSpell(ContentManager content, int x, int y) : base(RowsSplit, ColsSplit)
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