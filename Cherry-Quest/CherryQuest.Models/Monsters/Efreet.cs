namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Efreet : Monster
    {
        private const int EfreetHealth = 80;
        private const int EfreetAttack = 45;
        private const int EfreetDefence = 25;

        //TODO Content
        public Efreet(int rows, int cols, ContentManager content)
            : base(EfreetHealth, EfreetAttack, EfreetDefence, rows, cols, content)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
