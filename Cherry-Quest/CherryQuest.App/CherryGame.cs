namespace CherryQuest.App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Factories;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Models.BackgroundObjects;
    using Models.Characters;
    using Models.Enums;
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
        private BackgroundObject background;

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
            graphics.PreferredBackBufferHeight = CanvasHeight;
            graphics.PreferredBackBufferWidth = CanvasWidth;
            graphics.ApplyChanges();
            this.IsMouseVisible = true;

            var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            form.Location = new System.Drawing.Point(0, 0);

            var drawOnScreen = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            drawOnScreen.Location = new System.Drawing.Point(0, 0);

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

            this.background = new BackgroundObject(this.Content);

            IDrawableGameObject barbarian = CharacterFactory.Create("Barbarian", this.Content, 100, 400);
            IDrawableGameObject cleric = CharacterFactory.Create("Cleric", this.Content, 500, 400);
            //IDrawableGameObject ranger = CharacterFactory.Create("Ranger", this.Content, 400, 200);


            this.gameObjects.Add(barbarian);
            this.gameObjects.Add(cleric);
            //this.gameObjects.Add(ranger);
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
                if (Keyboard.GetState().GetPressedKeys().Any())
                {
                    if (typeof (Barbarian) == drawableGameObject.GetType() && Keyboard.GetState().IsKeyDown(Keys.D))
                    {
                        ((Character) drawableGameObject).X += 10;
                        ((Character) drawableGameObject).Effects = SpriteEffects.None;
                        ((Character) drawableGameObject).ObjectState = ObjectState.Moving;
                     
                    }

                    if (typeof(Barbarian) == drawableGameObject.GetType() && Keyboard.GetState().IsKeyDown(Keys.A))
                    {
                        ((Character)drawableGameObject).X -= 10;
                        ((Character)drawableGameObject).Effects = SpriteEffects.FlipHorizontally;
                        ((Character)drawableGameObject).ObjectState = ObjectState.Moving;
                    }
                }
                else
                {
                    ((Character)drawableGameObject).ObjectState = ObjectState.Idle;
                }

                var barb = this.gameObjects.OfType<Barbarian>().First();
                var cleric = this.gameObjects.OfType<Cleric>().FirstOrDefault();

                if (cleric != null && barb.BoundingBox.Intersects(cleric.BoundingBox))
                {
                    cleric.X += 10;
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

            this.background.Draw(this.spriteBatch);

            foreach (var drawableGameObject in this.gameObjects)
            {
                drawableGameObject.Draw(this.spriteBatch);
            }

            base.Draw(gameTime);
        }
    }
}
