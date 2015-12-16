namespace CherryQuest.Models.Interfaces
{
    using Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IDrawableGameObject
    {
        Texture2D Texture { get; set; }

        int Rows { get; }

        int Columns { get; }

        void Update();

        void Draw(SpriteBatch spriteBatch, Vector2 location, ObjectState state);

        void Draw(SpriteBatch spriteBatch);
    }
}
