namespace CherryQuest.App
{
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Models.BackgroundObjects;
    using Models.Characters;
    using Models.Monsters;
    using Models.Spells;

    public class Battle : CherryGame
    {
        public Battle(SpriteBatch spriteBatch, BackgroundObject background, Character character, Monster monster)
        {
            this.Background = background;
            this.Character = character;
            this.Monster = monster;
            this.SpriteBatch = spriteBatch;
        }

        private BackgroundObject Background { get; set; }

        private Character Character { get; set; }

        private Monster Monster { get; set; }

        private SpriteBatch SpriteBatch { get; set; }

        public void Run(GameTime gameTime)
        {

            this.Update();
            this.Draw(gameTime);
        }

        protected override void Initialize()
        {
            this.Character.X = 0;
            this.Monster.X = 1400;

            
        }


        private void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.X))
            {
                this.Character.UseSpell("Fire");
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                this.Character.UseSpell("Ice");
            }

            foreach (var spell in this.Character.Spells)
            {
                if (!spell.BoundingBox.Intersects(this.Monster.BoundingBox))
                {
                    spell.X += 5;
                }
                else
                {
                    this.Character.TakeDemage(this.Monster);
                    spell.Dispose();
                }
            }

        }

        protected override void Draw(GameTime gameTime)
        {
            this.Background.Draw(this.SpriteBatch);
            this.Monster.Draw(this.SpriteBatch);
            this.Character.Draw(this.SpriteBatch);
            if (this.Character.Spells.Any())
            {
                foreach (var spell in this.Character.Spells)
                {
                    //TODO the spell is not animaited, I couldn't worked it out, Edo need help
                    spell.Draw(this.SpriteBatch);
                }
            }
            
        }

    }
}