namespace CherryQuest.Models.BackgroundObjects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class BackgroundObject
    {
        private readonly Texture2D texture;

        public BackgroundObject(ContentManager content, string img)
        {
            this.Image = img;
            this.texture = content.Load<Texture2D>(this.Image);
        }

        private string Image { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, new Vector2(0, 0), null,
                Color.White, 0f, Vector2.Zero, 1.65f, SpriteEffects.None, 0f);
            //spriteBatch.Draw(this.texture, new Vector2(0, 0));
            spriteBatch.End();
        }
    }
}
