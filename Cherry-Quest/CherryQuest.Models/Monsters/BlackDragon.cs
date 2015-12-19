namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class BlackDragon : Monster
    {
        private const int BlackHealth = 50;
        private const int BlackAttack = 50;
        private const int BlackDefence = 7;
        private const string Image = "blackdragon";
        private const int RowsSplit = 4;
        private const int ColsSplit = 4;

        //TODO Content
        public BlackDragon(ContentManager content, int x, int y)
            : base(BlackHealth, BlackAttack, BlackDefence, RowsSplit, ColsSplit, content)
        {
            this.Texture = content.Load<Texture2D>(Image);

            //TODO validations
            this.X = x;
            this.Y = y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, new Vector2(this.X, this.Y), this.ObjectState);
        }
    }
}
