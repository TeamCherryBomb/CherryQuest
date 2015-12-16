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
        private const int CanvasHeight = 820;
        private const int CanvasWidth = 1680;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private List<IDrawableGameObject> gameObjects;

        public CherryGame()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.gameObjects = new List<IDrawableGameObject>();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.graphics.PreferredBackBufferHeight = CanvasHeight;
            this.graphics.PreferredBackBufferWidth = CanvasWidth;
            this.graphics.ApplyChanges();

            var drawOnScreen = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            drawOnScreen.Location = new System.Drawing.Point(100, 100);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);

            IDrawableGameObject barberian = CharacterFactory.Create("Barbarian", this.Content, 200, 50);
            IDrawableGameObject cleric = CharacterFactory.Create("Cleric", this.Content, 200, 200);

            this.gameObjects.Add(barberian);
            this.gameObjects.Add(cleric);
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
                this.Exit();


            foreach (var drawableGameObject in this.gameObjects)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    if (typeof (Barbarian) == drawableGameObject.GetType())
                    {
                        ((Character)drawableGameObject).X += 10;
                    }
                }
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
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            foreach (var drawableGameObject in this.gameObjects)
            {
                drawableGameObject.Draw(this.spriteBatch);
            }

            base.Draw(gameTime);
        }
    }
}
