namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Behemoth : Monster
    {
        private const int BehemothHealth = 160;
        private const int BehemothAttack = 40;
        private const int BehemothDefence = 30;

        //TODO Content
        public Behemoth(Texture2D texture, int rows, int cols)
            : base(BehemothHealth, BehemothAttack, BehemothDefence, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
