namespace CherryQuest.App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using Factories;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Models;
    using Models.BackgroundObjects;
    using Models.Characters;
    using Models.Enums;
    using Models.Interfaces;
    using Models.Monsters;

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
        private Battle batlle;

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

            this.background = new BackgroundObject(this.Content,"bg1");

            IDrawableGameObject barbarian = CharacterFactory.Create("Barbarian", this.Content, 100, 400);
            IDrawableGameObject goblin = MonsterFactory.Create("Goblin", this.Content, 500, 400);
            //IDrawableGameObject ranger = CharacterFactory.Create("Ranger", this.Content, 400, 200);


            this.gameObjects.Add(barbarian);
            this.gameObjects.Add(goblin);
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
            bool checkIfMonsterDead = false;
            
            foreach (var drawableGameObject in this.gameObjects)
            {

                if (Keyboard.GetState().GetPressedKeys().Any() /*&& typeof(Character) == drawableGameObject.GetType()*/)
                {
                    if (typeof (Character) == drawableGameObject.GetType().BaseType && Keyboard.GetState().IsKeyDown(Keys.D))
                    {
                        ((Character) drawableGameObject).X += 10;
                        ((Character) drawableGameObject).Effects = SpriteEffects.None;
                        ((Character) drawableGameObject).ObjectState = ObjectState.Moving;
                     
                    }

                    if (typeof(Character) == drawableGameObject.GetType().BaseType && Keyboard.GetState().IsKeyDown(Keys.A))
                    {
                        ((Character)drawableGameObject).X -= 10;
                        ((Character)drawableGameObject).Effects = SpriteEffects.FlipHorizontally;
                        ((Character)drawableGameObject).ObjectState = ObjectState.Moving;
                    }
                }
                else if (typeof(Character) == drawableGameObject.GetType().BaseType)
                {
                    ((Character)drawableGameObject).ObjectState = ObjectState.Idle;
                }

                var barb = this.gameObjects.OfType<Barbarian>().First();
                var goblin = this.gameObjects.OfType<Monster>().FirstOrDefault();

                if (goblin != null && barb.BoundingBox.Intersects(goblin.BoundingBox))
                {
                    barb.X -= 10;
                    goblin.ObjectState = ObjectState.Moving;
                    goblin.Effects = SpriteEffects.FlipHorizontally;
                    if (Keyboard.GetState().IsKeyDown(Keys.Space) && this.batlle == null)
                    {
                        this.batlle = new Battle(this.spriteBatch, new BackgroundObject(this.Content, "battlebackground"), barb, goblin);
                        this.batlle.Initialize();
                    }
                }

                if (goblin != null && goblin.Health < 0)
                {
                    this.batlle = null;
                    checkIfMonsterDead = true;
                }

                drawableGameObject.Update();
            }

            if (checkIfMonsterDead)
            {
                gameObjects.RemoveAll(p => p.GetType() == typeof (Goblin));
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

            if (this.batlle != null)
            {
                this.batlle.Run(gameTime);
            }
            else
            {
                this.background.Draw(this.spriteBatch);

                foreach (var drawableGameObject in this.gameObjects)
                {
                    drawableGameObject.Draw(this.spriteBatch);
                }
            }

            base.Draw(gameTime);
        }

    }
}
