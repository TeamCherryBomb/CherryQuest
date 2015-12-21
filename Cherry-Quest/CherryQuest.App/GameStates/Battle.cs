namespace CherryQuest.App.GameStates
{
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Models.BackgroundObjects;
    using Models.Characters;
    using Models.Interfaces;
    using Models.Monsters;

    public class Battle : GameState, IBattle
    {
        private const int MonsterStartX = 1400;
        private const int CharacterStartX = 0;

        private readonly SpriteFont font;

        public Battle(SpriteBatch spriteBatch, BackgroundObject background, Character character, Monster monster, SpriteFont font)
            : base(background, character, spriteBatch)
        {
            this.Monster = monster;
            this.font = font;
        }

        public Monster Monster { get; set; }

        public override void Run(GameTime gameTime)
        {

            this.Update(gameTime);
            this.Draw(gameTime);
        }

        protected override void Initialize()
        {
            this.Character.X = CharacterStartX;
            this.Monster.X = MonsterStartX;
            foreach (var spell in this.Character.Spells)
            {
                spell.Dispose();
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.X))
            {
                this.Character.UseSpell("Fire");
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                this.Character.UseSpell("Ice");
            }

            this.Monster.PerformAttack(gameTime);

            foreach (var spell in this.Character.Spells)
            {
                if (!spell.BoundingBox.Intersects(this.Monster.BoundingBox))
                {
                    spell.X += 5;
                }
                else
                {
                    this.Character.DealDamage(this.Monster);
                    spell.Dispose();
                }

                spell.Update();
            }

            foreach (var spell in this.Monster.Attacks)
            {
                if (!spell.BoundingBox.Intersects(this.Character.BoundingBox))
                {
                    spell.X -= 15;
                }
                else
                {
                    this.Character.RespondToAttack(this.Monster.Attack, gameTime);
                    spell.Dispose();
                }

                spell.Update();
            }

        }

        protected override void Draw(GameTime gameTime)
        {
            this.Background.Draw(this.SpriteBatch);
            this.Monster.Draw(this.SpriteBatch);
            this.Character.Draw(this.SpriteBatch);

            this.DrawStats();

            if (this.Character.Spells.Any())
            {
                foreach (var spell in this.Character.Spells)
                {
                    spell.Draw(this.SpriteBatch);
                }
            }

            if (this.Monster.Attacks.Any())
            {
                foreach (var spell in this.Monster.Attacks)
                {
                    spell.Draw(this.SpriteBatch);
                }
            }
        }

        protected override void DrawStats()
        {
            this.SpriteBatch.Begin();
            this.SpriteBatch.DrawString(this.font, $"Health: {this.Character.Health}", new Vector2(30, 30), Color.White);
            this.SpriteBatch.DrawString(this.font, $"Health: {this.Monster.Health}", new Vector2(800, 30), Color.White);
            this.SpriteBatch.End();
        }
    }
}