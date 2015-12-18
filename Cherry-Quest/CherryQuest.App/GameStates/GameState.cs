namespace CherryQuest.App.GameStates
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Models.BackgroundObjects;
    using Models.Characters;
    using Models.Interfaces;

    public abstract class GameState : CherryGame , IChangeGameState
    {
        protected GameState(BackgroundObject background, Character character, SpriteBatch spriteBatch)
        {
            this.Background = background;
            this.Character = character;
            this.SpriteBatch = spriteBatch;
        }

        public BackgroundObject Background { get; set; }

        public Character Character { get; set; }

        public SpriteBatch SpriteBatch { get; set; }

        public abstract void Run(GameTime gameTime);

    }
}