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

    public class Battle : GameState , IBattle
    {
        private const int  MonsterStartX = 1400;
        private const int  CharecterStartX = 0;

        //Vsichko zakomentirano trqbva da se iztrie idva ot GameState ostavam go da ti e po-lesno da se orientirash

        public Battle(SpriteBatch spriteBatch, BackgroundObject background, Character character, Monster monster)
            :base(background, character, spriteBatch)
        {
            
            //this.Background = background;
            //this.Character = character;
            this.Monster = monster;
            //this.SpriteBatch = spriteBatch;
        }

        // public BackgroundObject Background { get; set; }

        // public Character Character { get; set; }

        public Monster Monster { get; set; }

        //public SpriteBatch SpriteBatch { get; set; }

        public override void Run(GameTime gameTime)
        {

            this.Update();
            this.Draw(gameTime);
        }

        protected override void Initialize()
        {
            this.Character.X = CharecterStartX;
            this.Monster.X = MonsterStartX;
            foreach (var spell in this.Character.Spells)
            {
               
                    spell.Dispose();
            }
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

                spell.Update();
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
                    spell.Draw(this.SpriteBatch);
                }
            }

        }

    }
}