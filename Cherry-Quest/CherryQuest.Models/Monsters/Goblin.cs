namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Goblin : Monster
    {
        private const int GoblinHealth = 30;
        private const int GoblinAttack = 10;
        private const int GoblinDefence = 7;
        private const string Image = "goblin";
        private const int RowsSplit = 7;
        private const int ColsSplit = 6;

        //TODO Content
        public Goblin(ContentManager content, int x, int y)
            : base(GoblinHealth, GoblinAttack, GoblinDefence, RowsSplit, ColsSplit)
        {
            this.Texture = content.Load<Texture2D>(Image);

            //TODO validations
            this.X = x;
            this.Y = y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(this.X, this.Y),this.ObjectState);
        }
    }
}