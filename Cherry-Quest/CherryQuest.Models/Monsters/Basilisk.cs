namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Basilisk : Monster
    {
        private const int BasiliskHealth = 80;
        private const int BasiliskAttack = 25;
        private const int BasiliskDefence = 25;

        public Basilisk(Texture2D texture, int rows, int cols)
            : base(BasiliskHealth, BasiliskAttack, BasiliskDefence, rows, cols)
        {
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
