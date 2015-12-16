namespace CherryQuest.Models
{
    using Enums;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class DrawableGameObject : IDrawableGameObject
    {
        private int currentFrame;
        private readonly int totalFrames;

        protected DrawableGameObject(int rows, int cols)
        {
            this.Rows = rows;
            this.Columns = cols;
            this.currentFrame = 0;
            this.totalFrames = this.Rows * this.Columns;
            this.Rotation = 0f;
            this.Effects = SpriteEffects.None;
        }

        public Texture2D Texture { get; set; }

        public int Rows { get; }

        public int Columns { get; }

        public float Rotation { get; set; }

        protected int SpriteWidth { get; set; }

        protected int SpriteHeight { get; set; }

        public SpriteEffects Effects { get; set; }

        public void Update()
        {
            this.currentFrame = (this.currentFrame + 1) % this.totalFrames;
        }


        public abstract void Draw(SpriteBatch spriteBatch);

        public void Draw(SpriteBatch spriteBatch, Vector2 location, ObjectState state)
        {
            this.SpriteWidth = this.Texture.Width / this.Columns;
            this.SpriteHeight = this.Texture.Height / this.Rows;

            if (state == ObjectState.Moving)
            {
                int row = (int)((float)this.currentFrame / this.Columns);
                int column = this.currentFrame % this.Columns;

                var sourceRectangle = new Rectangle(this.SpriteWidth * column, this.SpriteHeight * row, this.SpriteWidth, this.SpriteHeight);
                var destinationRectangle = new Rectangle((int)location.X, (int)location.Y, this.SpriteWidth, this.SpriteHeight);

                spriteBatch.Begin();
                spriteBatch.Draw(this.Texture, destinationRectangle, sourceRectangle, Color.White, this.Rotation, new Vector2(0, 0), this.Effects, 0f);
                spriteBatch.End();
            }
            else
            {
                var sourceRectangle = new Rectangle(0, 0, this.SpriteWidth, this.SpriteHeight);
                var destinationRectangle = new Rectangle((int)location.X, (int)location.Y, this.SpriteWidth, this.SpriteHeight);

                spriteBatch.Begin();
                spriteBatch.Draw(this.Texture, destinationRectangle, sourceRectangle, Color.White, this.Rotation, new Vector2(0, 0), this.Effects, 0f);
                spriteBatch.End();
            }
            
        }
    }
}
