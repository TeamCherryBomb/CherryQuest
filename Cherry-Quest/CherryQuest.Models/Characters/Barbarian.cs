namespace CherryQuest.Models.Characters
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime;
    using Enums;
    using Interfaces;
    using Microsoft.Win32.SafeHandles;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Monsters;
    using Spells;

    public class Barbarian : Character
    {
        private const int BarbarianAttack = 10;
        private const int BarbarianDefense = 2;
        private const string Image = "dude";
        private const int RowsSplit = 5;
        private const int ColsSplit = 6;

        public Barbarian(ContentManager content, int x, int y)
            : base(BarbarianAttack, BarbarianDefense, RowsSplit, ColsSplit)
        {
            this.Texture = content.Load<Texture2D>(Image);

            //TODO validations
            this.ContentManager = content;
            this.X = x;
            this.Y = y;
            this.Spells = new List<ISpell>();
        }

        //TODO could be make list of spell and factory


        public ContentManager ContentManager { get; set; }

        public override void Draw(SpriteBatch spriteBatch)
        {

            this.Draw(spriteBatch, new Vector2(this.X, this.Y), this.ObjectState);
        }

        public override void UseSpell(string attackName)
        {
            switch (attackName)
            {
                case "Fire":
                    {
                        this.Spells.Add(new BarbFireSpell(this.ContentManager, this.X + 125, this.Y + 50));
                        break;
                    }
                case "Ice":
                    {
                        this.Spells.Add(new BarbIceSpell(this.ContentManager, this.X + 125, this.Y + 50));
                        break;
                    }

            }
        }
    }
}
