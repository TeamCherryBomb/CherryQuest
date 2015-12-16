namespace CherryQuest.Models.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IDrawableGameObject
    {
        Texture2D Texture { get; set; }

        int Rows { get; }

        int Columns { get; }

        void Update();

        void Draw(SpriteBatch spriteBatch, Vector2 location);

        void Draw(SpriteBatch spriteBatch);
    }
}
