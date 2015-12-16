namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Efreet : Monster
    {
        private const int EfreetHealth = 80;
        private const int EfreetAttack = 45;
        private const int EfreetDefence = 25;

        //TODO Content
        public Efreet(Texture2D texture, int rows, int cols)
            : base(EfreetHealth, EfreetAttack, EfreetDefence, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
