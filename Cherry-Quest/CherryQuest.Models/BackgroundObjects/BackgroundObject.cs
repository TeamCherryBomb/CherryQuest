namespace CherryQuest.Models.BackgroundObjects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class BackgroundObject
    {
        private const string Image = "bg1";
        private readonly Texture2D texture;

        public BackgroundObject(ContentManager content) 
        {
            this.texture = content.Load<Texture2D>(Image);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, new Vector2(0, 0), null,
        Color.White, 0f, Vector2.Zero, 1.65f, SpriteEffects.None, 0f);
            spriteBatch.End();
        }
    }
}
