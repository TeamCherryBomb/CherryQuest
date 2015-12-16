namespace CherryQuest.App
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Factories;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Models.Characters;
    using Models.Interfaces;

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class CherryGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private List<IDrawableGameObject> gameObjects;

        public CherryGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            gameObjects = new List<IDrawableGameObject>();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            IDrawableGameObject barberian = CharacterFactory.Create("Barbarian", this.Content, 4, 6);
            IDrawableGameObject cleric = CharacterFactory.Create("Cleric", this.Content, 2, 5);

            gameObjects.Add(barberian);
            gameObjects.Add(cleric);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (var drawableGameObject in gameObjects)
            {
                drawableGameObject.Update();
            }
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            foreach (var drawableGameObject in gameObjects)
            {
                drawableGameObject.Draw(spriteBatch);
            }
            

            base.Draw(gameTime);
        }
    }
}
