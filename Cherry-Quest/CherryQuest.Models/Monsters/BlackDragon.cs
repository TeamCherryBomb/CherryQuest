namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class BlackDragon : Monster
    {
        private const int BlackHealth = 180;
        private const int BlackAttack = 50;
        private const int BlackDefence = 50;

        //TODO Content
        public BlackDragon(Texture2D texture, int rows, int cols)
            : base(BlackHealth, BlackAttack, BlackDefence, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
