namespace CherryQuest.Models
{
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class DrawableGameObject : IDrawableGameObject
    {
        private int currentFrame;
        private readonly int totalFrames;

        protected DrawableGameObject(Texture2D texture, int rows, int cols)
        {
            this.Texture = texture;
            this.Rows = rows;
            this.Columns = cols;
            this.currentFrame = 0;
            this.totalFrames = this.Rows * this.Columns;
        }

        public Texture2D Texture { get; }

        public int Rows { get; }

        public int Columns { get; }

        public void Update()
        {
            this.currentFrame = (this.currentFrame + 1) % this.totalFrames;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = this.Texture.Width / this.Columns;
            int height = this.Texture.Height / this.Rows;
            int row = (int)((float)this.currentFrame / this.Columns);
            int column = this.currentFrame % this.Columns;

            var sourceRectangle = new Rectangle(width * column, height * row, width, height);
            var destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
