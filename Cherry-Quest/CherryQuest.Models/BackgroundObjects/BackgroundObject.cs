namespace CherryQuest.Models.BackgroundObjects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class BackgroundObject : DrawableGameObject
    {
        private const string Image = "bg1";
        private readonly Rectangle mainFrame;

        public BackgroundObject(ContentManager content, GraphicsDevice device) 
            : base(1, 1)
        {
            this.Texture = content.Load<Texture2D>(Image);
            mainFrame = new Rectangle(0, 0, device.Viewport.Width, device.Viewport.Height);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(0, 0));
        }
    }
}
