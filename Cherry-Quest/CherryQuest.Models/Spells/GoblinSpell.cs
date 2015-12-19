namespace CherryQuest.Models.Spells
{
    using Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class GoblinSpell : Spell
    {
        private const string Image = "goblinSpell";
        private const int SpriteRows = 8;
        private const int SpriteCols = 8;

        public GoblinSpell(ContentManager content, int x, int y) 
            : base(SpriteRows, SpriteCols)
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
