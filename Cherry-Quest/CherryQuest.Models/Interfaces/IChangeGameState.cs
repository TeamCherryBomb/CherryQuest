namespace CherryQuest.Models.Interfaces
{
    using BackgroundObjects;
    using Characters;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IChangeGameState
    {
        BackgroundObject Background { get; set; }

        Character Character { get; set; }

        SpriteBatch SpriteBatch { get; set; }

        void Run(GameTime gameTime);
    }
}