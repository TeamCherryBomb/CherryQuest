namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Lich : Monster
    {
        private const int LichHealth = 70;
        private const int LichAttack = 25;
        private const int LichDefence = 15;

        public Lich(Texture2D texture, int rows, int cols)
            : base(LichHealth, LichAttack, LichDefence, texture, rows, cols)
        {
        }
    }
}
