namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Basilisk : Monster
    {
        private const int BasiliskHealth = 80;
        private const int BasiliskAttack = 25;
        private const int BasiliskDefence = 25;

        public Basilisk(int rows, int cols, ContentManager content)
            : base(BasiliskHealth, BasiliskAttack, BasiliskDefence, rows, cols, content)
        {
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
