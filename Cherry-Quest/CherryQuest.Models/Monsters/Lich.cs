namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Lich : Monster
    {
        private const int LichHealth = 70;
        private const int LichAttack = 25;
        private const int LichDefence = 15;

        //TODO Content
        public Lich(Texture2D texture, int rows, int cols)
            : base(LichHealth, LichAttack, LichDefence, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
